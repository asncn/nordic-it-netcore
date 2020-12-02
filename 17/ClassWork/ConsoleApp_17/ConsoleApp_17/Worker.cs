using System;
using System.Collections.Generic;
using System.Text;
//using ConsoleApp_17.Program.WorkType;

namespace ConsoleApp_17
{
    //public enum WorkType
    //{
    //    Work,
    //    DoNothing
    //}

    public delegate int WorkPerformedEventHandler(int hours, WorkType workType);
    public  class Worker
    {
        private string name { get; set; } = "noname";
        private WorkType workType;

        //public event WorkPerformedEventHandler WorkPerformed;
        public event EventHandler WorkComleted;

        public event EventHandler <WorkInfo> WorkPerformed;
        
        public void DoWork(int hours, WorkType worktype)
        {
            for (int i = 0; i < hours; i++)
            {

                if (workType == WorkType.Work)
                {
                    Console.WriteLine("$$$$$$$$$$");
                }
                else if (workType == WorkType.DoNothing)
                {
                    Console.WriteLine("Zzzz....");
                }
                //WorkPerformed
               // if (WorkPerformed != null)

               // {
                    WorkPerformed(this, new WorkInfo(WorkType, hours));
               // }
            }
            //WorkCompleted
            WorkComleted?.Invoke(this, EventArgs.Empty);  
        }
    }
}
