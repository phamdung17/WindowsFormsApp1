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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // bấn button toolStripStatusLabel4 hiển thi hinh ảnh  và chữ
            toolStripStatusLabel4.Text = "đã bấm button";
            toolStripStatusLabel4.Image = Image.FromFile("D:\\DaTaCode\\source_code\\LapTrinhTrenMTW\\jmg\\anh1.PNG");
        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
