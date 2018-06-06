using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    class Processor
    {
        static private Random r, c;
        int _emptyCicles, _completedTasks, _uncompletedTasks;
        Task first;

        public void process()
        {
            for (int i = 0; i < 300; i++)
            {
                randomTask();
                if (first != null)
                {
                    if (first._cicles > 0)
                    {
                        first._cicles--;
                    }
                    else
                    {
                        _completedTasks++;
                        first = first.next;
                    }
                }
            }
            uncompletedTasks();
        }
        private void randomTask()
        {
            r = new Random();
            Task helper = first;
            if (first == null)
            {
                if (r.Next(1, 100) <= 36)
                {
                    first = new Task(c.Next(1, 15));
                }
                else
                {
                    _emptyCicles++;
                }
            }//Is the first?
            else
            {
                if (r.Next(1, 100) <= 36)
                {
                    helper.next._cicles = c.Next(4, 15);
                    addBegin(helper.next);
                    helper = helper.next;
                }
                else
                {
                    _emptyCicles++;
                }
            }//Add to next
        }
        public void addBegin(Task t)
        {
            Task nw = new Task(c.Next(4, 15));
            nw.next = first;//ir al primer producto
            first = nw;//Lo coloca en el primero
        }

        public void uncompletedTasks()
        {
            if (first != null)
            {
                Task helper = first;
                while (helper.next != null)
                {
                    _uncompletedTasks++;
                    helper = helper.next;
                }
            }
            else
            {
                _uncompletedTasks = 0;
            }

        }

        public int getEmptyCicles()
        {
            return _emptyCicles;
        }

        public int getUncompletedTasks()
        {
            return _uncompletedTasks;
        }

        public int getCompletedTasks()
        {
            return _completedTasks;
        }
    }
}
