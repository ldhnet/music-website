using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models
{
    public enum EmployeeStatus
    {
        [Description("解除")]
        RelieveStatus = -3,

        [Description("撤销")]
        RevokeStatus = -2,

        [Description("待生效")]
        WaitStatus = -1,

        [Description("待分配")]
        NotStatus = 0,

        [Description("待确认")]
        PendingStatus = 1,

        [Description("已办理")]
        StatusDone = 2,

        [Description("正常")]
        Normal = 3
    }

    [Flags]
    public enum Roles
    {
        Admin = 1,
        Member = 2
    }
}
