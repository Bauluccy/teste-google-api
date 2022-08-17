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
using FireSharp.Response;
using FireSharp.Interfaces;

namespace teste_GoogleAPI
{
    public partial class TelaCadastro : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "gs://teste-api-6d2b0.appspot.com"
        };

        IFirebaseClient client;
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {

            //FirebaseResponse response = client.Get("Users/");
            //Dictionary<string, register> verificarUsuario = response.ResultAs<Dictionary<string, register>>();
            //foreach (var verificar in verificarUsuario)
            //{
            //    string userVerify = verificar.Value.usuario;
            //    if (txLoginCadastro.Text == userVerify)
            //    {
            //        MessageBox.Show("Login já existente!");
            //        break;
            //    }
            //}

            if (string.IsNullOrEmpty(txLoginCadastro.Text) || string.IsNullOrEmpty(txSenhaCadastro.Text) || string.IsNullOrEmpty(txConfirmaCadastro.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!");
            }
            else
            {
                var register = new register
                {

                    usuario = txLoginCadastro.Text,
                    senha = txSenhaCadastro.Text,
                    confirma = txConfirmaCadastro.Text

                };

                FirebaseResponse response = client.Set("Users/" + txLoginCadastro.Text, register);

            }
        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {
            try
            {
                //also this one.
                client = new FireSharp.FirebaseClient(config);

                if (client != null)
                {
                    //this.CenterToScreen();
                }

            }
            catch
            {
                MessageBox.Show("Falha na conexão!!!");
            }
        }

        private void txLoginCadastro_Leave(object sender, EventArgs e)
        {
            if (txLoginCadastro.Text.Equals(""))
            {
                txLoginCadastro.Text = "Login";
                txLoginCadastro.ForeColor = Color.Silver;
            }
        }

        private void txLoginCadastro_Enter(object sender, EventArgs e)
        {
            if (txLoginCadastro.Text.Equals("Login"))
            {
                txLoginCadastro.Text = "";
                txLoginCadastro.ForeColor = Color.Black;
            }
        }

        private void txSenhaCadastro_Enter(object sender, EventArgs e)
        {
            if (txSenhaCadastro.Text.Equals("Senha"))
            {
                txSenhaCadastro.Text = "";
                txSenhaCadastro.ForeColor = Color.Black;
            }
        }

        private void txSenhaCadastro_Leave(object sender, EventArgs e)
        {
            if (txSenhaCadastro.Text.Equals(""))
            {
                txSenhaCadastro.Text = "Senha";
                txSenhaCadastro.ForeColor = Color.Silver;
            }
        }

        private void txConfirmaCadastro_Enter(object sender, EventArgs e)
        {
            if (txConfirmaCadastro.Text.Equals("Confirmar"))
            {
                txConfirmaCadastro.Text = "";
                txConfirmaCadastro.ForeColor = Color.Black;
            }
        }

        private void txConfirmaCadastro_Leave(object sender, EventArgs e)
        {
            if (txConfirmaCadastro.Text.Equals(""))
            {
                txConfirmaCadastro.Text = "Confirmar";
                txConfirmaCadastro.ForeColor = Color.Silver;
            }
        }
    }
}
