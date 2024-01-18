<template>
  <el-form ref="passwordForm" label-width="70px" :model="form" :rules="rules">
    <el-form-item label="旧密码" prop="OldPassword">
      <el-input type="password" v-model="form.OldPassword" />
    </el-form-item>
    <el-form-item label="新密码" prop="NewPassword">
      <el-input type="password" v-model="form.NewPassword" />
    </el-form-item>
    <el-form-item label="密码确认" prop="ConfirmPassword">
      <el-input type="password" v-model="form.ConfirmPassword" />
    </el-form-item>
    <el-form-item>
      <el-button @click="clearData()">重置</el-button>
      <el-button type="primary" @click="confirm()">确认修改</el-button>
    </el-form-item>
  </el-form>
</template>

<script lang="ts">
import { defineComponent, getCurrentInstance, computed, reactive } from "vue";
import { useStore } from "vuex";
import mixin from "@/mixins/mixin";
import { HttpManager } from "@/api";
import { validatePassword } from "@/enums";

export default defineComponent({
  setup() {
    const store = useStore();
    const { proxy } = getCurrentInstance();
    const { goBack } = mixin();

    const form = reactive({
      OldPassword: "",
      NewPassword: "",
      ConfirmPassword: "",
    });
    const userId = computed(() => store.getters.userId);
    const userName = computed(() => store.getters.username);

    const validateCheck = (rule: any, value: any, callback: any) => {
      if (value === "") {
        callback(new Error("密码不能为空"));
      } else if (value !== form.NewPassword) {
        callback(new Error("请输入正确密码"));
      } else {
        callback();
      }
    };
    const rules = reactive({
      OldPassword: [{ validator: validatePassword, trigger: "blur", min: 3 }],
      NewPassword: [{ validator: validatePassword, trigger: "blur", min: 3 }],
      ConfirmPassword: [{ validator: validateCheck, trigger: "blur", min: 3 }],
    });

    async function clearData() {
      form.OldPassword = "";
      form.NewPassword = "";
      form.ConfirmPassword = "";
    }

    async function confirm() {
      let canRun = true;
      (proxy.$refs["passwordForm"] as any).validate((valid) => {
        if (!valid) return (canRun = false);
      });
      if (!canRun) return;


      const Id = userId.value;
      const UserName = userName.value;
      const OldPassword = form.OldPassword;
      const Password = form.NewPassword;

      const result = (await HttpManager.updateUserPassword({Id,UserName,OldPassword,Password})) as ResponseBody;
      (proxy as any).$message({
        message: result.Description,
        type: result.Tag,
      });
      if (result.Tag == 1) goBack();
    }

    return {
      form,
      clearData,
      confirm,
      rules,
    };
  },
});
</script>

<style></style>
