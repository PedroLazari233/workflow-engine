using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workflow_engine
{
    public class Workflow
    {
        private readonly IList<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public void RegisterActivity(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void Run()
        {
            foreach (IActivity activity in _activities)
            {
                activity.Execute();
            }
        }
    }
}
