import {deletes, get, getBaseURL, post, postFile} from './request'

const HttpManager = {
    // 获取图片信息
    attachImageUrl: (url) => `${getBaseURL()}/${url}`,


    postFileUrl : (param) => postFile(`/singer/avatar/update?id=${param.id}`,param),
    // =======================> 管理员 API 完成
    // 是否登录成功
    getLoginStatus: ({username, password}) => post(`api/adminLogin`, {username, password}),

    // =======================> 用户 API 完成
    // 返回所有用户
    getAllUser: () => get(`user`),
    // 返回指定ID的用户
    getUserOfId: (id) => get(`user/detail?id=${id}`),
    // 删除用户
    deleteUser: (id) => deletes(`user/delete?id=${id}`),

    // =======================> 收藏列表 API 完成
    // 返回的指定用户ID收藏列表
    getCollectionOfUser: (userId) => get(`collection/detail?userId=${userId}`),
    // 删除收藏的歌曲
    deleteCollection: (userId, songId) => deletes(`collection/delete?userId=${userId}&songId=${songId}`),

    // =======================> 评论列表 API 完成
    // 获得指定歌曲ID的评论列表
    getCommentOfSongId: (songId) => get(`comment/song/detail?songId=${songId}`),
    // 获得指定歌单ID的评论列表
    getCommentOfSongListId: (songListId) => get(`comment/songList/detail?songListId=${songListId}`),
    // 删除评论
    deleteComment: (id) => get(`comment/delete?id=${id}`),

    // =======================> 歌手 API 完成
    // 返回所有歌手
    getAllSinger: () => get(`singer`), 
    // 添加歌手
    setSinger: ({name, sex, birth, location, introduction}) => post(`singer/add`, {
        name,
        sex,
        birth,
        location,
        introduction
    }),
    // 更新歌手信息
    updateSingerMsg: ({id, name, sex, birth, location, introduction}) => post(`singer/update`, {
        id,
        name,
        sex,
        birth,
        location,
        introduction
    }),
    // 删除歌手
    deleteSinger: (id) => deletes(`singer/delete?id=${id}`),

    // =======================> 歌曲 API  完成
    // 返回所有歌曲
    getAllSong: () => get(`song`),
    // 返回指定歌手ID的歌曲
    getSongOfSingerId: (id) => get(`song/singer/detail?singerId=${id}`),
    // 返回的指定用户ID收藏列表
    getSongOfId: (id) => get(`song/detail?id=${id}`),
    // 返回指定歌手名的歌曲
    getSongOfSingerName: (id) => get(`song/singerName/detail?name=${id}`),
    // 更新歌曲信息
    updateSongMsg: ({id, singer_id, name, introduction, lyric}) => post(`song/update`, {
        id: id,
        singer_id : singer_id,
        name:name,
        introduction: introduction,
        lyric: lyric
    }),
    
    //updateSongUrl: (id) => `${getBaseURL()}/song/url/update?id=${id}`,
    //updateSongImg: (id) => `${getBaseURL()}/song/img/update?id=${id}`,

    updateSongUrl : (param) => postFile(`/song/url/update?id=${param.id}`,param),
    updateSongImg : (param) => postFile(`/song/img/update?id=${param.id}`,param),

    // 删除歌曲
    deleteSong: (id) => deletes(`song/delete?id=${id}`),

    // =======================> 歌单 API 完成
    // 添加歌单t
    setSongList: ({title, introduction, style}) => post(`songList/add`, {title, introduction, style}),
    // 获取全部歌单
    getSongList: () => get(`songList`),
    // 更新歌单信息
    updateSongListMsg: ({id, title, introduction, style}) => post(`songList/update`, {id, title, introduction, style}),
    // 删除歌单
    deleteSongList: (id) => deletes(`songList/delete?id=${id}`),

    // =======================> 歌单歌曲 API 完成
    // 给歌单添加歌曲
    setListSong: ({songId,songListId}) => post(`listSong/add`, {songId,songListId}),
    // 返回歌单里指定歌单ID的歌曲
    getListSongOfSongId: (songListId) => get(`listSong/detail?songListId=${songListId}`),
    // 删除歌单里的歌曲
    deleteListSong: (songId) => get(`listSong/delete?songId=${songId}`),

    //更新歌单里的图片
    updateSongListImg : (param) => postFile(`/songList/img/update?id=${param.id}`,param),
}

export {HttpManager}
