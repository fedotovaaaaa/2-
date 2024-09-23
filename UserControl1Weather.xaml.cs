using System;
using System.Collections.Generic;
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
using WpfApp1пр2.DataModel;
namespace WpfApp1пр2
{
    /// <summary>
    /// Логика взаимодействия для UserControl1Weather.xaml
    /// </summary>
    public partial class UserControl1Weather : UserControl
    {
        public UserControl1Weather()
        {
            InitializeComponent();
        }
        public UserControl1Weather(Weather weather)
        {
            InitializeComponent();
            System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["weatherViewSource2"];
            myCollectionViewSource.Source = new List<Weather>() {weather};
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
