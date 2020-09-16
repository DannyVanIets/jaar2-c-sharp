using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marathon
{
    class Marathon
    {
        public event EventHandler<RunnerInfo> RunnerFinished;

        public void Finished(string name, uint rank)
        {
            OnFinished(new RunnerInfo(name, rank));
        }

        private void OnFinished(RunnerInfo info)
        {
            if (RunnerFinished != null)
            {
                RunnerFinished(this, info);
            }
        }
    }
}
