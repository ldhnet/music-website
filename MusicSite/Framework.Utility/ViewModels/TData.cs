using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utility.ViewModels
{

    /// <summary>
    /// 数据传输对象
    /// </summary>
    public class TData : TData<object>
    {
        /// <summary>
        /// 初始化一个<see cref="TData"/>类型的新实例
        /// </summary>
        public TData(ResultTag tag) : base(tag)
        { }

        /// <summary>
        /// 初始化一个<see cref="TData"/>类型的新实例
        /// </summary>
        public TData(ResultTag tag, string message) : base(tag, message)
        { }

        /// <summary>
        /// 初始化一个<see cref="TData"/>类型的新实例
        /// </summary>
        public TData(ResultTag tag, string message, object data) : base(tag, message, data)
        { }

    }

    public class TData<T>
    {
        /// <summary>
        /// 初始化一个<see cref="TData{T}"/>类型的新实例
        /// </summary>
        public TData() : this(ResultTag.success, null, default(T))
        { }

        /// <summary>
        /// 初始化一个<see cref="TData{T}"/>类型的新实例
        /// </summary>
        public TData(ResultTag tag) : this(tag, null, default(T))
        { }

        /// <summary>
        /// 初始化一个<see cref="TData{T}"/>类型的新实例
        /// </summary>
        public TData(ResultTag tag, string message) : this(tag, message, default(T))
        { }

        /// <summary>
        /// 初始化一个<see cref="TData{T}"/>类型的新实例
        /// </summary>
        public TData(ResultTag tag, string message, T data)
        {
            this.tag = tag;
            this.message = string.IsNullOrWhiteSpace(message)? (tag == ResultTag.success? "操作成功" : "操作失败") : message;
            this.data = data;
        }
        /// <summary>
        /// 操作结果，Tag为1代表成功，0代表失败，其他的验证返回结果，可根据需要设置
        /// </summary>
        public ResultTag tag { get; set; }
        /// <summary>
        /// 提示信息或异常信息
        /// </summary>
        public string message { get; set; }

        public string type
        {
            get
            {
                return tag == ResultTag.success ? "success" : "error";
            }
        }

        public bool success
        {
            get
            {
                return tag == ResultTag.success ? true : false;
            }
        }
        /// <summary>
        /// 列表的记录数
        /// </summary>
        public int total { get; set; }

        /// <summary>
        /// 数据
        /// </summary>
        public T data { get; set; }
    }

    public enum ResultTag
    {
        fail,
        success,
    } 
}
