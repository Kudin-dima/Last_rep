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

namespace Laboratornaia
{
    /// <summary>
    /// Логика взаимодействия для ThreatInformation.xaml
    /// </summary>
    public partial class ThreatInformation : Window
    {
        public ThreatInformation()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void ShowInfo(RecordingThreat threat)
        {
            this.DataContext = threat;
        }
    }
}
