using Multithreading_TPL_PLINQ;

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
        Use_Parallel_Invoke.Use_Parallel_InvokeMain();
        UseParallelFor.UseParallelForMain();
        UseParallelForeach.UseParallelForeachMain();
        PLINQQuery.PLINQQueryMain();
        CancelParallelQuery.CancelParallelQueryMain();
    }
}