<template>
  <yin-login-logo></yin-login-logo>
  <div class="sign">
    <div class="sign-head">
      <span>用户注册</span>
    </div>
    <el-form ref="signUpForm" label-width="70px" status-icon :model="registerForm" :rules="SignUpRules">
      <el-form-item prop="UserName" label="用户名">
        <el-input v-model="registerForm.UserName" placeholder="用户名"></el-input>
      </el-form-item>
      <el-form-item prop="Password" label="密码">
        <el-input type="Password" placeholder="密码" v-model="registerForm.Password"></el-input>
      </el-form-item>
      <el-form-item prop="Sex" label="性别">
        <el-radio-group v-model="registerForm.Sex">
          <el-radio :label="0">女</el-radio>
          <el-radio :label="1">男</el-radio>
          <el-radio :label="2">保密</el-radio>
        </el-radio-group>
      </el-form-item>
      <el-form-item prop="Phone_Num" label="手机">
        <el-input placeholder="手机" v-model="registerForm.Phone_Num"></el-input>
      </el-form-item>
      <el-form-item prop="Email" label="邮箱">
        <el-input v-model="registerForm.Email" placeholder="邮箱"></el-input>
      </el-form-item>
      <el-form-item prop="Birth" label="生日">
        <el-date-picker type="date" placeholder="选择日期" v-model="registerForm.Birth" style="width: 100%"></el-date-picker>
      </el-form-item>
      <el-form-item prop="Introduction" label="签名">
        <el-input type="textarea" placeholder="签名" v-model="registerForm.Introduction"></el-input>
      </el-form-item>
      <el-form-item prop="Location" label="地区">
        <el-select v-model="registerForm.Location" placeholder="地区" style="width: 100%">
          <el-option v-for="item in AREA" :key="item.value" :label="item.label" :value="item.value"></el-option>
        </el-select>
      </el-form-item>
      <el-form-item class="sign-btn">
        <el-button @click="goSignIn()">登录</el-button>
        <el-button type="primary" @click="handleSignUp(formRef)">确定</el-button>
      </el-form-item>
    </el-form>
  </div>
</template>

<script lang="ts">
import { defineComponent, reactive, getCurrentInstance } from "vue";
import mixin from "@/mixins/mixin";
import YinLoginLogo from "@/components/layouts/YinLoginLogo.vue";
import { HttpManager } from "@/api";
import { getBirth } from "@/utils";
import { AREA, RouterName, NavName, SignUpRules } from "@/enums";

export default defineComponent({
  components: {
    YinLoginLogo,
  },
  setup() {
    const { proxy } = getCurrentInstance();
    const { routerManager, changeIndex } = mixin(); 

    const registerForm = reactive({
      UserName: "",
      Password: "",
      Sex: "",
      Phone_Num: "",
      Email: "",
      Birth: new Date(),
      Introduction: "",
      Location: "",
    });
    function goSignIn(){
      changeIndex(NavName.SignIn); 
      routerManager(RouterName.SignIn, { path: RouterName.SignIn });
    }
    async function handleSignUp() {
      let canRun = true;
      (proxy.$refs["signUpForm"] as any).validate((valid) => {
        if (!valid) return (canRun = false);
      });
      if (!canRun) return;


      try {
        const UserName = registerForm.UserName;
        const Password = registerForm.Password;
        const Sex = registerForm.Sex;
        const Phone_Num = registerForm.Phone_Num;
        const Email = registerForm.Email;
        const Birth = registerForm.Birth;
        const Introduction = registerForm.Introduction;
        const Location = registerForm.Location;
        const result = (await HttpManager.SignUp({UserName,Password,Sex,Phone_Num,Email,Birth,Introduction,Location})) as ResponseBody;
        (proxy as any).$message({
          message: result.Description,
          type: result.Tag,
        });

        if (result.Tag == 1) {
          changeIndex(NavName.SignIn);
          routerManager(RouterName.SignIn, { path: RouterName.SignIn });
        }
      } catch (error) {
        console.error(error);
      }
    }

    return {
      SignUpRules,
      AREA,
      registerForm,
      handleSignUp, 
      goSignIn,
    };
  },
});
</script>

<style lang="scss" scoped>
@import "@/assets/css/sign.scss";
</style>
