﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Orleans.Activities.Helpers;

namespace Orleans.Activities.Test.Activities
{
    public interface IWorkflowCallbackInterfaceValueType
    {
        Task<Func<Task<int>>> OnOperationWithParamsAsync(int receiveResult);
        Task<Func<Task>> OnOperationWithoutParamsAsync();
        Task<Func<Task>> OnOperationThrowsBeginAsync();
        Task<Func<Task>> OnOperationThrowsEndAsync();
    }
}
