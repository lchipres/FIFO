using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    class Task
    {
        public int _cicles;
        public Task next;

        public override string ToString()
        {
            return "Task cicles: "+_cicles;
        }
    }
}
