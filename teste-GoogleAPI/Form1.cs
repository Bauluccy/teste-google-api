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
        IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "teste-api-6d2b0.appspot.com/"
        };
            
        public Form1()
        {
            InitializeComponent();
        }
        
        IFirebaseClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            txSenha.PasswordChar = '*';

            try
            {
                client = new FireSharp.FirebaseClient(config);

                if(client != null)
                {
                    
                }
            }
            catch
            {
                MessageBox.Show("Falha no login");
            }
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBox2.SelectedItem.Equals("Regra...") || !comboBox2.SelectedItem.Equals(""))
            {

            }
            else
            {
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                progressBar1.Visible = false;
            }

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txLogin.Text.Equals("Login"))
            {
                txLogin.Text = "";
                txLogin.ForeColor = Color.Black;

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txLogin.Text.Equals(""))
            {
                txLogin.Text = "Login";
                txLogin.ForeColor = Color.Silver;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (txSenha.Text.Equals("Senha"))
            {
                txSenha.Text = "";
                txSenha.ForeColor = Color.Black;
            }

            
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (txSenha.Text.Equals(""))
            {
                textBox1.PasswordChar = '\0';

                txSenha.Text = "Senha";
                txSenha.ForeColor = Color.Silver;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        public static string passeUsuario;

        private void button3_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txLogin.Text) || string.IsNullOrEmpty(txSenha.Text))
            {
                MessageBox.Show("Por favor, insira o usuario e a senha!");
            }
            else
            {
                FirebaseResponse response = client.Get("Users/");
                Dictionary<string, register> result = response.ResultAs<Dictionary<string, register>>();

                foreach(var get in result)
                {
                    string loginResultado = get.Value.usuario;
                    string senhaResultado = get.Value.senha;

                    if(txLogin.Text == loginResultado)
                    {
                        if(txSenha.Text == senhaResultado)
                        {
                            MessageBox.Show("Logado com sucesso " + txLogin + "!!!");
                            passeUsuario = txLogin.Text;

                            txLogin.Enabled = false;
                            txSenha.Enabled = false;
                            button3.Enabled = false;

                            button5.Enabled = true;
                            button5.Visible = true;

                            label9.Text = "Logado como: " +txLogin;
                            label9.Visible = true;
                        }
                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
