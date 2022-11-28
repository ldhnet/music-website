using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utility.ViewModels
{
    public struct ExportReportFileName
    { 
        public const string LeaveTime = "休假报表报表{0}.xls";
        public const string YearLeave = "年假报表{0}.xls"; 
    }
    public  class OperateMsg
    {
        public const  string OptSuccess = "操作成功";
        public const string OptError = "操作失败";
    }

    public class CacheKay
    {
        public const string CurrentUser = "CurrentUser";
        public const string SessionUser = "SessionUser";
    }

    public struct WebFilePath
    {
        public const string AvatorImages = "/img/avatorImages";
        public const string SingerPic = "/img/singerPic";
        public const string SongPic = "/img/songPic";
        public const string SongListPic = "/img/songListPic";
        public const string SongVideo = "/song";
    }
}
