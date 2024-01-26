import { DirectiveBinding, h, render } from 'vue';
import { ElImageViewer } from 'element-plus';

const previewBox = document.createElement('div'); // 创建节点
previewBox.classList.add('preview-box'); // 给 div 增加类名
let vnode; // 存放 vnode 的变量

//调用   <div v-previewimage="attachImageUrl(url)" ></div> 
//<div v-previewimage="attachImageUrl('img/avatorImages/user.jpg')" ></div> 
export default function (app) {
    app.directive('previewimage', {
        mounted(el: HTMLElement, binding: DirectiveBinding) {
            el.addEventListener('click', () => {
                el.style.cursor = 'pointer';
            });
            vnode = h(ElImageViewer, {
                urlList: [binding.value], // 图片地址
                hideOnClickModal: true, // 允许点击遮罩层关闭
                onClose: () => {
                    el.removeEventListener('click', () => { console.log('close') }); // 移除
                    document.body.removeChild(previewBox);
                },
            });
            render(vnode, previewBox); // 将 vnode 渲染成 html
            document.body.appendChild(previewBox); // 将 html 插入到 body 标签里面
        },
    });
}