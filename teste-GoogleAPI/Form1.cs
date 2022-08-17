using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace teste_GoogleAPI
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig();
        public Form1()
        {
            InitializeComponent();
        }
        IFirebaseConfig client;
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Selecione o arquivo alvo";
            openFileDialog1.ShowDialog();

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }
    }
}
