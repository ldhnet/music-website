﻿using Framework.Models.Entities;
using Framework.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Repository
{
    public interface IConsumerRepository : IRepository<Biz_Consumer, int>
    {
    }
}