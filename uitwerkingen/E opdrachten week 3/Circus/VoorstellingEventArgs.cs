using System;

namespace Circus
{
    enum VoorstellingMoment { opening, naPauze, slot};
    class VoorstellingEventArgs : EventArgs
    {
        public VoorstellingMoment Moment { get; set; }
        public VoorstellingEventArgs(VoorstellingMoment moment)
        {
            Moment = moment;
        }
    }
}