using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportHandler.Model
{
    public class CrossFormat : Entity
    {
        public int HeadersRow { get; set; }
        public int PrepCollumn { get; set; }
        public int CityCollumn { get; set; }
        public int FirstRow { get; set; }
        public List<TextSplitter> Patterns { get; set; }

    }
}
