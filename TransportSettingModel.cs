using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelingAutoTraffic
{
    public class TransportSettingModel
    {
        public bool IsDeterminate
        {
            get;
            set;
        }

        public bool IsRandom
        {
            get;
            set;
        }

        public float Intensity
        {
            get;
            set;
        }

        public float StartInterval
        {
            get;
            set;
        }

        public float EndInterval
        {
            get;
            set;
        }

        public float RandomDispersion
        {
            get;
            set;
        }

        public float MathExpectation
        {
            get;
            set;
        }

        public int DeterminateInterval
        {
            get;
            set;
        }

        public string Law
        {
            get;
            set;
        }
    }
}
