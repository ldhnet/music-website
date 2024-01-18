<template>
  <el-form ref="updateForm" label-width="70px" :model="registerForm" :rules="SignUpRules">
    <el-form-item prop="UserName" label="用户名">
      <el-input v-model="registerForm.UserName" placeholder="用户名"></el-input>
    </el-form-item>
    <el-form-item label="性别">
      <el-radio-group v-model="registerForm.Sex">
        <el-radio :label="0">女</el-radio>
        <el-radio :label="1">男</el-radio>
        <el-radio :label="2">保密</el-radio>
      </el-radio-group>
    </el-form-item>
    <el-form-item prop="Birth" label="生日">
      <el-date-picker type="date" placeholder="选择日期" v-model="registerForm.Birth" style="width: 100%"></el-date-picker>
    </el-form-item>
    <el-form-item prop="Introduction" label="签名">
      <el-input type="textarea" placeholder="签名" v-model="registerForm.Introduction"></el-input>
    </el-form-item>
    <el-form-item prop="Location" label="地区">
      <el-select v-model="registerForm.Location" placeholder="地区" style="width: 100%">
        <el-option v-for="item in AREA" :key="item.value" :label="item.label" :value="item.value"> </el-option>
      </el-select>
    </el-form-item>
    <el-form-item prop="Phone_Num" label="手机">
      <el-input placeholder="手机" v-model="registerForm.Phone_Num"></el-input>
    </el-form-item>
    <el-form-item prop="Email" label="邮箱">
      <el-input v-model="registerForm.Email" placeholder="邮箱"></el-input>
    </el-form-item>
    <el-form-item>
      <el-button @click="goBack(-1)">取消</el-button>
      <el-button type="primary" @click="saveMsg()">保存</el-button>
    </el-form-item>
  </el-form>
</template>

<script lang="ts">
import { defineComponent, computed, onMounted, getCurrentInstance, reactive } from "vue";
import { useStore } from "vuex";
import mixin from "@/mixins/mixin";
import { AREA, SignUpRules } from "@/enums";
import { HttpManager } from "@/api";
import { getBirth } from "@/utils";

export default defineComponent({
  setup() {
    const { proxy } = getCurrentInstance();
    const store = useStore();
    const { goBack } = mixin();

    // 注册
    const registerForm = reactive({
      UserName: "",
      Sex: "",
      Phone_Num: "",
      Email: "",
      Birth: new Date(),
      Introduction: "",
      Location: "",
      Pic: "",
    });
    const userId = computed(() => store.getters.userId);

    async function getUserInfo(id) {
      const result = (await HttpManager.getUserOfId(id)) as ResponseBody;
      registerForm.UserName = result.Data[0].UserName;
      registerForm.Sex = result.Data[0].Sex;
      registerForm.Phone_Num = result.Data[0].Phone_Num;
      registerForm.Email = result.Data[0].Email;
      registerForm.Birth = result.Data[0].Birth;
      registerForm.Introduction = result.Data[0].Introduction;
      registerForm.Location = result.Data[0].Location;
      registerForm.Pic = result.Data[0].Avator;
    }

    async function saveMsg() {
      let canRun = true;
      (proxy.$refs["updateForm"] as any).validate((valid) => {
        if (!valid) return (canRun = false);
      });
      if (!canRun) return;


      const Id = userId.value;
      const UserName = registerForm.UserName;
      const Sex = registerForm.Sex;
      const Phone_Num = registerForm.Phone_Num;
      const Email = registerForm.Email;
      const Birth = registerForm.Birth;
      const Introduction = registerForm.Introduction;
      const Location = registerForm.Location;
      const result = (await HttpManager.updateUserMsg({Id,UserName,Sex,Phone_Num,Email,Birth,Introduction,Location})) as ResponseBody;
      (proxy as any).$message({
        message: result.Description,
        type: result.Tag,
      });
      if (result.Tag == 1) {
        proxy.$store.commit("setUsername", registerForm.UserName);
        goBack(-1);
      }
    }

    onMounted(() => {
      getUserInfo(userId.value);
    });

    return {
      AREA,
      registerForm,
      SignUpRules,
      saveMsg,
      goBack,
    };
  },
});
</script>

<style lang="scss" scoped>
.btn ::v-deep .el-form-item__content {
  display: flex;
  justify-content: center;
}
</style>
