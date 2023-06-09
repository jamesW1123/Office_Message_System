﻿using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Windows.Forms;

namespace MessageServiceClientApp
{
    public partial class ClientGui : Form, MessageServiceClientApp.MService.IMessageServiceCallback
    {
        private MService.MessageServiceClient client;
        private InstanceContext instanceContext;
        private List<MService.User> users = new List<MService.User>();

        public ClientGui()
        {
            InitializeComponent();

            string result = "";

            foreach (MService.User u in users)
            {
                result += u.User_Name + " - " + u.Display_Name + "\r\n";
                clbSndRecipients.Items.Add(u.Display_Name);
            }
            txtSndMessage.Text = result;

            client.Join("user3");
        }

        public void RecieveMessage(MService.Message message)
        {
            txtSndMessage.Text = "RecieveMessage function";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var x = client.GetAllMessages("user3");
            string result = "";
            foreach (MService.Message msg in x)
            {
                result += msg.Mid + " - " + msg.Recipient + " - " + msg.Name + " - " + msg.Address + " - " + msg.Phone + " - " + msg.Email + " - " + msg.Message_Text + " - " + msg.Date_Taken + " - " + msg.Sent_From + " - " + msg.Delivered + " - " + msg.Read + " - " + msg.Deleted + "\r\n";
            }

            txtSndMessage.Text = result;
        }

        private void ClientGui_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Leave("user3");
            client.Close();
        }

        private void ClientGui_Load(object sender, EventArgs e)
        {
            // read config settings
            // get the user id
            // get the ip and port number for the service
        }

        private void Initialize()
        {
            instanceContext = new InstanceContext(this);
            client = new MService.MessageServiceClient(instanceContext, new NetTcpBinding(), new EndpointAddress("net.tcp://127.0.0.1:8090/MessageService"));
            users.AddRange(client.GetActiveUsers());
        }
    }
}