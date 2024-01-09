using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using client_server.Utils;

namespace client_server
{
    public partial class Client : Form
    {
        bool isButtonClicked = false;
        bool flag_connect = false;
        string input = string.Empty;

        //   private Server server_side;
        private const string CRLF = "\r\n";
        private const string LOCALHOST = "192.168.1.17";
        private const int DEFAULT_PORT = 5000;

        private IPAddress _serverIpAddress;
        private int _port;
        public TcpClient _client;

        public static Client frm_Instace_client;
        public TextBox txt_IPAddress_Instance;
        public TextBox txt_Port_Instance;
        public TextBox txt_Status_Instance;
        public Button btn_Connected_Instance;
        public Button btn_dis_Connected_Instance;       
        public int algo;
        public Client()
        {
            InitializeComponent();
            _serverIpAddress = GetIpAddress(txtIPAddress.Text);
            _port = GetPort(txtPort.Text);
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;

            frm_Instace_client = this;
            txt_IPAddress_Instance = txtIPAddress;
            txt_Port_Instance = txtPort;
            txt_Status_Instance = txtStatus;
            btn_Connected_Instance = btnConnect;
            btn_dis_Connected_Instance = btnDisconnect;
           // server_side = new Server();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private IPAddress GetIpAddress(string ipAddress)
        {
            IPAddress address = IPAddress.Parse(LOCALHOST);
            try
            {
                if (!IPAddress.TryParse(ipAddress, out address))
                {
                    address = IPAddress.Parse(LOCALHOST);
                }
            }
            catch (Exception ex)
            {
                txtStatus.Text += CRLF + "Invalid IP address - Client will connect to: " + _serverIpAddress.ToString();
                txtStatus.Text += CRLF + ex.ToString();
            }

            return address;

        }
        private int GetPort(string serverPort)
        {

            int port = DEFAULT_PORT;

            try
            {
                if (!Int32.TryParse(serverPort, out port))
                {
                    port = DEFAULT_PORT;
                }
            }
            catch (Exception ex)
            {
                txtStatus.Text += CRLF + "Invalid port value - Client will connect to port: " + port.ToString();
                txtStatus.Text += CRLF + ex.ToString();
            }

            return port;

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnSimpleKey_Click(object sender, EventArgs e)
        {
            algo = 1;
            isButtonClicked = true;
            if (isButtonClicked)
            {
                btnSimpleKey.BackColor = Color.White;
                btnSimpleKey.ForeColor = Color.FromArgb(115, 79, 150);

                btncaesear.BackColor = Color.FromArgb(115, 79, 150); ;
                btncaesear.ForeColor = Color.White;

                btnPlayFair.BackColor = Color.FromArgb(115, 79, 150); ;
                btnPlayFair.ForeColor = Color.White;

                btnHill.BackColor = Color.FromArgb(115, 79, 150); ;
                btnHill.ForeColor = Color.White;

                pnlClient.Controls.Clear();
                SimpleKey simple = new SimpleKey();
                simple.TopLevel = false;
                pnlClient.Controls.Add(simple);
                simple.Show();
            }
            else
            {
                btnSimpleKey.BackColor = Color.FromArgb(123, 90, 255);
                btnSimpleKey.ForeColor = Color.White;
            }
        }

        private void btnPlayFair_Click(object sender, EventArgs e)
        {
            algo = 2;
            isButtonClicked = true;
            if (isButtonClicked)
            {
                btnPlayFair.BackColor = Color.White;
                btnPlayFair.ForeColor = Color.FromArgb(115, 79, 150);

                btncaesear.BackColor = Color.FromArgb(115, 79, 150); ;
                btncaesear.ForeColor = Color.White;

                btnSimpleKey.BackColor = Color.FromArgb(115, 79, 150); ;
                btnSimpleKey.ForeColor = Color.White;

                btnHill.BackColor = Color.FromArgb(115, 79, 150); ;
                btnHill.ForeColor = Color.White;

                pnlClient.Controls.Clear();
                PlayFair playFair = new PlayFair();
                playFair.TopLevel = false;
                pnlClient.Controls.Add(playFair);
                playFair.Show();
            }
            else
            {
                btnPlayFair.BackColor = Color.FromArgb(115, 79, 150);
                btnPlayFair.ForeColor = Color.White;
            }
        }
        private void btnHill_Click(object sender, EventArgs e)
        {
            algo = 3;
            isButtonClicked = true;
            if (isButtonClicked)
            {
                btnHill.BackColor = Color.White;
                btnHill.ForeColor = Color.FromArgb(115, 79, 150);

                btncaesear.BackColor = Color.FromArgb(115, 79, 150); ;
                btncaesear.ForeColor = Color.White;

                btnSimpleKey.BackColor = Color.FromArgb(115, 79, 150); ;
                btnSimpleKey.ForeColor = Color.White;

                btnPlayFair.BackColor = Color.FromArgb(115, 79, 150); ;
                btnPlayFair.ForeColor = Color.White;

                pnlClient.Controls.Clear();
                HillCipher hill = new HillCipher();
                hill.TopLevel = false;
                pnlClient.Controls.Add(hill);
                hill.Show();
            }
            else
            {
                btnHill.BackColor = Color.FromArgb(115, 79, 150);
                btnHill.ForeColor = Color.White;
            }
        }



        /*private void btnSend_Click(object sender, EventArgs e)
        {
            server_side.frm1TOfrm2(cipher_text, Algo, txtkey1.Text);
            server_side.Show();
        }*/

        private void btncaesear_Click(object sender, EventArgs e)
        {
            algo = 0;
            isButtonClicked = true;
            if (isButtonClicked)
            {
                btncaesear.BackColor = Color.White;
                btncaesear.ForeColor = Color.FromArgb(115, 79, 150);

                btnSimpleKey.BackColor = Color.FromArgb(115, 79, 150); ;
                btnSimpleKey.ForeColor = Color.White;

                btnPlayFair.BackColor = Color.FromArgb(115, 79, 150); ;
                btnPlayFair.ForeColor = Color.White;

                btnHill.BackColor = Color.FromArgb(115, 79, 150); ;
                btnHill.ForeColor = Color.White;

                
                //btn.BackColor = SystemColors.Control;
                pnlClient.Controls.Clear();
                CaesearChiper caesear = new CaesearChiper();
                caesear.TopLevel = false;
                pnlClient.Controls.Add(caesear);
                caesear.Show();
            }
            else
            {
                btncaesear.BackColor = Color.FromArgb(115, 79, 150);
                btncaesear.ForeColor = Color.White;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProcessClientTransactions(object tcpClient)
        {
            TcpClient client = (TcpClient)tcpClient;
            
            StreamReader reader = null;
            StreamWriter writer = null;


            try
            {
                reader = new StreamReader(client.GetStream());
                writer = new StreamWriter(client.GetStream());

                // Tell the server we've connected
                writer.WriteLine("Hello from a client! Ready to do your bidding!");
                writer.Flush();

                while (client.Connected)
                {
                    input = reader.ReadLine(); // block here until we receive something from the server.
                    if (input == null)
                    {
                        
                        DisconnectFromServer();
                    }
                    else
                    {
                        switch (input)
                        {

                            default:
                                {
                                    
                                   // MessageBox.Show(txtStatus.Text);
                                     txtStatus.InvokeEx(stb => stb.Text += CRLF + " Received from Server: " + input);

                                   
                                    
                                    break;
                                }
                        } // end switch
                    } // end if/else


                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                txtStatus.InvokeEx(stb => stb.Text += CRLF + "Problem communicating with the server. Connection may have been intentionally disconnected.");
                //_statusTextBox.InvokeEx(stb => stb.Text += CRLF + ex.ToString());
               
            }

            btnDisconnect.InvokeEx(dcb => dcb.Enabled = false);
            btnConnect.InvokeEx(cb => cb.Enabled = true);
            txtStatus.InvokeEx(stb => stb.Text = string.Empty);


        }

        private void DisconnectFromServer()
        {

            try
            {
                _client.Close();
                txtStatus.InvokeEx(stb => stb.Text += CRLF + "Disconnected from the server!");
                btnDisconnect.InvokeEx(db => db.Enabled = false);
                btnConnect.InvokeEx(cb => cb.Enabled = true);
                //btnSendCommand.InvokeEx(scb => scb.Enabled = false);
                txtStatus.InvokeEx(stb => stb.Text = string.Empty);
            }
            catch (Exception ex)
            {
                txtStatus.InvokeEx(stb => stb.Text += CRLF + "Problem disconnecting from the server.");
                txtStatus.InvokeEx(stb => stb.Text += CRLF + ex.ToString());
            }

            txtStatus.InvokeEx(stb => stb.Text = string.Empty);

        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
           // flag_connect = true;
            try
            {
                // MessageBox.Show(txtIPAddress.Text);
                _serverIpAddress = GetIpAddress(txtIPAddress.Text);
                _port = GetPort(txtPort.Text);

                _client = new TcpClient(_serverIpAddress.ToString(), _port);
                Thread t = new Thread(ProcessClientTransactions);
                t.IsBackground = true;
                t.Start(_client);

                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
               
                
            }
            catch (Exception ex)
            {
                txtStatus.Text += CRLF + "Problem connecting to server.";
                txtStatus.Text += CRLF + ex.ToString();
            }
            btnConnect.BackColor = Color.FromArgb(12, 193, 51);
            btnConnect.ForeColor = Color.Black;

            btnDisconnect.BackColor = Color.White;
            btnDisconnect.ForeColor = Color.FromArgb(123,90,255);
            // pbxConnect.Load(@"D:\admin\Dev\Cyper-Security-proj-23\client-server\client-server-cyper-security\client-server\Resources\connect.png");
            //img1 = new Bitmap(Properties.Resources.connect);
            //pbxConnect.Image = Image.FromFile(img1);
            Image myImage = global::client_server.Properties.Resources.connect;
            pbxConnect.Image = myImage;


        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DisconnectFromServer();
            btnDisconnect.BackColor = Color.FromArgb(242, 12, 12);
            btnDisconnect.ForeColor = Color.White;

            btnConnect.BackColor = Color.FromArgb(115, 79, 150);
            btnConnect.ForeColor = Color.White;
        }

        private void btn_back_connect_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Client client = new Client();
            client.Closed += (s, args) => this.Close();
            client.Show();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            /*// pbxConnect.Visible = false;
            
            if (flag_connect == true)
            {
                //pbxConnect.Load(@"D:\admin\Dev\Cyper-Security-proj-23\client-server\client-server-cyper-security\client-server\Resources\connect.png");
                //pbxConnect.Image = 
                MessageBox.Show("Rama");
                pbxConnect.Image = Image.FromFile(@"D:\admin\Dev\Cyper-Security-proj-23\client-server\client-server-cyper-security\client-server\Resources\connect.png");
                
            }
            else
            {
                //pbxConnect.Load(@"");
            }*/

        }

        private void pbxConnect_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //if (flag_connect == true)
            //{
                //MessageBox.Show("Rama");
                //pbxConnect.Load(@"D:\admin\Dev\Cyper-Security-proj-23\client-server\client-server-cyper-security\client-server\Resources\connect.png");
                //pbxConnect.Image = 

                //pbxConnect.Image = Image.FromFile(@"D:\admin\Dev\Cyper-Security-proj-23\client-server\client-server-cyper-security\client-server\Resources\connect.png");
            //}
            /*else
            {
                //pbxConnect.Load(@"");
            }*/
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            string[] words;
            if (input.Contains("-"))
            {
                words = input.Split(new[] { "-" }, StringSplitOptions.RemoveEmptyEntries);

            }
            else
            {
                words = null;
            }
            if (words != null && words[0] == "S1")
            {
                MessageBox.Show(input);
                input = "";
                if (words[2] == "0")
                {
                    btncaesear_Click(sender, e);
                    CaesearChiper.frm_Instance_caesear.txt_Instance_Cipher.Text = words[1];
                    CaesearChiper.frm_Instance_caesear.txt_Instance_Key.Text = words[3];
                }
                else if (words[2] == "1")
                {
                    btnSimpleKey_Click(sender, e);
                    SimpleKey.frm_simple_Instance.txt_Instance_Cipher.Text = words[1];
                    SimpleKey.frm_simple_Instance.txt_Instance_Key.Text = words[3];
                }
                else if (words[2] == "2")
                {
                    btnPlayFair_Click(sender, e);
                    PlayFair.frm_play_flair_Instance.txt_Instance_Cipher.Text = words[1];
                    PlayFair.frm_play_flair_Instance.txt_Instance_Key.Text = words[3];
                }
                else if (words[2] == "3")
                {
                    btnHill_Click(sender, e);
                    HillCipher.frm_Hill_Instance.txt_Instance_Cipher.Text = words[1];
                    HillCipher.frm_Hill_Instance.txt_Instance_Key_1.Text = words[3];
                    HillCipher.frm_Hill_Instance.txt_Instance_Key_2.Text = words[4];
                    HillCipher.frm_Hill_Instance.txt_Instance_Key_3.Text = words[5];
                    HillCipher.frm_Hill_Instance.txt_Instance_Key_4.Text = words[6];
                }
                //MessageBox.Show(input);
            }
        }
    }
}
