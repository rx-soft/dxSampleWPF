using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2 {
    public class SampleSource1 {
        public ObservableCollection<SampleItem> Items { get; set; }
        public SampleSource1() {
            Items = new ObservableCollection<SampleItem>();
            for (int i = 0; i < 10; i++) {
                Items.Add(new SampleItem() { Id = i, Name = "item " + i.ToString(), Flag = (i % 2 == 0), Number = i * 12.5, Time = DateTime.Now.AddDays(i).AddHours(i).AddMinutes(i) });
            }
        }
    }

    public class SampleItem {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Flag { get; set; }
        public double Number { get; set; }
        public DateTime Time { get; set; }
    }
}
