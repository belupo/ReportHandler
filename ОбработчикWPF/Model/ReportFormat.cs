using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportHandler.Model
{
    public class ReportFormat:Entity
    {
        public List<TextSplitter> Patterns { get; set; }
        public string Name { get; set; }
        public int PagesCount { get; set; }
        public int FrstPageNum { get; set; }
        public bool Spravochnik { get; set; }
        public Distr Distr { get; set; }
        public ObservableCollection<DataRow> ReportTemplate { get; set; }
    }
}
