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
using System.Windows.Shapes;

namespace WpfDataBase0510.Forms
{
    /// <summary>
    /// Логика взаимодействия для ServiceForm.xaml
    /// </summary>
    public partial class ServiceForm : Window
    {
        public ServiceForm()
        {
            InitializeComponent();
        }

        private void ButBack_Click(object sender, RoutedEventArgs e)
        {
            Forms.MenuForm menu = new MenuForm();
            menu.Show();
            Close();
        }
    }
}
