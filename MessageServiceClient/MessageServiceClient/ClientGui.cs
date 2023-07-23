using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;

namespace MessageServiceClientApp
{
    public partial class ClientGui : Form, MessageServiceClientApp.MService.IMessageServiceCallback
    {
        private MService.MessageServiceClient client;
        private LinkedListNode<Node> currentNode;
        private InstanceContext instanceContext;
        private MService.User me = new MService.User();
        private LinkedList<Node> messageList = new LinkedList<Node>();
        private Dictionary<int, MService.Message> receivedMessages = new Dictionary<int, MService.Message>();
        private string serverIp = "127.0.0.1";
        private string serverPort = "8090";
        private System.Windows.Forms.Timer timer;
        private List<MService.User> users = new List<MService.User>();

        public ClientGui()
        {
            InitializeComponent();
        }

        public void RecieveMessage(MService.Message message)
        {
            var found = messageList.Where(m => m.Key == message.Mid).ToList();

            if (found.Count == 0)
            {
                messageList.AddLast(new LinkedListNode<Node>(new Node(message.Mid, message)));
                client.MarkDelivered(message.Mid);

                tabReceive.Text = $"Receive ({messageList.Count})";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (client is null || client.State != CommunicationState.Opened)
            {
                connectToService();
            }

            MService.Message m = currentNode.Value.Value;

            if (m != null)
            {
                client.DeleteMessage(m.Mid);
                m.Deleted = 1;

                LinkedListNode<Node> tempNode;

                if (currentNode != null)
                {
                    if (currentNode.Next == null)
                    {
                        tempNode = messageList.First;
                    }
                    else
                    {
                        tempNode = currentNode.Next;
                    }

                    messageList.Remove(currentNode);
                    currentNode = tempNode;

                    tabReceive.Text = $"Receive ({messageList.Count})";
                    //this.ResumeLayout(true);

                    displayMessage();
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentNode != null)
            {
                if (timer.Enabled)
                {
                    timer.Stop();
                }

                if (currentNode.Next == null)
                {
                    currentNode = messageList.First;
                }
                else
                {
                    currentNode = currentNode.Next;
                }

                displayMessage();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentNode != null)
            {
                if (currentNode.Previous == null)
                {
                    currentNode = messageList.Last;
                }
                else
                {
                    currentNode = currentNode.Previous;
                }

                displayMessage();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (client is null || client.State != CommunicationState.Opened)
            {
                connectToService();
            }

            if (!String.IsNullOrWhiteSpace(txtSndName.Text) &&
                !String.IsNullOrWhiteSpace(txtSndMessage.Text))
            {
                foreach (CheckboxItem recipient in clbSndRecipients.CheckedItems)
                {
                    MService.Message message = new MService.Message();
                    message.Name = txtSndName.Text;
                    message.Address = txtSndAddress.Text;
                    message.Phone = txtSndPhone.Text;
                    message.Email = txtSndEmail.Text;
                    message.Message_Text = txtSndMessage.Text;
                    message.Date_Taken = DateTime.Now.ToString();
                    message.Recipient = recipient.UserName;
                    message.Sent_From = me.User_Name;

                    try
                    {
                        client.SendMessage(message);
                    }
                    catch (System.ServiceModel.EndpointNotFoundException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private void chkRead_Click(object sender, EventArgs e)
        {
            if (client is null || client.State != CommunicationState.Opened)
            {
                connectToService();
            }

            MService.Message m = currentNode.Value.Value;

            if (m != null)
            {
                if (chkRead.Checked)
                {
                    client.MarkRead(m.Mid);
                    m.Read = 1;
                }
                else
                {
                    client.MarkNotRead(m.Mid);
                    m.Read = 0;
                }
            }
        }

        private void ClientGui_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                client.Leave(me.User_Name);
                client.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ClientGui_Load(object sender, EventArgs e)
        {
            instanceContext = new InstanceContext(this);

            clbSndRecipients.DisplayMember = "DisplayName";
            clbSndRecipients.ValueMember = "UserName";

            clbRecRecipients.DisplayMember = "DisplayName";
            clbRecRecipients.ValueMember = "UserName";

            lblSndDateText.Text = DateTime.Now.ToShortDateString();

            // read config settings
            //set timer interval
            timer = new Timer();
            timer.Tick += new EventHandler(readTimer);
            timer.Interval = 2000;

            // get the ip and port number for the service
            // get the user id
            me.User_Name = "user3";
            me.Display_Name = "User 3";

            cmbShowSelect.SelectedIndex = 0;

            connectToService();

            getAllMessages();
        }

        private void cmbShowSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(cmbShowSelect.SelectedItem);
            switch (cmbShowSelect.SelectedItem.ToString().ToLower())
            {
                case "new":
                    getNewMessages();
                    break;

                case "read":
                    break;

                case "unread":
                    break;

                case "deleted":
                    break;

                default:
                    getAllMessages();
                    break;
            }
        }

        private void connectToService()
        {
            if (client is null || client.State != CommunicationState.Opened)
            {
                client = new MService.MessageServiceClient(instanceContext, new NetTcpBinding(), new EndpointAddress($"net.tcp://{serverIp}:{serverPort}/MessageService"));
            }

            try
            {
                if (string.IsNullOrWhiteSpace(me.User_Name))
                {
                    me.User_Name = "user3";
                    me.Display_Name = "User 3";

                    register(me);
                }

                client.Join(me.User_Name);
                setRecipients();
            }
            catch (System.ServiceModel.EndpointNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void displayMessage()
        {
            MService.Message m = currentNode.Value.Value;

            if (m != null)
            {
                lblRecDateText.Text = DateTime.Parse(m.Date_Taken).ToString("M/dd/yyyy h:mm tt");
                txtRecName.Text = m.Name;
                txtRecAddress.Text = m.Address;
                txtRecPhone.Text = m.Phone;
                txtRecEmail.Text = m.Email;
                txtRecMessage.Text = m.Message_Text;

                if (m.Read == 0)
                {
                    timer.Start();
                    chkRead.Checked = false;
                }
                else
                {
                    chkRead.Checked = true;
                }
            }
        }

        private void getAllMessages()
        {
            try
            {
                if (client is null || client.State != CommunicationState.Opened)
                {
                    connectToService();
                }

                List<MService.Message> tempAllMessages = new List<MService.Message>();
                tempAllMessages.AddRange(client.GetAllMessages(me.User_Name));

                foreach (MService.Message message in tempAllMessages)
                {
                    var found = messageList.Where(m => m.Key == message.Mid).ToList();

                    if (found.Count == 0)
                    {
                        messageList.AddLast(new LinkedListNode<Node>(new Node(message.Mid, message)));
                        client.MarkDelivered(message.Mid);
                    }
                }

                tabReceive.Text = $"Receive ({messageList.Count})";
            }
            catch (System.ServiceModel.EndpointNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                client = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void getNewMessages()
        {
            try
            {
                if (client is null || client.State != CommunicationState.Opened)
                {
                    connectToService();
                }

                List<MService.Message> tempNewMessages = new List<MService.Message>();
                tempNewMessages.AddRange(client.GetNewMessages(me.User_Name));

                foreach (MService.Message message in tempNewMessages)
                {
                    var found = messageList.Where(m => m.Key == message.Mid).ToList();

                    if (found.Count == 0)
                    {
                        messageList.AddLast(new LinkedListNode<Node>(new Node(message.Mid, message)));
                        client.MarkDelivered(message.Mid);
                    }
                }

                tabReceive.Text = $"Receive ({messageList.Count})";
            }
            catch (System.ServiceModel.EndpointNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                client = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void mnuConnect_Click(object sender, EventArgs e)
        {
            if (client is null || client.State != CommunicationState.Opened)
            {
                connectToService();
            }
        }

        private void mnuGetAll_Click(object sender, EventArgs e)
        {
            getAllMessages();
            if (messageList.Count > 0)
            {
                if (currentNode == null)
                {
                    currentNode = messageList.First;
                }
                displayMessage();
            }
        }

        private void mnuGetNew_Click(object sender, EventArgs e)
        {
            getNewMessages();
            if (messageList.Count > 0)
            {
                if (currentNode == null)
                {
                    currentNode = messageList.First;
                }
                displayMessage();
            }
        }

        private void readTimer(object sender, EventArgs e)
        {
            timer.Stop();

            if (client is null || client.State != CommunicationState.Opened)
            {
                connectToService();
            }

            try
            {
                MService.Message m = currentNode.Value.Value;

                if (m != null)
                {
                    client.MarkRead(m.Mid);
                    m.Read = 1;
                    chkRead.Checked = true;
                }
            }
            catch (System.ServiceModel.EndpointNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                client = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void register(MService.User user)
        {
            if (client is null || client.State != CommunicationState.Opened)
            {
                connectToService();
            }

            try
            {
                client.RegisterUser(user);
            }
            catch (System.ServiceModel.EndpointNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void setRecipients()
        {
            if (client is null || client.State != CommunicationState.Opened)
            {
                connectToService();
            }

            try
            {
                clbSndRecipients.Items.Clear();
                users.Clear();

                users.AddRange(client.GetActiveUsers());

                foreach (MService.User u in users)
                {
                    clbSndRecipients.Items.Add(new CheckboxItem(u.Display_Name, u.User_Name));
                    clbRecRecipients.Items.Add(new CheckboxItem(u.Display_Name, u.User_Name));
                }
            }
            catch (System.ServiceModel.EndpointNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                client = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedTab.Name == "tabReceive")
                {
                    getAllMessages();
                    if (messageList.Count > 0)
                    {
                        if (currentNode == null)
                        {
                            currentNode = messageList.First;
                        }
                        displayMessage();
                    }
                }
                else
                {
                    lblSndDateText.Text = DateTime.Now.ToShortDateString();
                }
            }
            catch (System.ServiceModel.EndpointNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                client = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}