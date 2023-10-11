using DevExpress.Xpf.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = new SampleTableSource();
        }
    }

    class ItemTypeToColorConverter : IValueConverter {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            if (targetType.Name != typeof(Brush).Name) {
                throw new InvalidOperationException("ItemTypeToColorConverter: TargetType must be a Brush.");
            }

            Brush b = Brushes.Blue;

            //if (((DataRowView)value) == null) return Brushes.White;

            //switch (((DataRowView)value).Row.Field<string>("Id")) {
            switch(value.ToString()) {
                case "0":
                    b = Brushes.Red;
                    break;
                case "1":
                    b = Brushes.RoyalBlue;
                    break;
                case "2":
                    b = Brushes.Orange;
                    break;
                default:
                    b = Brushes.White;
                    break;
            }

            return b;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
