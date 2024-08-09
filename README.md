# music-website
#### 介绍
本项目已升级至NET8
Vue3.2 + NET8 + EFCore 音乐播放网站 
<br/>
GitHub地址  [music-website](https://github.com/ldhnet/music-website)
<br/>
- QQ技术交流群（972107977）
- 技术支持邮箱：574427343@qq.com
- 同时欢迎Issues反馈
<br/>

本开源项目是参照 Yinhongwei 大佬的 Vue + SpringBoot + MyBatis 音乐网站项目<br/>
尊重源作者  [Yin-hongwei](https://gitee.com/Yin-hongwei/)

#### 预览入[由于购买的私有云服务器到期未续费，预览入口暂时关闭，生活不易，谢谢体谅]

###### music-webapi 
[music-webapi预览入口](http://180.76.235.148:9010/swg-login.html)
###### music-manage
[music-manage预览入口](http://180.76.235.148:8086/)
###### music-client
[music-client预览入口](http://180.76.235.148:8087/) 
<br/>

## 项目预览
> 前台截图预览
![](https://gitee.com/ldhnet/music-website/raw/master/preview-img/1.jpg)<br/>
![](https://gitee.com/ldhnet/music-website/raw/master/preview-img/2.jpg)<br/>
![](https://gitee.com/ldhnet/music-website/raw/master/preview-img/3.jpg)<br/>
![](https://gitee.com/ldhnet/music-website/raw/master/preview-img/4.jpg)<br/>
![](https://gitee.com/ldhnet/music-website/raw/master/preview-img/5.jpg)<br/>
![](https://gitee.com/ldhnet/music-website/raw/master/preview-img/6.jpg)<br/>
![](https://gitee.com/ldhnet/music-website/raw/master/preview-img/7.jpg)<br/>
![](https://gitee.com/ldhnet/music-website/raw/master/preview-img/8.jpg)<br/>
![](https://gitee.com/ldhnet/music-website/raw/master/preview-img/9.jpg)
<br/>

![](https://gitee.com/ldhnet/music-website/raw/master/preview-img/10.jpg)<br/>
![](https://gitee.com/ldhnet/music-website/raw/master/preview-img/11.jpg)<br/>
> 后台截图预览
![](https://gitee.com/ldhnet/music-website/raw/master/preview-img/12.jpg)<br/>
![](https://gitee.com/ldhnet/music-website/raw/master/preview-img/13.jpg)<br/>
![](https://gitee.com/ldhnet/music-website/raw/master/preview-img/14.jpg)<br/>
![](https://gitee.com/ldhnet/music-website/raw/master/preview-img/15.jpg)<br/>
![](https://gitee.com/ldhnet/music-website/raw/master/preview-img/16.jpg)<br/>
![](https://gitee.com/ldhnet/music-website/raw/master/preview-img/17.jpg)<br/>
## 项目功能
- 音乐播放
- 用户登录注册
- 用户信息编辑、头像修改
- 歌曲、歌单搜索
- 歌单打分
- 歌单、歌曲评论
- 歌单列表、歌手列表分页显示
- 歌词同步显示
- 音乐收藏、下载、拖动控制、音量控制
- 后台对用户、歌曲、歌手、歌单信息的管理
<br/>

## 技术栈

### 后端
**NET8 + EFCore + Sqlite/Mysql**/Sqlserver

### 前端
**Vue3.2 + TypeScript + Vue-Router + Vuex + Axios + ElementPlus + Echarts**
<br/>

## 开发环境
JDK： dotnet-sdk-8.0.0-win-x64.exe
mysql：mysql-8.0.22 （或者更高版本）  
node：14.17.3
IDE：VS 2022、VSCode
<br/>

## 下载运行

### 1、下载项目到本地

```bash
git clone https://gitee.com/ldhnet/music-website.git 
```

### 2、下载数据库中记录的资源

去【链接: https://pan.baidu.com/s/1ChYYzZFDLGNP8nCT0Hjx7g  提取码: duzz 】下载网站依赖的歌曲及图片，将 data 夹里的文件放到 MusicWeb/wwwroot 文件夹下。
 
### 3、修改配置文件

1）创建数据库

将 `music-website/sql` 文件夹中的
   `music_sqlite.sql`对应 sqlite 数据库 。
   `music_mysql.sql`对应 mysql 数据库 。
   `music_sqlserver.sql`对应 sqlserver 数据库 。
 
### 4、启动项目

- **启动管理端**：进入 MusicWeb 文件夹，VS 2022 IDE 打开（由于升级到了.NET8 需要VS2022 v17.8.0及以上版本） 
- **启动客户端**：进入 music-client 目录，运行下面命令

```js
npm install // 安装依赖
npm run dev // 启动前台项目
```
- **启动管理端**：进入 music-manage 目录，运行下面命令
```js
npm install // 安装依赖

npm run serve // 启动后台管理项目
```
<br/>
## 赞助

如果此项目对你确实有帮助，欢迎给我打赏一杯咖啡～😄

<img src="https://gitee.com/ldhnet/vue3-ts-vant-h5/raw/master/src/assets/img/wxpay.png" height="300px"/>
<br/>
## License
Copyright (c) 2022 Music
