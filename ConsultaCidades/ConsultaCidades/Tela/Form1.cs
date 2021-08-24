using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ConsultaCidades
{
    public partial class telaMenu : Form
    {
        public telaMenu()
        {
            InitializeComponent();
            desativarCampos();
        }
        public void desativarCampos()
        {
            lbend.Visible = false;
            lbUf.Visible = false;
            lbLogradouro.Visible = false;
            lbBairro.Visible = false;
            lbCidade.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
        }
        public void ativarCampos()
        {
            lbend.Visible = true;
            lbUf.Visible = true;
            lbLogradouro.Visible = true;
            lbBairro.Visible = true;
            lbCidade.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
        }
        private void btCodigoIbge_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + txtCep.Text + "/json/");
            request.AllowAutoRedirect = false;

            try
            {
                HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

                if (ChecaServidor.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show("Servidor indisponível, tente novamente!");
                    return; // Sai da rotina
                }
                using (Stream webStream = ChecaServidor.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            string response = responseReader.ReadToEnd();
                            response = Regex.Replace(response, "[{},]", string.Empty);
                            response = response.Replace("\"", "");

                            String[] substrings = response.Split('\n');

                            int cont = 0;

                            txtCep.Enabled = false;
                            btCodigoIbge.Enabled = false;

                            foreach (var substring in substrings)
                            {
                                if (cont == 1)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    if (valor[0] == "  erro")
                                    {
                                        MessageBox.Show("CEP não encontrado");
                                        txtCep.Focus();
                                        return;
                                    }
                                }
                                //Logradouro
                                if (cont == 2)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    lbLogradouro.Text = valor[1];
                                }

                                //Bairro
                                if (cont == 4)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    lbBairro.Text = valor[1];
                                }

                                //Localidade (Cidade)
                                if (cont == 5)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    lbCidade.Text = valor[1];
                                }
                                //Estado (UF)
                                if (cont == 6)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    lbUf.Text = valor[1];
                                }
                                cont++;
                                ativarCampos();
                            }
                            txtCep.Enabled = true;
                            btCodigoIbge.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("O CEP digitado está no formato inválido!");
            }        
        }
        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void lbCidade_Click(object sender, EventArgs e)
        {
        }

        private void btCodigoIbge_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbUf.Visible == false)
            {
                txtCep.Enabled = true;
                btCodigoIbge.Enabled = true;
            }    
        }
    }  
}
