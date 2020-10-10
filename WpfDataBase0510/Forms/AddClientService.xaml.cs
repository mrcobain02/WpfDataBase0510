using System;
using System.Collections;
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
    /// Логика взаимодействия для AddClientService.xaml
    /// </summary>
    public partial class AddClientService : Window
    {
        public AddClientService()
        {
            InitializeComponent();


            cbHours.ItemsSource = GetHours();
            cbMin.ItemsSource = GetMin();

           try
            { 
                DataBase.EntitiesWpfDataBase entities = new DataBase.EntitiesWpfDataBase();
                CBservice.ItemsSource = entities.Service.ToList().OrderBy(x => x.Title);
                CBClient.ItemsSource = entities.Client.ToList().OrderBy(x => x.FirstName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DB " + ex.Message);
            }    
            
            CBClient.SelectedIndex = 0;
            CBservice.SelectedIndex = 0;
        }

        private IEnumerable GetHours()
        {

            List<int> vs = new List<int>();
            for(int i =7; i<=21;i++)
            {
                vs.Add(i);
            }
            return vs;
        }

        private IEnumerable GetMin()
        {
            List<int> vs = new List<int>();

            for(int i = 0; i <= 59;i++)
            {
                vs.Add(i);
            }
            return vs;
        }

        private void ButBack_Click(object sender, RoutedEventArgs e)
        {
            Forms.MenuForm menu = new MenuForm();
            menu.Show();
            Close();
        }

        private void ButAdd_Click(object sender, RoutedEventArgs e)
        {
            DataBase.ClientService clientService = new DataBase.ClientService();

            var cl = CBClient.SelectedItem as DataBase.Client;

            var sr = CBservice.SelectedItem as DataBase.Service;
            if (cl == null)
            {
                MessageBox.Show("Выыберите клиента");
                return;
            }
            if (sr == null)
            {
                MessageBox.Show("Выберите услугу");
                return;
            }
            DateTime date;
            try
            {
               date = Dtp.SelectedDate.Value;
            }
            catch
            {
                MessageBox.Show("Выберите дату");
                return;
            }


            date.AddHours(Convert.ToDouble(cbHours.SelectedItem));
            date.AddMinutes(Convert.ToDouble(cbMin.SelectedItem));
            clientService.ClientID = cl.ID;
            clientService.ServiceID = sr.ID;
            clientService.StartTime = date;
            clientService.Comment = TbComment.Text;

            DataBase.EntitiesWpfDataBase entities = new DataBase.EntitiesWpfDataBase();
            try
            {
                entities.ClientService.Add(clientService);
                entities.SaveChanges();
                MessageBox.Show("Добавление произошло успешно");
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR ADD" + ex.Message);
            }


        }
    }
}
