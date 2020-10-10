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

namespace WpfDataBase0510
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PasswordTB.Text = "0000";
        }

        private void ButInAdmin_Click(object sender, RoutedEventArgs e)
        {
            string s = "0000";
            if (PasswordTB.Text == s )
            {
                Forms.MenuForm form = new Forms.MenuForm();
                form.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }



            /*DataBase.EntitiesWpfDataBase entities = new DataBase.EntitiesWpfDataBase();
            string s = entities.Service.FirstOrDefault().Title;
            MessageBox.Show(s);*/
            



        }

        private void ButInGuest_Click(object sender, RoutedEventArgs e)
        {
            Forms.MenuForm form = new Forms.MenuFormGuest();
            form.Show();
            Close();
        }
    }
}
