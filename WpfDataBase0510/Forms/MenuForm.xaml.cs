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
    /// Логика взаимодействия для MenuForm.xaml
    /// </summary>
    public partial class MenuForm : Window
    {
        public MenuForm()
        {
            InitializeComponent();
            Title = "Вы зашли как админ";
        }

        private void ButBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void OpenService_Click(object sender, RoutedEventArgs e)
        {
            ServiceForm mainWindow = new ServiceForm();
            mainWindow.Show();
            Close();

        }

        private void OpenClient_Click(object sender, RoutedEventArgs e)
        {
            ClientsForm mainWindow = new ClientsForm();
            mainWindow.Show();
            Close();
        }

        private void OpenClientService_Click(object sender, RoutedEventArgs e)
        {
            ClientService mainWindow = new ClientService();
            mainWindow.Show();
            Close();
        }

        private void OpenAddClientService_Click(object sender, RoutedEventArgs e)
        {
            AddClientService mainWindow = new AddClientService();
            mainWindow.Show();
            Close();
        }
    }

    public partial class MenuFormGuest : MenuForm
    {
        public MenuFormGuest()
        {
            this.Title = "Вы зашли как гость";
        }
    }
}
