import { createApp,DirectiveBinding } from "vue";
import ElementPlus from "element-plus";
import App from "./App.vue";
import router from "./router";
import store from "./store";
import "element-plus/dist/index.css";
import "./assets/css/index.scss";
import "./assets/icons/index.js";
import imageDirective from './directive/previewImageDirective';
import { Store } from "vuex";
declare module "@vue/runtime-core" {
  interface State {
    count: number;
  }

  interface ComponentCustomProperties {
    $store: Store<State>;
  }
}

const app = createApp(App).use(store).use(router).use(ElementPlus);
imageDirective(app);
 
app.directive('color', (el:HTMLElement, binding:DirectiveBinding) => {
  // 这会在 `mounted` 和 `updated` 时都调用
  el.style.color = binding.value //"#f56c6c" 
});

app.mount("#app");