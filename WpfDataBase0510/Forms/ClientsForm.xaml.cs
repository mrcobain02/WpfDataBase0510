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
    /// Логика взаимодействия для ClientsForm.xaml
    /// </summary>
    public partial class ClientsForm : Window
    {

        Controllers.ClientController clientController;

        public ClientsForm()
        {

            InitializeComponent();
            
            try
            {
                
                clientController = new Controllers.ClientController();
                mainDataGrid.ItemsSource = clientController.Clients;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR DB");
            }
           
        }
      
        private void Refresh()
        {
            try
            {
                clientController = new Controllers.ClientController();
                mainDataGrid.ItemsSource = clientController.Clients;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");

            }
        }

        private void ButBack_Click(object sender, RoutedEventArgs e)
        {
            Forms.MenuForm menu = new MenuForm();
            menu.Show();
            Close();
        }



        private void ButAddClient_Click(object sender, RoutedEventArgs e)
        {
            Forms.AddClient addClient = new AddClient();
            if ( addClient.ShowDialog() == true)
            {
                try
                {
                    mainDataGrid.ItemsSource = clientController.Clients;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR DB");
                }
            }

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

           


        }
    }
}
