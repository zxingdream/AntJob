﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntJob.Data;

namespace AntJob.Handlers
{
    /// <summary>C#代码处理器，定时执行一段C#代码</summary>
    /// <remarks>
    /// 应用型处理器，可直接使用
    /// </remarks>
    public class CSharpHandler : Handler
    {
        #region 属性
        #endregion

        #region 构造
        /// <summary>实例化</summary>
        public CSharpHandler()
        {
            //Mode = JobModes.CSharp;

            var job = Job;
            job.BatchSize = 8;
        }
        #endregion

        /// <summary>执行</summary>
        /// <param name="ctx"></param>
        /// <returns></returns>
        protected override Int32 Execute(JobContext ctx)
        {
            var code = ctx.Data as String;
            if (code.IsNullOrWhiteSpace()) return -1;

            return 0;
        }
    }
}