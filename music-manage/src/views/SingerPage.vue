<template>
  <div class="container">
    <div class="handle-box">
      <el-button @click="deleteAll">批量删除</el-button>
      <el-input placeholder="筛选歌手" v-model="searchWord"></el-input>
      <el-button type="primary" @click="centerDialogVisible = true">添加歌手</el-button>
    </div>
    <el-table height="700px" border size="small" :data="data" @selection-change="handleSelectionChange">
      <el-table-column type="selection" width="40" align="center"></el-table-column>
      <el-table-column label="ID" prop="Id" width="50" align="center"></el-table-column>
      <el-table-column label="歌手图片" prop="pic" width="110" align="center">
        <template v-slot="scope">
          <div class="singer-img">
            <img :src="attachImageUrl(scope.row.Pic)" style="width: 100%" />
          </div>
          <el-upload action :http-request="(params)=>uploadUrl(params,scope.row.Id)" :show-file-list="false" :on-success="handleImgSuccess" :before-upload="beforeImgUpload">
            <el-button>更新图片</el-button>
          </el-upload>
        </template>
      </el-table-column>
      <el-table-column label="歌手" prop="Name" width="120" align="center"></el-table-column>
      <el-table-column label="性别" prop="Sex" width="60" align="center">
        <template v-slot="scope">
          <div>{{ changeSex(scope.row.Sex) }}</div>
        </template>
      </el-table-column>
      <el-table-column label="出生" prop="Birth" width="120" align="center">
        <template v-slot="scope">
          <div>{{ getBirth(scope.row.Birth) }}</div>
        </template>
      </el-table-column>
      <el-table-column label="地区" prop="Location" width="100" align="center"></el-table-column>
      <el-table-column label="简介" prop="Introduction">
        <template v-slot="scope">
          <p style="height: 100px; overflow: scroll">
            {{ scope.row.Introduction }}
          </p>
        </template>
      </el-table-column>
      <el-table-column label="歌曲管理" width="120" align="center">
        <template v-slot="scope">
          <el-button @click="goSongPage(scope.row)">歌曲管理</el-button>
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

  <!-- 添加 -->
  <el-dialog title="添加歌手" v-model="centerDialogVisible">
    <el-form label-width="80px" :model="registerForm" :rules="singerRule">
      <el-form-item label="歌手名" prop="Name">
        <el-input v-model="registerForm.Name"></el-input>
      </el-form-item>
      <el-form-item label="性别" prop="Sex">
        <el-radio-group v-model="registerForm.Sex">
          <el-radio :label="0">女</el-radio>
          <el-radio :label="1">男</el-radio>
          <el-radio :label="2">保密</el-radio>
          <el-radio :label="2">组合</el-radio>
          <el-radio :label="3">不明</el-radio>
        </el-radio-group>
      </el-form-item>
      <el-form-item label="故乡" prop="Location">
        <el-input v-model="registerForm.Location"></el-input>
      </el-form-item>
      <el-form-item label="出生日期" prop="Birth">
        <el-date-picker type="date" v-model="registerForm.Birth"></el-date-picker>
      </el-form-item>
      <el-form-item label="歌手介绍" prop="Introduction">
        <el-input type="textarea" v-model="registerForm.Introduction"></el-input>
      </el-form-item>
    </el-form>
    <template #footer>
      <span class="dialog-footer">
        <el-button @click="centerDialogVisible = false">取 消</el-button>
        <el-button type="primary" @click="addsinger">确 定</el-button>
      </span>
    </template>
  </el-dialog>

  <!-- 编辑弹出框 -->
  <el-dialog title="编辑" v-model="editVisible">
    <el-form label-width="60px" :model="editForm" :rules="singerRule">
      <el-form-item label="歌手" prop="Name">
        <el-input v-model="editForm.Name"></el-input>
      </el-form-item>
      <el-form-item label="性别" prop="Sex">
        <el-radio-group v-model="editForm.Sex">
          <el-radio :label="0">女</el-radio>
          <el-radio :label="1">男</el-radio>
          <el-radio :label="2">保密</el-radio>
          <el-radio :label="2">组合</el-radio>
          <el-radio :label="3">不明</el-radio>
        </el-radio-group>
      </el-form-item>
      <el-form-item label="出生" prop="Birth">
        <el-date-picker type="date" v-model="editForm.Birth"></el-date-picker>
      </el-form-item>
      <el-form-item label="地区" prop="Location">
        <el-input v-model="editForm.Location"></el-input>
      </el-form-item>
      <el-form-item label="简介" prop="Introduction">
        <el-input type="textarea" v-model="editForm.Introduction"></el-input>
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
import { defineComponent, getCurrentInstance, watch, ref, reactive, computed } from "vue";
import mixin from "@/mixins/mixin";
import YinDelDialog from "@/components/dialog/YinDelDialog.vue";
import { HttpManager } from "@/api/index";
import { RouterName } from "@/enums";
import { getBirth } from "@/utils";

