using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace P_i_APS_lab_3
{
    internal class Client_model : IClient_model
    {
        string name_client;

        List<string> list_client  = new List<string>();

        public void Add_item_list_client(string name_client)
        {
            list_client.Add(name_client);
        }

        public void Dell_item_list_client(string name_client)
        {
            list_client.Remove(name_client);
        }

        public string Get_name()
        {
            return name_client;
        }

        public Socket Get_socket_server()
        {
            throw new NotImplementedException();
        }

        public void set_name(string name)
        {
            name_client = name;
        }

        public void Set_socket_server(Socket socket_server)
        {
            throw new NotImplementedException();
        }
    }
}
