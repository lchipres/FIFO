using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    class Processor
    {
        static private Random r,c;
        int _emptyCicles,_completedTasks,_uncompletedTasks;
        Task first, temporal;

        public void cicling()
        {
            for(int i = 0; i < 300; i++)
            {
                randomTask();
            }
        }
        private void randomTask()
        {
            r = new Random();
            Task helper = first ;
            if (first == null)
            {
                if (r.Next(1, 100) <= 36)
                {
                    first = temporal;
                }
            }//Is the first?
            else
            {
                if (r.Next(1, 100) <= 36)
                {

                    while (helper.next != null)
                    {
                        helper = helper.next;
                    }
                    helper.next._cicles = c.Next(4, 14);
                }
            }//Add to next
        }

        public string listTasks()
        {
            Task helper = first;
            string s = "";
            while (helper.next != null)
            {
                s += helper+Environment.NewLine;                  
                helper = helper.next;
            }
            return s;
        }
        
    }
}
