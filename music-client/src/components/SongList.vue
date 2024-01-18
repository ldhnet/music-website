<template>
  <div class="content">
    <el-table highlight-current-row :data="dataList" @row-click="handleClick">
      <el-table-column prop="SongName" label="歌曲" />
      <el-table-column prop="SingerName" label="歌手" />
      <el-table-column prop="Introduction" label="专辑" />
      <el-table-column label="编辑" width="80" align="center">
        <template #default="scope">
          <el-dropdown>
            <el-icon @click="handleEdit(scope.row)"><MoreFilled /></el-icon>
            <template #dropdown>
              <el-dropdown-menu>
                <el-dropdown-item
                  :icon="Download"
                  @click="
                    downloadMusic({
                      songUrl: scope.row.Url,
                      songName: scope.row.Name,
                    })
                  ">下载</el-dropdown-item>
                <el-dropdown-item :icon="Delete" v-if="show" @click="deleteCollection({ id: scope.row.Id })">删除</el-dropdown-item>
              </el-dropdown-menu>
            </template>
          </el-dropdown>
        </template>
      </el-table-column>
    </el-table>
  </div>
</template>

<script lang="ts">
import { defineComponent, getCurrentInstance, toRefs, computed, reactive } from "vue";
import { useStore } from "vuex";
import mixin from "@/mixins/mixin";
import { MoreFilled, Delete, Download } from "@element-plus/icons-vue";
import { HttpManager } from "@/api";
import { Icon } from "@/enums";

export default defineComponent({
  components: {
    MoreFilled,
  },
  props: {
    songList: Array, 
    show: {
      default: false
    }
  },
  emits: ["changeData"],
  setup(props) {
    const { getSongTitle, getSingerName, playMusic, checkStatus, downloadMusic } = mixin();
    const { proxy } = getCurrentInstance();
    const store = useStore();

    const { songList } = toRefs(props); 
    const iconList = reactive({
      dislike: Icon.Dislike,
      like: Icon.Like,
    }); 
    const songUrl = computed(() => store.getters.songUrl);
    const singerName = computed(() => store.getters.singerName);
    const songTitle = computed(() => store.getters.songTitle);
    const dataList = computed(() => {
      const list = [];
      songList.value.forEach((item: any, index) => {
        item["SongName"] = getSongTitle(item.name);
        item["SingerName"] = getSingerName(item.name);
        item["Index"] = index;
        list.push(item);
      });
      return list;
    });

    function handleClick(row) {
      playMusic({
        id: row.Id,
        url: row.Url,
        pic: row.Pic,
        index: row.Index,
        name: row.Name,
        lyric: row.Lyric,
        currentSongList: songList.value,
      });
    }

    function handleEdit(row) {
      console.log("row", row);
    }

    const userId = computed(() => store.getters.userId);

    async function deleteCollection({ id }) {
      if (!checkStatus()) return;

      const result = (await HttpManager.deleteCollection(userId.value, id)) as ResponseBody;
      (proxy as any).$message({
        message: result.Description,
        type: result.Tag,
      });

      if (result.Tag == 1)
      {
        proxy.$emit("changeData", result.Data);
      }
    }

    return {
      dataList,
      iconList,
      Delete,
      Download,
      songUrl,
      singerName,
      songTitle,
      handleClick,
      handleEdit,
      downloadMusic,
      deleteCollection,
    };
  },
});
</script>

<style lang="scss" scoped>
@import "@/assets/css/var.scss";
@import "@/assets/css/global.scss";

.content {
  background-color: $color-white;
  border-radius: $border-radius-songlist;
  padding: 10px;
}

.content:deep(.el-table__row.current-row) {
  color: $color-black;
  font-weight: bold;
}

.content:deep(.el-table__row) {
  cursor: pointer;
}

.icon {
  @include icon(1.2em, $color-black);
}
</style>
