using Framework.Models.Entities;
using Framework.Models.Request;
using Framework.Repository;
using Framework.Utility.Helper;
using Framework.Utility.ViewModels;
using Microsoft.EntityFrameworkCore; 
using Framework.Admin.Contracts; 

namespace Framework.Admin.Service
{
    public class CommentService : ICommentContract
    {
        private ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public TData AddComment(CommentRequest dto)
        {
            var entity = dto.MapTo<Biz_Comment>();
            var result = _commentRepository.Insert(entity);
            return result > 0 ? new TData(ResultTag.success,OperateMsg.OptSuccess) : new TData(ResultTag.fail, OperateMsg.OptError);
        }

        public async Task<TData> CommentOfSongId(int songId)
        {
            var list = await _commentRepository.QueryAsNoTracking(c => c.song_id == songId).ToListAsync(); 
            return new TData(ResultTag.success, OperateMsg.OptSuccess, list); 
        }

        public async Task<TData> CommentOfSongListId(int songListId)
        {
            var list = await _commentRepository.QueryAsNoTracking(c => c.song_list_id == songListId).ToListAsync();
            return new TData(ResultTag.success, OperateMsg.OptSuccess, list);
        }

        public TData DeleteComment(int id)
        {
            var result = _commentRepository.Delete(d => d.id == id);
            return result > 0 ? new TData(ResultTag.success, OperateMsg.OptSuccess) : new TData(ResultTag.fail, OperateMsg.OptError);
        }

        public TData UpdateCommentMsg(CommentRequest dto)
        {
            var entity = dto.MapTo<Biz_Comment>();
            return _commentRepository.Update(entity) > 0 ? new TData(ResultTag.success) : new TData(ResultTag.fail);
        }
    }
}
