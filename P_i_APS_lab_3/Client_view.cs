using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_i_APS_lab_3
{
    public partial class Client_view : Form , IClient_view
    {
        Func<int> Start;
        Func<int> Send;
        int flag_error = 0;
        public Client_view()
        {
            InitializeComponent();
            Closing += ExecuteOnClosing;
        }

        public string Get_ip_server()
        {
            return textBox_ip_server.Text;
        }

        public string get_mess()
        {
            string mes = textBox_message.Text;
            if (mes == "")
            {
                mes = null;
            }
            textBox_message.Clear();
            return mes;
           
        }

        public string indeficathion()
        {
            
            return textBox_login.Text;
        }

        public void print_new_item_list(string item_list)
        {

            if(list_client.InvokeRequired ) // проверка на то вызван метод в птоке gui или нет
            {
                list_client.Invoke(new Action(() => { list_client.Items.Add(item_list); }));
            }

            else
            {
                list_client.Items.Add(item_list);
            }
        }

        public void print_message(string message)
        {

            if (listBox_chat.InvokeRequired) // проверка на то вызван метод в птоке gui или нет
            {
                listBox_chat.Invoke(new Action(() => { listBox_chat.Items.Add(message); }));
            }

            else
            {
                listBox_chat.Items.Add(message);
            }

          
        }

        public void Set_func_send(Func<int> func)
        {
            Send = func;
        }

        public void Set_func_start(Func<int> func)
        {
            Start = func;
        }

      
        void ExecuteOnClosing(object sender, CancelEventArgs e)
        {
             Environment.Exit(0);
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox_login.Text.IndexOf('/') !=-1 )
            {
                MessageBox.Show("Использованы недопустимые символы");

                return;
            }

            Start();
            if(flag_error == 0)
            {
                MessageBox.Show("Вы подключились");
                textBox_login.Enabled = false;
                textBox_ip_server.Enabled = false;
                button1.Enabled = false;
            }

            
        }

        private void button_send_message_Click(object sender, EventArgs e)
        {
            Send();
        }

        public void print_del_item_list(string item_list)
        {
            if (list_client.InvokeRequired) // проверка на то вызван метод в птоке gui или нет
            {
                list_client.Invoke(new Action(() => { list_client.Items.Remove(item_list); }));
            }

            else
            {
                list_client.Items.Remove(item_list);
            }
        }

        public void Error(string error)
        {
            flag_error = 1;
            MessageBox.Show(error);
        }

        
    }
}
