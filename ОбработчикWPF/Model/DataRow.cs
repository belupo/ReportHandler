using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportHandler.Model
{
    public class DataRow : Entity
    {
        public int Order { get; set; }
        public DataCell Klnt { get; set; }
        public DataCell Inn { get; set; }
        public DataCell Adr { get; set; }
        public DataCell UrAdr { get; set; }
        public DataCell Reg { get; set; }
        public DataCell City { get; set; }
        public DataCell Fillial { get; set; }
        public DataCell Prep { get; set; }
        public DataCell Rashod { get; set; }
        public DataCell Prihod { get; set; }
        public DataCell Tend { get; set; }
        public DataCell TipTend { get; set; }
        public DataCell TipProd { get; set; }
        public DataCell CodKlnt { get; set; }
        public DataCell CodPrep { get; set; }
        public DataCell Ost { get; set; }
        public DataCell TipOtgr { get; set; }
        public DataCell IdInDistrDB { get; set; }
        public DataRow()
        {
        }

        public class DataCell:Entity
        {
            public int Collumn { get; set; }
            public string Value { get; set; }
        }
    }
}
