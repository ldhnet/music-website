using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Threading.Tasks;
using HSharp.Util;
using HSharp.IdGenerator;
using MusicApi.Core;
using System.ComponentModel.DataAnnotations;

namespace HSharp.Entity.Music
{
    /// <summary>
    /// 数据库实体的基类，所有的数据库实体属性类型都是可空值类型，为了在做条件查询的时候进行判断
    /// 虽然是可空值类型，null的属性值，在底层会根据属性类型赋值默认值，字符串是string.empty，数值是0，日期是1970-01-01
    /// </summary>
    public class BaseMusicEntity
    {
        /// <summary>
        /// 所有表的主键
        /// long返回到前端js的时候，会丢失精度，所以转成字符串
        /// </summary>
        [JsonConverter(typeof(StringJsonConverter))]
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// WebApi没有Cookie和Session，所以需要传入Token来标识用户身份
        /// </summary>
        [NotMapped]
        public string Token { get; set; }
    }

    public class BaseMusicCreateEntity : BaseMusicEntity
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonConverter(typeof(DateTimeJsonConverter))]
        [Description("创建时间")]
        public DateTime? Create_Time { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        public string? Create_By { get; set; }

        public  async Task Create()
        {
            if (Create_Time == null)
            {
                Create_Time = DateTime.Now;
            }

            if (Create_By == null)
            {
                OperatorInfo user = await Operator.Instance.Current(Token);
                if (user != null)
                {
                    Create_By = user.UserName;
                }
                else
                {
                    if (Create_By == null)
                    {
                        Create_By = string.Empty;
                    }
                }
            }
        }
    }

    public class BaseMusicModifyEntity : BaseMusicCreateEntity
    {
        ///// <summary>
        ///// 数据更新版本，控制并发
        ///// </summary>
        //public int? BaseVersion { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonConverter(typeof(DateTimeJsonConverter))]
        [Description("修改时间")]
        public DateTime? Update_Time { get; set; }

        /// <summary>
        /// 修改人ID
        /// </summary>
        public string? Update_By { get; set; }

        public async Task Modify()
        {
            //BaseVersion = 0;
            Update_Time = DateTime.Now;

            if (Update_By == null)
            {
                OperatorInfo user = await Operator.Instance.Current();
                if (user != null)
                {
                    Update_By = user.UserName;
                }
                else
                {
                    if (Update_By == null)
                    {
                        Update_By = string.Empty;
                    }
                }
            }
        }
    }

    public class BaseMusicExtensionEntity : BaseMusicModifyEntity
    {
        public new async Task Create()
        {
            await base.Create();

            await base.Modify();
        }

        public new async Task Modify()
        {
            await base.Modify();
        }
    }

    public class BaseMusicField
    {
        public static string[] BaseFieldList = new string[]
        {
            "Id",
            "Create_Time",
            "Update_Time",
            "Create_By",
            "Update_By",
            "BaseVersion"
        };
    }
}
