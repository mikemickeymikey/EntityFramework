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

namespace EntityFramework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MODEL.pelisContext m_db = new MODEL.pelisContext();
        DAOManager manager;
        public MainWindow()
        {
            InitializeComponent();
            manager = new DAOManager(m_db);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgPelis.ItemsSource = manager.GetPelis();
        }
    }
}
