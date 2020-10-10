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
    /// Логика взаимодействия для AddClient.xaml
    /// </summary>
    public partial class AddClient : Window
    {

        Controllers.ClientController clientController;

        public AddClient()
        {

            InitializeComponent();

            DataBase.EntitiesWpfDataBase entities = new DataBase.EntitiesWpfDataBase();

            cbGender.ItemsSource = entities.Gender.ToList();

            


            try
            {

              clientController = new Controllers.ClientController();

                mainGrid.DataContext = clientController.newClient;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR DB");

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            try
            {
                clientController.newClient = mainGrid.DataContext as DataBase.Client;

                clientController.newClient.RegistrationDate = DpRegistrationDate.SelectedDate.Value;
                clientController.newClient.Birthday = DpBirthday.SelectedDate.Value;

                clientController.newClient.GenderCode = (cbGender.SelectedItem as DataBase.Gender).Code;


                clientController.Add();

                MessageBox.Show("ура");

                DialogResult = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
