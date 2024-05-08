using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Xml.Linq;
using System.Drawing;
using System.Diagnostics;

namespace P_i_APS_lab_3
{
    internal class Client_controller
    {
        IClient_view obj_client_View;
        IClient_model obj_client_Model;
        IPEndPoint ipPoint;
        Socket tcpListener;
        public bool Active = true;
    

        public Client_controller(object inter_view, object inter_model)
        {
            obj_client_Model = (IClient_model)inter_model;
            obj_client_View = (IClient_view)inter_view;
            ipPoint = new IPEndPoint(IPAddress.Any, 8888);
            tcpListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            obj_client_View.Set_func_start(Start_client);
            obj_client_View.Set_func_send(Send_message);
           

        }


        public int Start_client()
        {


            try
            {
                tcpListener.Connect(obj_client_View.Get_ip_server(), 8888);

           
                string name_client = obj_client_View.indeficathion();

                obj_client_Model.set_name(name_client);
                byte[] data1 = Encoding.UTF8.GetBytes(name_client);
                tcpListener.Send(data1);

                //отправляем серверу имя клиента
                //

                // new Thread(() => Send_message()).Start();
                new Thread(() => Listen()).Start();


                return 0;
            }
            catch(Exception ex)
            {
                obj_client_View.Error("Не удалось подключиться");
                return -1;
            }
        }

       

        public bool Get_activ()
        {
            return Active;
        }
        public int Send_message() //ОТПРАВИТЬ СООБЩЕНИЕ
        {
            string mess = obj_client_View.get_mess();
            if (mess != null)
            {
                string mess_and_name = obj_client_Model.Get_name();
                mess_and_name += " => ";
                mess_and_name += mess;
                byte[] data1 = Encoding.UTF8.GetBytes(mess_and_name);
                tcpListener.Send(data1);

            }
            return 0;
        }

        public void Listen()  //СЛУШАТЬ
        {
            byte[] data = new byte[1024];
            while (Active)
            {
              
                
                int bytes = tcpListener.Receive(data);
                string message = Encoding.UTF8.GetString(data, 0, bytes);
                char flag_mes =  message[0];
                message = message.Remove(0, 1);
               // Receive_message(message);
                if (flag_mes =='0')
                {
                    Receive_message(message);
                }
                if (flag_mes == '1')
                {
                    Receive_new_list_client(message);
                    
                }
                if (flag_mes == '2')
                {
                    Receive_del_list_client(message);

                }
                if(flag_mes == '3')
                {
                   message = message.Remove(0, 1);
                    string[] list_client = message.Split('/');
                    for(int i = 0; i< list_client.Length; i++)
                    {
                      
                        obj_client_Model.Add_item_list_client(list_client[i]);
                        obj_client_View.print_new_item_list(list_client[i]);
                    }
                    
                }
            }

           

        }
        public void Receive_message(string message)//ПОЛУЧИТЬ СООБЩЕНИЕ
        {
          
            obj_client_View.print_message(message);
        }

        public void Receive_new_list_client(string message) //ПОЛУЧИТЬ  УЧАСТНИКОВ
        {
            obj_client_Model.Add_item_list_client(message);
            obj_client_View.print_new_item_list(message);
           
        }

        public void Receive_del_list_client(string message) //
        {
            obj_client_Model.Dell_item_list_client(message);
            obj_client_View.print_del_item_list(message);

        }

    }
}
