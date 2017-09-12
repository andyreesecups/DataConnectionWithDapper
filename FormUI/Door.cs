using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Door
    {
        public int MATCOD { get; set; }

        public int IDNUM { get; set; }

        public int QTYCHG { get; set; }

        public int UNTCST { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{ MATCOD } { IDNUM } ({ QTYCHG })";
            }
        }
    }
}
