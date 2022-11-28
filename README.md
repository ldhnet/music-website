# music-website

#### 介绍
Vue + NET6+ EFCore音乐网站  本开源项目是模仿 Yinhongwei 大佬的 Vue + SpringBoot + MyBatis 音乐网站 项目
<br/>

GitHub地址  [music-website](https://github.com/ldhnet/music-website)

<br/>

尊重源作者  [Yin-hongwei](https://gitee.com/Yin-hongwei/)

#### 预览入口

###### music-webapi 
[music-webapi预览入口](http://180.76.235.148:9010/swg-login.html)

###### music-manage
[music-manage预览入口](http://180.76.235.148:8086/)

###### music-client
[music-client预览入口](http://180.76.235.148:8087/)
 
<br/>

## 项目预览

> 前台截图预览

![](https://github.com/ldhnet/music-website/blob/main/preview/1.jpg?raw=true)<br/>

![](https://github.com/ldhnet/music-website/blob/main/preview/2.jpg?raw=true)<br/>

![](https://github.com/ldhnet/music-website/blob/main/preview/3.jpg?raw=true)<br/>

![](https://github.com/ldhnet/music-website/blob/main/preview/4.jpg?raw=true)<br/>

![](https://github.com/ldhnet/music-website/blob/main/preview/5.jpg?raw=true)<br/>

![](https://github.com/ldhnet/music-website/blob/main/preview/6.jpg?raw=true)<br/>

![](https://github.com/ldhnet/music-website/blob/main/preview/7.jpg?raw=true)<br/>

![](https://github.com/ldhnet/music-website/blob/main/preview/8.jpg?raw=true)<br/>

![](https://github.com/ldhnet/music-website/blob/main/preview/9.jpg?raw=true)

<br/>

![](https://github.com/ldhnet/music-website/blob/main/preview/10.jpg?raw=true)<br/>

![](https://github.com/ldhnet/music-website/blob/main/preview/11.jpg?raw=true)<br/>

> 后台截图预览

![](https://github.com/ldhnet/music-website/blob/main/preview/12.jpg?raw=true)<br/>

![](https://github.com/ldhnet/music-website/blob/main/preview/13.jpg?raw=true)<br/>

![](https://github.com/ldhnet/music-website/blob/main/preview/14.jpg?raw=true)<br/>

![](https://github.com/ldhnet/music-website/blob/main/preview/15.jpg?raw=true)<br/>

![](https://github.com/ldhnet/music-website/blob/main/preview/16.jpg?raw=true)<br/>

![](https://github.com/ldhnet/music-website/blob/main/preview/17.jpg?raw=true)<br/>

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

**NET6 + EFCore + Mysql**

### 前端

**Vue3.0 + TypeScript + Vue-Router + Vuex + Axios + ElementPlus + Echarts**

<br/>

## 开发环境

JDK： dotnet-sdk-6.0.101-win-x64.exe

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

去【链接: https://pan.baidu.com/s/1uKQ6hQNuZ39y6HiJ-OF7SA  提取码: duzz 】下载网站依赖的歌曲及图片，将 data 夹里的文件放到 MusicApi/wwwroot 文件夹下。
 
### 3、修改配置文件

1）创建数据库
将 `music-website/sql` 文件夹中的 `tp_music.sql` 文件导入数据库。
 
### 4、启动项目

- **启动管理端**：进入 music-server 文件夹，VS 2022 IDE 打开

 
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
