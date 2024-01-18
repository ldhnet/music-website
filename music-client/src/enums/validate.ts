// 登录规则
const validateName = (rule, value, callback) => {
  if (!value) {
    return callback(new Error("用户名不能为空"));
  } else {
    callback();
  }
};

export const validatePassword = (rule, value, callback) => {
  if (value === "") {
    callback(new Error("密码不能为空"));
  } else {
    callback();
  }
};

export const SignInRules = {
  UserName: [{ validator: validateName, trigger: "blur", min: 3 }],
  Password: [{ validator: validatePassword, trigger: "blur", min: 3 }],
};

// 注册规则
export const SignUpRules = {
  UserName: [{ required: true, trigger: "blur", min: 3, message: "用户名不能为空" }],
  Password: [{ required: true, trigger: "blur", min: 3, message: "密码不能为空"}],
  Sex: [{ required: true, message: "请选择性别", trigger: "change" }],
  Phone_Num: [{ essage: "请选择日期", trigger: "blur" }],
  Email: [
    { message: "请输入邮箱地址", trigger: "blur" },
    {
      type: "email",
      message: "请输入正确的邮箱地址",
      trigger: ["blur", "change"],
    },
  ],
  Birth: [{ required: true, type: "date", message: "请选择日期", trigger: "change" }],
  Introduction: [{ message: "请输入介绍", trigger: "blur" }],
  Location: [{ message: "请输入地区", trigger: "change" }],
};
