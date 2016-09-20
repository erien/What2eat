using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eat.Core.Model
{
    public class LunchPlace
    {
        public string Name
        {
            get;
            set;
        }

        public string Website
        {
            get;
            set;
        }

        public GPSCoordinate Location
        {
            get;
            set;
        }
    }
}
