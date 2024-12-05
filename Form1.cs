using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text=DateTime.Now.Hour.ToString();
            label4.Text=DateTime.Now.Minute.ToString();
            if(comboBox2.Text==label4.Text && comboBox1.Text==label3.Text )
            {
                timer1.Enabled = false;
                axWindowsMediaPlayer1.URL = "C:\\Users\\abdul\\Downloads\\100yil_marsi_Kirac.mp3";
                MessageBox.Show("UYANMA ZAMANI");
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        int i, j;
        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0;i<24;i++)
            {
                comboBox1.Items.Add(i);
            }
            for(j=0;j<60;j++)
            {
                comboBox2.Items.Add(j);
            }
        }
    }
}
