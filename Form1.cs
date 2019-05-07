using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    using System.Text;
    using System.Net;
    using System.Net.Sockets;
    using System.IO;

    public partial class Form1 : Form
    {
        public static string pwd;
        public static int i,j,k;
        public int x1, y1, x2, y2, x3, y3, x4, y4, x5, y5;

       

        public static TcpClient tcpc;
        public static string popserver;
        public static StreamReader sr;
        public static string strRet;
        public static string[] arrRet;
       // public Label[] arrLabel = new Label[4];
        public TextBox[] arrTextBox;

        private void button2_Click(object sender, EventArgs e)
        {
            string user = textBox2.Text.ToString();
            string pass = textBox3.Text.ToString();
            pwd = pass;
            popserver = textBox1.Text.ToString();
            tcpc = new TcpClient();
            tcpc.Connect(popserver, 110);
            sr = new StreamReader(tcpc.GetStream(), Encoding.Default);
           

        }
        public Form1()
        {
        InitializeComponent();
            this.Click += new EventHandler(Form1_Click);

        }
        void Form1_Click(object sender,EventArgs e)
        {
            MessageBox.Show(((MouseEventArgs)e).Location .ToString ()  );
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = 20; y1 = 20;
            label1.Location = new Point(x1, y1);
            label1.Text = "Server Address:";
            label1.Width = 100;
            label1.Height = 30;

            x1 += 100;
            textBox1.Location = new Point(x1, y1);
            textBox1.Text = "";
            textBox1.Width = 100;
            textBox1.Height = 30;

            x2 = 20;y2 = 50;
            label2.Location = new Point(x2, y2);
            label2.Text = "User ID:";
            label2.Width = 100;
            label2.Height = 30;

            x2 += 100;
            textBox2.Location = new Point(x2, y2);
            textBox2.Text = "";
            textBox2.Width = 100;
            textBox2.Height = 30;

            x3 = 20;y3 = 80;
            label3.Location = new Point(x3, y3);
            label3.Text = "Password:";
            label3.Width = 100;
            label3.Height = 30;

            x3 += 100;
            textBox3.Location = new Point(x3, y3);
            textBox3.Text = "";
            textBox3.Width = 100;
            textBox3.Height = 30;

            x4 = 20;y4 = 110;
            label4.Location = new Point(x4, y4);
            label4.Text = "Read Operation:";
            label4.Width = 100;
            label4.Height = 30;

            x4 += 100;
            textBox4.Location = new Point(x4, y4);
            textBox4.Text = "";
            textBox4.Width = 100;
            textBox4.Height = 30;

            Label[] arrlabel = { label1, label2, label3, label4 };
             for (i = 0; i <3 ; i++) 
            {
                
                
            }

            x5 = 20;y5 = 130;
            arrlabel[0].Location = new Point(x5, y5);
            //var Var3 = Convert.ToInt16(Console.ReadLine());
            
        }
    }
}
