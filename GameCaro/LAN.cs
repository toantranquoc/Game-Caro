using ConnectionNextwork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{

    public partial class LAN : Form
    {
        private SocketManager socket;
        private CaroChess caroChess;
        private Graphics gr;
        public LAN()
        {
            InitializeComponent();
            caroChess = new CaroChess();
            caroChess.KhoiTaoMangOCo();
            gr = pn.CreateGraphics();
            socket = new SocketManager();
        }


        private void pn_Paint(object sender, PaintEventArgs e)
        {
            caroChess.VeBanCo(gr);
            caroChess.VeLaiBanCo(gr);
        }
        bool t = false;
        int x, y;
        private void pn_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            // Đánh trên mạng LAN
            if (t)
            {
                if (caroChess.KiemTraOCo(x, y) == true)
                {
                    return;
                }
                if (socket.isServer)
                {
                    if (!caroChess.SanSang1) return;
                    if (caroChess.DanhCoLAN(e.X, e.Y, gr, 1))
                    {
                        if (caroChess.KtChienThang())
                            caroChess.KetThucGame();
                    }
                    pn.Enabled = false;
                    socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", new Point(x, y), 1));
                    Listen();

                }
                else
                {
                    if (!caroChess.SanSang1) return;
                    if (caroChess.DanhCoLAN(e.X, e.Y, gr, 2))
                    {
                        if (caroChess.KtChienThang())
                            caroChess.KetThucGame();
                    }

                    pn.Enabled = false;
                    socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", new Point(x, y), 2));
                    Listen();
                }
                return;
            }

        }

        void DanhCoTrenBan2(Point p, int n)
        {
            if (!caroChess.SanSang1) return;
            if (caroChess.DanhCoLAN(p.X, p.Y, gr, n))
            {

                if (caroChess.KtChienThang())
                    caroChess.KetThucGame();

            }
            pn.Enabled = true;

        }
        void Message(string s)
        {
            txtChat.AppendText(s);
            txtChat.AppendText(Environment.NewLine);
            Listen();
        }
        private void LAN_Shown(object sender, EventArgs e)
        {
            txtIP.Text = socket.GetLocalIPv4(System.Net.NetworkInformation.NetworkInterfaceType.Wireless80211);
            if (string.IsNullOrEmpty(txtIP.Text))
            {
                txtIP.Text = socket.GetLocalIPv4(System.Net.NetworkInformation.NetworkInterfaceType.Wireless80211);
            }
        }
        void Listen()
        {

            Thread listenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive();
                    ProcessData(data);
                }
                catch
                {

                }
            });

            listenThread.IsBackground = true;
            listenThread.Start();

        }
        void KetNoi(string s)
        {
            MessageBox.Show(s, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void NewGame()
        {
            gr.Clear(pn.BackColor);
            caroChess.New(gr);
        }
        void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.NOTIFY:
                    MessageBox.Show(data.Message);
                    break;
                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        pn.Enabled = false;
                    }));
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        pn.Enabled = true;
                        DanhCoTrenBan2(data.Point, data.SoHuu);
                    }));
                    break;
                case (int)SocketCommand.QUIT:
                    MessageBox.Show("Người chơi đã thoát !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)SocketCommand.MESSAGE:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        Message(data.Message);
                    }));
                    break;
                case (int)SocketCommand.CONNECT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        KetNoi(data.Message);
                    }));
                    break;
                default:
                    break;
            }
            Listen();

        }

        private void LAN_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtChat.AppendText("You: " + txtSend.Text);
            txtChat.AppendText(Environment.NewLine);
            socket.Send(new SocketData((int)SocketCommand.MESSAGE, "Friend: " + txtSend.Text.ToString(), new Point()));
            Listen();
            txtSend.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnLAN_Click(object sender, EventArgs e)
        {
            t = true;
            gr.Clear(pn.BackColor);
            caroChess.StarPlayervsPlayerLAN(gr);
            socket.IP = txtIP.Text;

            if (!socket.ConnectServer())
            {
                socket.isServer = true;
                pn.Enabled = true;
                socket.CreateServer();
                MessageBox.Show("Bạn đang là Sever", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Properties.Settings.Default.sever = true;
            }
            else
            {
                try
                {
                    socket.isServer = false;
                    pn.Enabled = false;
                    //socket.Send(new SocketData((int)SocketCommand.CONNECT, "Kết nối thành công!", new Point()));
                    MessageBox.Show("Kết nối thành công! Bạn đang là Client", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Properties.Settings.Default.client = true;
                  
                    Listen();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kết nối thất bại!" + "\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }

}
