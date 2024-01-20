using HSharp.Contracts.MusicContracts;
using HSharp.Data.Repository;
using HSharp.Entity.Music;
using HSharp.Models.Request;
using HSharp.Util;
using HSharp.Util.Model;

namespace HSharp.Services.MusicServices
{
    public class UserSupportService : RepositoryFactory, IUserSupportContract
    {

        public async Task<TData> DeleteCommentSupport(UserSupportRequest dto)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 0;
            var model = await _Repository.FindEntity<Biz_CommentUp>(c => c.UserId == dto.UserId && c.CommentId == dto.CommentId);
            if (model != null)
            {
                obj.Data = true;
                obj.Tag = await _Repository.Delete(model);
            }
            obj.Description = obj.Tag > 0 ? "取消点赞" : "取消点赞失败"; 
            return obj;
        }

        public async Task<TData> InsertCommentSupport(UserSupportRequest dto)
        {
            TData<bool> obj = new TData<bool>();
            var entity = new Biz_CommentUp()
            {
                UserId = dto.UserId,
                CommentId = dto.CommentId,
            };
            obj.Tag = 1;
           var model = await _Repository.FindEntity<Biz_CommentUp>(c => c.UserId == dto.UserId && c.CommentId == dto.CommentId);
            if (model == null)
            { 
                entity.Create_Time = DateTime.Now;
                obj.Tag = await _Repository.Insert(entity);
                obj.Data = false;
            }
            obj.Description = obj.Tag > 0 ? "点赞成功" : "点赞失败";
            return obj;
        }

        public async Task<TData> IsUserSupportComment(UserSupportRequest dto)
        {
            TData<bool> obj = new TData<bool>();
            obj.Tag = 1; 
            var model = await _Repository.FindEntity<Biz_CommentUp>(c => c.UserId == dto.UserId && c.CommentId == dto.CommentId);
            if (model != null)
            {
                obj.Data = true;          
            }
            else
            { 
                obj.Data = false; 
            }
            obj.Description = "操作成功";
            return obj;
        }
    }
}
