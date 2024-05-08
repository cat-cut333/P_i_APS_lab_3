using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_i_APS_lab_3
{
    internal interface IClient_view
    {
        string indeficathion();
        void print_message(string message);

        void print_new_item_list(string item_list);
        void print_del_item_list(string item_list);
        string Get_ip_server();
        void Set_func_start(Func<int> func);
        void Set_func_send(Func<int> func);

        void Error(string error);

        string get_mess();
      //  void Set_func_stop(Func<int> func);
    }
}
