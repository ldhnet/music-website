using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Framework.Utility.Extensions
{ 
    public static class TimeoutExtensions
    {
        //public static async Task<T> Timeout<T>(this Task<T> task, int milliseconds)
        //{
        //    var now = DateTime.Now.AddMilliseconds(milliseconds);
        //    while (DateTime.Now < now)
        //    {
        //        if (task.IsCompleted)
        //        {
        //            return await task;
        //        }

        //        await Task.Delay(100);
        //    }

        //    return default(T);
        //}

        public static async Task<T> Timeout<T>(this Task<T> task, int milliseconds)
        {
            var timeoutTask = Task.Delay(milliseconds);
            var allTasks = new List<Task> { task, timeoutTask };
            Task finishedTask = await Task.WhenAny(allTasks);
            if (finishedTask == timeoutTask)
            {
                return default(T);
            }

            return await task;
        }
    } 
}