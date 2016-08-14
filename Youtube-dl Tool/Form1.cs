using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube_dl_Tool
{
    // TODO: Terminalden çalışma komutu eklenecek...
    public partial class Form1 : Form
    {
        configuration config = new configuration();
        controller control = new controller();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("deneme");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            config.URL = textBoxURL.Text;

            control.startYoutubeDl(config.URL);
            
        }
    }
}
