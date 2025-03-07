using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MultiThreading_and_Task_Concepts
{
    class Class_Program
    {
        public static async Task ClassProgram()
        {
            //Thread thread1 = new Thread(PrintNumbers);
            //Thread thread2 = new Thread(PrintNumbers);

            //thread1.Start();
            //thread2.Start();

            Task task1 = Task.Run(async () => await PrintNumbers());
            Task task2 = Task.Run(async () => await PrintNumbers());

            await Task.WhenAll(task1, task2);

        }

        public static async Task PrintNumbers()
        {
            int? taskId = Task.CurrentId;
            for(int i = 0; i<=5; i++)
            {
                //Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: {i}");
                //Thread.Sleep(1000);

                Console.WriteLine($"Task {taskId} : {i}");
               await Task.Delay(5000);
            }
        }
    }
}
