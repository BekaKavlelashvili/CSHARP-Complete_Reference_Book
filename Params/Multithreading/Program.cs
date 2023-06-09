﻿using Multithreading;

class MultithreadingDemo
{
    static void Main()
    {
        DemonstrateThreadClass.DemonstrateThreadClassMain();
        ImproveThreadClass.ImproveThreadClassMain();
        MultipleThreads.MultipleThreadsMain();
        UseThreadJoin.UseThreadJoinMain();
        PassArgToThreadMethod.PassArgToThreadMethodMain();
        DemonstrateThreadPriorities.DemonstrateThreadPrioritiesMain();
        UseLock.UseLockMain();
        UseWaitAndPulse.UseWaitAndPulseMain();
        UseMethodImplAttribute.UseMethodImplAttributeMain();
        UseMutex.UseMutexMain();
        UseSemaphore.UseSemaphoreMain();
        UseManualEventObj.UseManualEventObjMain();
        UseInterlockedOperations.UseInterlockedOperationsMain();
    }
}