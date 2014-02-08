using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum SH { morning, noon };

namespace Problema1
{
    class Seller: Persoana
    {
        List<Client> _clients = new List<Client>();

        public Seller(String fname, String sname, int age)
            : base(fname, sname, age)
        {
        }
        //caut clientul in lista
        public Client searchClient(String clientfname)
        {
            Client temp = _clients.Find(item => item.GetName() == clientfname + "  " + item.GetSName());
            if (temp != null)
            {
                return temp;   //clientul exista -> adaug masina
            }
            else
            {
                return null;   //creez client in main si il adaug in lista Seller-ului
            }
        }

        //adaug client in lista
        public void AddClient(Client client)
        {
            _clients.Add(client);
        }

        public void DisplayClients()
        {
            if (_clients.Count != 0)
                _clients.ForEach(item => Console.WriteLine(item.GetName()));
            else
                Console.WriteLine("Deocamdata nu am niciun client :(");
        }
    }
}
