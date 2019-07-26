using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportHandler.Model
{
    public class SplitRow: DataRow
    {
        public bool Empty { get; set; }
        public bool BoldText { get; set; }
        public string Color { get; set; }

        public SplitRow()
        {
            
        }

    }
}
