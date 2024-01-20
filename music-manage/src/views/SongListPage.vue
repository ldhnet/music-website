<template>
  <div class="container">
    <div class="handle-box">
      <el-button @click="deleteAll">批量删除</el-button>
      <el-input v-model="searchWord" placeholder="筛选关键词"></el-input>
      <el-button type="primary" @click="centerDialogVisible = true">添加歌单</el-button>
    </div>
    <el-table height="550px" border size="small" :data="data" @selection-change="handleSelectionChange">
      <el-table-column type="selection" width="40" align="center"></el-table-column>
      <el-table-column label="ID" prop="Id" width="50" align="center"></el-table-column>
      <el-table-column label="歌单图片" width="110" align="center">
        <template v-slot="scope">
          <img :src="attachImageUrl(scope.row.Pic)" style="width: 80px"/>
          <el-upload action :http-request="(params)=>uploadUrl(params,scope.row.Id)" :show-file-list="false" :on-success="handleImgSuccess"
                     :before-upload="beforeImgUpload">
            <el-button>更新图片</el-button>
          </el-upload>
        </template>
      </el-table-column>
      <el-table-column prop="Title" label="标题" width="200"></el-table-column>
      <el-table-column label="简介">
        <template v-slot="scope">
          <p style="height: 100px; overflow: scroll">
            {{ scope.row.Introduction }}
          </p>
        </template>
      </el-table-column>
      <el-table-column label="风格" prop="Style" width="100"></el-table-column>
      <el-table-column label="内容" width="90" align="center">
        <template v-slot="scope">
          <el-button @click="goContentPage(scope.row.Id)">内容</el-button>
        </template>
      </el-table-column>
      <el-table-column label="评论" width="90" align="center">
        <template v-slot="scope">
          <el-button @click="goCommentPage(scope.row.Id)">评论</el-button>
        </template>
      </el-table-column>
      <el-table-column label="操作" width="160" align="center">
        <template v-slot="scope">
          <el-button @click="editRow(scope.row)">编辑</el-button>
          <el-button type="danger" @click="deleteRow(scope.row.Id)">删除</el-button>
        </template>
      </el-table-column>
    </el-table>
    <el-pagination
        class="pagination"
        background
        layout="total, prev, pager, next"
        :current-page="currentPage"
        :page-size="pageSize"
        :total="tableData.length"
        @current-change="handleCurrentChange"
    >
    </el-pagination>
  </div>

  <!--添加歌单-->
  <el-dialog title="添加歌单" v-model="centerDialogVisible">
    <el-form label-width="70px" :model="registerForm">
      <el-form-item label="歌单名" prop="Title">
        <el-input v-model="registerForm.Title"></el-input>
      </el-form-item>
      <el-form-item label="歌单介绍" prop="Introduction">
        <el-input v-model="registerForm.Introduction"></el-input>
      </el-form-item>
      <el-form-item label="风格" prop="Style">
        <el-input v-model="registerForm.Style"></el-input>
      </el-form-item>
    </el-form>
    <template #footer>
      <span class="dialog-footer">
        <el-button @click="centerDialogVisible = false">取 消</el-button>
        <el-button type="primary" @click="addsongList">确 定</el-button>
      </span>
    </template>
  </el-dialog>

  <!-- 编辑弹出框 -->
  <el-dialog title="编辑" v-model="editVisible">
    <el-form :model="editForm">
      <el-form-item label="标题">
        <el-input v-model="editForm.Title"></el-input>
      </el-form-item>
      <el-form-item label="简介">
        <el-input type="textarea" v-model="editForm.Introduction"></el-input>
      </el-form-item>
      <el-form-item label="风格">
        <el-input v-model="editForm.Style"></el-input>
      </el-form-item>
    </el-form>
    <template #footer>
      <span class="dialog-footer">
        <el-button @click="editVisible = false">取 消</el-button>
        <el-button type="primary" @click="saveEdit">确 定</el-button>
      </span>
    </template>
  </el-dialog>

  <!-- 删除提示框 -->
  <yin-del-dialog :delVisible="delVisible" @confirm="confirm" @cancelRow="delVisible = $event"></yin-del-dialog>
</template>

<script lang="ts">
import {computed, defineComponent, getCurrentInstance, reactive, ref, watch} from "vue";
import mixin from "@/mixins/mixin";
import {HttpManager} from "@/api/index";
import {RouterName} from "@/enums";
import YinDelDialog from "@/components/dialog/YinDelDialog.vue";
import console, { Console } from "console";

