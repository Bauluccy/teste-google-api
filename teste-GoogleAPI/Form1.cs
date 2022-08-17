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
using Firebase.Storage;
using System.IO;

namespace teste_GoogleAPI
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Selecione o arquivo alvo";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var stream = File.Open(textBox1.Text, FileMode.Open);

            FileInfo fileinfo = new FileInfo(openFileDialog1.FileName);

            var task = new FirebaseStorage("teste-api-6d2b0.appspot.com")
                .Child(fileinfo.Name)
                .PutAsync(stream);

            task.Progress.ProgressChanged += (s, f) => Console.WriteLine($"Progress: {f.Percentage} %");

            MessageBox.Show("Sucesso ao enviar o arquivo!!!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBox1.SelectedItem.Equals("Manualmente"))
            {
                label4.Enabled = true;
                dateTimePicker1.Enabled = true;
            }
            else
            {
                label4.Enabled = false;
                dateTimePicker1.Enabled = false;
            }
        }
    }
}
