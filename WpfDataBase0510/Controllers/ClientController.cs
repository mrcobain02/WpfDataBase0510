using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDataBase0510.DataBase;

namespace WpfDataBase0510.Controllers
{
    public class ClientController
    {
        public List<DataBase.Client> Clients { get; set; }
        private DataBase.EntitiesWpfDataBase entities;

        public Client newClient = new DataBase.Client() { FirstName ="noNama" };



        public ClientController()
        {
            Clients = GetClient();
        }

        public List<Client> GetClient()
        {

            try
            {
                entities = new EntitiesWpfDataBase();
                return entities.Client.ToList();
            }
            catch
            {
                throw new Exception("ERROR DB");

            }
        }

        public  void Add ( )
        {
            try
            {
                entities.Client.Add(newClient);
                entities.SaveChanges();

                Clients = entities.Client.ToList();
            }
            catch
            {
                throw new Exception("ERROR ADD DB");

            }
        }
        public List<Client> GetClients()
        {
            try
            {
                entities = new DataBase.EntitiesWpfDataBase();
                return entities.Client.ToList();
            }
            catch
            {
                throw new Exception("ERROR DB");
            }
        }

    }
}
