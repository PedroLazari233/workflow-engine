using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workflow_engine
{
    public class UploadVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Upload a video to a cloud storage.");
        }
    }
}
