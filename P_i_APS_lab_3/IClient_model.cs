using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace P_i_APS_lab_3
{
    internal interface IClient_model
    {

        void Add_item_list_client(string name_client);
        void Dell_item_list_client(string name_client);
        void Set_socket_server(Socket socket_server);
        Socket Get_socket_server();
        void set_name(string name);
        string Get_name();
    }
}
