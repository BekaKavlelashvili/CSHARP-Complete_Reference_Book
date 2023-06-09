﻿using Multithreading_TPL_PLINQ;

class Program
{
    static void Main()
    {
        CreateAndRunTask.CreateAndRunTaskMain();
        DemonstrateTaskID.DemonstrateTaskIDMain();
        UseWait.UseWaitMain();
        UseLambdaExpAsTask.UseLambdaExpAsTaskMain();
        DemonstrateContinuation.DemonstrateContinuationMain();
        ReturnValueFromTask.ReturnValueFromTaskMain();
        UseCancellation.UseCancellationMain();
    }
}