using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2 {
    class SampleTableSource {
        public DataTable Items { get; set; }
        public SampleTableSource() {
            Items = new DataTable();
            Items.Columns.Add("Id");
            Items.Columns.Add("Name");
            for (int i = 0; i < 10; i++) {
                Items.Rows.Add(i, "name " + i.ToString());
            }
        }
    }
}