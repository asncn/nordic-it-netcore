using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_17
{
    class WorkInfo : EventArgs
    {
        public WorkType Type { get; set; }

        public int Hours { get; set; }

        public WorkInfo  (Worker.WorkType typeOfWork)


    }
}
