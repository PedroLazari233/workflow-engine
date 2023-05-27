using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workflow_engine
{
    public class Status : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Change the status of the video record in the database to “Processing”.");
        }
    }
}
