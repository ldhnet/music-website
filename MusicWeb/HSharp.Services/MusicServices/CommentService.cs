﻿using HSharp.Contracts.MusicContracts;
using HSharp.Data.Repository;
using HSharp.Entity.Music;
using HSharp.Models.Request;
using HSharp.Util;
using HSharp.Util.Model;
using Microsoft.EntityFrameworkCore;

namespace HSharp.Services.MusicServices
{
    public class CommentService : RepositoryFactory, ICommentContract
    {

        public async Task<TData> AddComment(CommentRequest dto)
        {
            TData obj = new TData();
            var entity = dto.MapTo<Biz_Comment>();
            obj.Tag = await _Repository.Insert(entity);
            return obj;
        }

        public async Task<TData> CommentOfSongId(int songId)
        {
            TData<List<Biz_Comment>> obj = new TData<List<Biz_Comment>>();
            obj.Tag = 1;
            var list = await _Repository.FindList<Biz_Comment>(c => c.Song_Id == songId);
            obj.Data = list.ToList();
            return obj;
        }

        public async Task<TData> CommentOfSongListId(int songListId)
        {
            TData<List<Biz_Comment>> obj = new TData<List<Biz_Comment>>();
            obj.Tag = 1;
            var list = await _Repository.FindList<Biz_Comment>(c => c.Song_List_Id == songListId);
            obj.Data = list.ToList();
            return obj;
        }

        public async Task<TData> DeleteComment(int id)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var result = await _Repository.Delete<Biz_Comment>(d => d.Id == id);
            obj.Data = result > 0;
            return obj;
        }

        public async Task<TData> UpdateCommentMsg(CommentRequest dto)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1;
            var entity = dto.MapTo<Biz_Comment>();
            var result = await _Repository.Update(entity);
            obj.Data = result > 0;
            return obj;
        }
    }
}