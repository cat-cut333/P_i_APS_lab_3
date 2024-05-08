namespace P_i_APS_lab_3
{
    partial class Client_view
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_ip_server = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.list_client = new System.Windows.Forms.ListBox();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.button_send_message = new System.Windows.Forms.Button();
            this.groupBox_chat = new System.Windows.Forms.GroupBox();
            this.listBox_chat = new System.Windows.Forms.ListBox();
            this.groupBox_message = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox_chat.SuspendLayout();
            this.groupBox_message.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_ip_server
            // 
            this.textBox_ip_server.Location = new System.Drawing.Point(124, 18);
            this.textBox_ip_server.Name = "textBox_ip_server";
            this.textBox_ip_server.Size = new System.Drawing.Size(160, 22);
            this.textBox_ip_server.TabIndex = 0;
            this.textBox_ip_server.Text = "192.168.56.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login";
            // 
            // textBox_login
            // 
            this.textBox_login.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_login.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox_login.Location = new System.Drawing.Point(124, 57);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(160, 22);
            this.textBox_login.TabIndex = 3;
           // this.textBox_login.TextChanged += new System.EventHandler(this.textBox_login_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Подключиться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.list_client);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 369);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подключенные пользователи";
            // 
            // list_client
            // 
            this.list_client.FormattingEnabled = true;
            this.list_client.ItemHeight = 16;
            this.list_client.Location = new System.Drawing.Point(6, 39);
            this.list_client.Name = "list_client";
            this.list_client.Size = new System.Drawing.Size(149, 324);
            this.list_client.TabIndex = 0;
            // 
            // textBox_message
            // 
            this.textBox_message.Location = new System.Drawing.Point(6, 11);
            this.textBox_message.Multiline = true;
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(382, 57);
            this.textBox_message.TabIndex = 6;
            // 
            // button_send_message
            // 
            this.button_send_message.Location = new System.Drawing.Point(409, 11);
            this.button_send_message.Name = "button_send_message";
            this.button_send_message.Size = new System.Drawing.Size(104, 57);
            this.button_send_message.TabIndex = 7;
            this.button_send_message.Text = "Отправить";
            this.button_send_message.UseVisualStyleBackColor = true;
            this.button_send_message.Click += new System.EventHandler(this.button_send_message_Click);
            // 
            // groupBox_chat
            // 
            this.groupBox_chat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox_chat.Controls.Add(this.listBox_chat);
            this.groupBox_chat.Location = new System.Drawing.Point(180, 90);
            this.groupBox_chat.Name = "groupBox_chat";
            this.groupBox_chat.Size = new System.Drawing.Size(351, 368);
            this.groupBox_chat.TabIndex = 8;
            this.groupBox_chat.TabStop = false;
            this.groupBox_chat.Text = "Чат";
            // 
            // listBox_chat
            // 
            this.listBox_chat.FormattingEnabled = true;
            this.listBox_chat.ItemHeight = 16;
            this.listBox_chat.Location = new System.Drawing.Point(6, 38);
            this.listBox_chat.Name = "listBox_chat";
            this.listBox_chat.Size = new System.Drawing.Size(339, 324);
            this.listBox_chat.TabIndex = 0;
            // 
            // groupBox_message
            // 
            this.groupBox_message.Controls.Add(this.textBox_message);
            this.groupBox_message.Controls.Add(this.button_send_message);
            this.groupBox_message.Location = new System.Drawing.Point(12, 458);
            this.groupBox_message.Name = "groupBox_message";
            this.groupBox_message.Size = new System.Drawing.Size(519, 74);
            this.groupBox_message.TabIndex = 9;
            this.groupBox_message.TabStop = false;
            // 
            // Client_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 533);
            this.Controls.Add(this.groupBox_message);
            this.Controls.Add(this.groupBox_chat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ip_server);
            this.Name = "Client_view";
            this.Text = "CHAT";
            this.groupBox1.ResumeLayout(false);
            this.groupBox_chat.ResumeLayout(false);
            this.groupBox_message.ResumeLayout(false);
            this.groupBox_message.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ip_server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox list_client;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Button button_send_message;
        private System.Windows.Forms.GroupBox groupBox_chat;
        private System.Windows.Forms.ListBox listBox_chat;
        private System.Windows.Forms.GroupBox groupBox_message;
    }
}

