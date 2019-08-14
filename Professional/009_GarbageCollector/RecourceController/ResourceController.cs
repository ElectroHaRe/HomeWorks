using System;
using System.Threading;

namespace RecourceController
{
    class ResourceController
    {
        private Exception CriticalMemoryException = new Exception("Critical memory usage");

        public long criticalMemory { get; private set; } = 0;
        public long UsedMemory { get; private set; } = 0;
        public Thread controllerThread { get; private set; }

        public delegate void ExceptionHandler(Exception e);
        private ExceptionHandler exceptionHandler = null;

        private ResourceController()
        {
            controllerThread = new Thread(Monitor);
        }

        public ResourceController(long criticalMemory):this()
        {
            if (criticalMemory < 0)
                throw new ArgumentException("Critical memory cannot be negative");
            this.criticalMemory = criticalMemory;
        }

        public ResourceController(long criticalMemory, ExceptionHandler exceptionHandler):this(criticalMemory)
        {
            this.exceptionHandler = exceptionHandler;
        }

        public void StartMonitoring()
        {
            controllerThread.IsBackground = true;
            controllerThread.Start();
        }

        public void StopMonitoring()
        {
            criticalMemory = -1;
        }

        private void Monitor()
        {
            while (UsedMemory<criticalMemory)
            {
                UsedMemory = GC.GetTotalMemory(false);
            }
            if (criticalMemory < 0)
                return;
            if (exceptionHandler == null)
                throw CriticalMemoryException;
            else exceptionHandler(CriticalMemoryException);
        }
    }
}