export default defineComponent({
  components: {
    YinDelDialog,
  },
  setup() {
    const { proxy } = getCurrentInstance();
    const { changeSex, routerManager, beforeImgUpload } = mixin();

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
          if (item.name.includes(searchWord.value)) {
            tableData.value.push(item);
          }
        }
      }
    });

    getData();

    async function getData() {
      tableData.value = [];
      tempDate.value = []; 
      const result = await HttpManager.getAllSinger();
      tableData.value = result.Data;
      tempDate.value = result.Data;
      currentPage.value = 1;
    }
    // 获取当前页
    function handleCurrentChange(val) {
      currentPage.value = val;
    }

    /**
     * 路由
     */
    function goSongPage(row) {
      const breadcrumbList = reactive([
        {
          path: RouterName.Singer,
          name: "歌手管理",
        },
        {
          path: "",
          name: "歌曲信息",
        },
      ]);
      proxy.$store.commit("setBreadcrumbList", breadcrumbList);
      routerManager(RouterName.Song, {
        path: RouterName.Song,
        query: { id: row.Id, name: row.Name },
      });
    }

    /**
     * 添加
     */
    const centerDialogVisible = ref(false);
    const registerForm = reactive({
      Name: "",
      Sex: "",
      Birth: new Date(),
      Location: "",
      Introduction: "",
    });
    const singerRule = reactive({
      Name: [{ required: true, trigger: "change" }],
      Sex: [{ required: true, trigger: "change" }],
    });

    async function addsinger() {
      let datetime = getBirth(registerForm.Birth);

      let name = registerForm.Name;
      let sex = registerForm.Sex;
      let birth = datetime;
      let location = registerForm.Location;
      let introduction = registerForm.Introduction;

      const result = (await HttpManager.setSinger({name,sex,birth,location,introduction})) as ResponseBody;
      (proxy as any).$message({
        message: result.Description,
        type: result.Tag,
      });

      if (result.Tag == 1) {
        getData();
        registerForm.Birth = new Date();
        registerForm.Name = "";
        registerForm.Sex = "";
        registerForm.Location = "";
        registerForm.Introduction = "";
      }
      centerDialogVisible.value = false;
    }

    /**
     * 编辑
     */
    const editVisible = ref(false);
    const editForm = reactive({
      Id: "",
      Name: "",
      Sex: "",
      Pic: "",
      Birth: new Date(),
      Location: "",
      Introduction: "",
    });

    function editRow(row) {
      editVisible.value = true;
      editForm.Id = row.Id;
      editForm.Name = row.Name;
      editForm.Sex = row.Sex;
      editForm.Pic = row.Pic;
      editForm.Birth = row.Birth;
      editForm.Location = row.Location;
      editForm.Introduction = row.Introduction;
    }
    async function saveEdit() {
      try {
        let datetime = getBirth(new Date(editForm.Birth));

        let id = editForm.Id;
        let name = editForm.Name;
        let sex = editForm.Sex;
        let birth = datetime;
        let location = editForm.Location;
        let introduction = editForm.Introduction;

        const result = (await HttpManager.updateSingerMsg({id,name,sex,birth,location,introduction})) as ResponseBody;
        (proxy as any).$message({
          message: result.Description,
          type: result.Tag,
        });

        if (result.Tag == 1) getData();
        editVisible.value = false;
      } catch (error) {
        console.error(error);
      }
    }

    function uploadUrl(item,id) { 
      let form = new FormData();
      form.append("id", id); 
      form.append("file", item.file);   
      var param ={
        id:id,
        data:form
      }  
      return HttpManager.postFileUrl(param);
    }


    function handleImgSuccess(response, file:any) {
      // console.log('file=======',file);
      // console.log('result=======',JSON.stringify(response));
      (proxy as any).$message({
        message: response.Data.Description,
        type: response.Data.Tag,
      });
      if (response.Data.Tag == 1) {
        getData();
      }
    }

    /**
     * 删除
     */
    const idx = ref(-1); // 记录当前要删除的行
    const multipleSelection = ref([]); // 记录当前要删除的列表
    const delVisible = ref(false); // 显示删除框

    async function confirm() {
      const result = (await HttpManager.deleteSinger(idx.value)) as ResponseBody; 
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
      singerRule,
      deleteAll,
      handleSelectionChange,
      handleImgSuccess,
      beforeImgUpload,
      saveEdit,
      attachImageUrl: HttpManager.attachImageUrl,
      changeSex,
      getBirth,
      uploadUrl,
      goSongPage,
      editRow,
      handleCurrentChange,
      addsinger,
      confirm,
      deleteRow,
    };
  },
});
</script>

<style scoped>
.singer-img {
  width: 100%;
  height: 80px;
  border-radius: 5px;
  margin-bottom: 5px;
  overflow: hidden;
}
</style>