export default defineComponent({
  components: {
    YinDelDialog,
  },
  setup() {
    const {proxy} = getCurrentInstance();
    const {routerManager, beforeImgUpload} = mixin();

    const tableData = ref([]); // 记录歌曲，用于显示
    const tempDate = ref([]); // 记录歌曲，用于搜索时能临时记录一份歌曲列表
    const pageSize = ref(5); // 页数
    const currentPage = ref(1); // 当前页

    // 计算当前表格中的数据
    const data = computed(() => {
      return tableData.value.slice((currentPage.value - 1) * pageSize.value, currentPage.value * pageSize.value);
    });

    const searchWord = ref(""); // 记录输入框输入的内容
    watch(searchWord, () => {
      if (searchWord.value === "") {
        tableData.value = tempDate.value;
      } else {
        tableData.value = [];
        for (let item of tempDate.value) {
          if (item.title.includes(searchWord.value)) {
            tableData.value.push(item);
          }
        }
      }
    });

    getData();

    // 获取歌单信息
    async function getData() {
      tableData.value = [];
      tempDate.value = [];
      const result = (await HttpManager.getSongList()) as ResponseBody;
      tableData.value = result.Data;
      tempDate.value = result.Data;
      currentPage.value = 1;
    }

    // 获取当前页
    function handleCurrentChange(val) {
      currentPage.value = val;
    }

    function uploadUrl(item,id) {
      let form = new FormData();
      form.append("id", id); 
      form.append("file", item.file);   
      var param ={
        id:id,
        data:form
      }  

      return HttpManager.updateSongListImg(param);
    }

    // 更新图片
    function handleImgSuccess(response, file) {  
      (proxy as any).$message({
        message: response.data.Description,
        type: response.data.Tag,
      });
      if (response.data.Tag == 1) getData();
    }

    /**
     * 路由
     */
    function goContentPage(id) {
      const breadcrumbList = reactive([
        {
          path: RouterName.SongList,
          name: "歌单管理",
        },
        {
          path: "",
          name: "歌单内容",
        },
      ]);
      proxy.$store.commit("setBreadcrumbList", breadcrumbList);
      routerManager(RouterName.ListSong, {path: RouterName.ListSong, query: {id}});
    }

    function goCommentPage(id) {
      const breadcrumbList = reactive([
        {
          path: RouterName.SongList,
          name: "歌单管理",
        },
        {
          path: "",
          name: "评论详情",
        },
      ]);
      proxy.$store.commit("setBreadcrumbList", breadcrumbList);
      routerManager(RouterName.Comment, {path: RouterName.Comment, query: {id, type: 1}});
    }

    /**
     * 添加
     */
    const centerDialogVisible = ref(false);
    const registerForm = reactive({
      Title: "",
      Introduction: "",
      Style: "",
    });

    async function addsongList() {
      let title = registerForm.Title;
      let introduction = registerForm.Introduction;
      let style = registerForm.Style;
      const result = (await HttpManager.setSongList({title, introduction, style})) as ResponseBody;
      (proxy as any).$message({
        message: result.Description,
        type: result.Tag,
      });

      if (result.Tag == 1) {
        getData();
        registerForm.Title = "";
        registerForm.Introduction = "";
        registerForm.Style = "";
      }
      centerDialogVisible.value = false;
    }

    /**
     * 编辑
     */
    const editVisible = ref(false);
    const editForm = reactive({
      Id: "",
      Title: "",
      Pic: "",
      Introduction: "",
      Style: "",
    });

    function editRow(row) {
      idx.value = row.Id;
      editForm.Id = row.Id;
      editForm.Title = row.Title;
      editForm.Pic = row.Pic;
      editForm.Introduction = row.Introduction;
      editForm.Style = row.Style;
      editVisible.value = true;
    }

    async function saveEdit() {

      let id = editForm.Id;
      let title = editForm.Title;
      let introduction = editForm.Introduction;
      let style = editForm.Style;

      const result = (await HttpManager.updateSongListMsg({id, title, introduction, style})) as ResponseBody;
      (proxy as any).$message({
        message: result.Description,
        type: result.Tag,
      });

      if (result.Tag == 1) getData();
      editVisible.value = false;
    }

    /**
     * 删除
     */
    const idx = ref(-1); // 记录当前要删除的行
    const multipleSelection = ref([]); // 记录当前要删除的列表
    const delVisible = ref(false); // 显示删除框

    async function confirm() {
      const result = await HttpManager.deleteSongList(idx.value) as ResponseBody;
      (proxy as any).$message({
        message: result.Description,
        type: result.Tag,
      });
      if (result.Tag == 1) getData();
      delVisible.value = false;
    }

    function deleteRow(id) {
      idx.value = id;
      delVisible.value = true;
    }

    function handleSelectionChange(val) {
      multipleSelection.value = val;
    }

    function deleteAll() {
      for (let item of multipleSelection.value) {
        deleteRow(item.id);
        confirm();
      }
      multipleSelection.value = [];
    }

    return {
      searchWord,
      data,
      tableData,
      centerDialogVisible,
      editVisible,
      delVisible,
      pageSize,
      currentPage,
      registerForm,
      editForm,
      addsongList,
      deleteAll,
      handleSelectionChange,
      handleImgSuccess,
      beforeImgUpload,
      saveEdit,
      attachImageUrl: HttpManager.attachImageUrl,
      uploadUrl,
      editRow,
      handleCurrentChange,
      confirm,
      deleteRow,
      goContentPage,
      goCommentPage,
    };
  },
});
</script>

<style scoped></style>
