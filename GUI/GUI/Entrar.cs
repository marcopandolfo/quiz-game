using GUI.models;
using GUI.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Entrar : Form
    {
        public Entrar()
        {
            InitializeComponent();
        }

        private void BttnClose_Click(object sender, EventArgs e)
        {
            Entrar.ActiveForm.Close();
        }

        private void BttnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            string email = txtLogin.Text;
            string password = txtPassword.Text;

            if (ValidaInputs(email, password)) return;

            User user = UserService.SearchUser(email, password);

            if(user == null)
            {
                InvalidLogin();
                return;
            }

            this.Hide();
            EscolherCategoria aux = new EscolherCategoria();
            aux.Closed += (s, args) => this.Close();
            aux.Show();

        }

        private void InvalidLogin()
        {
            MessageBoxService.ShowMessage("Login inválido", "Usuario não encontrado.\nTente novamente");
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtLogin.Clear();
            txtPassword.Clear();
        }

        private bool ValidaInputs(string email, string password)
        {
            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password))
            {
                MessageBoxService.ShowMessage("Formato inválido", "Você deve preencher todos os campos");
                return true;
            }

            if (!email.Contains("@"))
            {
                MessageBoxService.ShowMessage("Formato inválido", "Formato de email inválido");
                return true;
            }

            return false;
        }

        private void BttnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrar regisrar = new Registrar();
            regisrar.Closed += (s, args) => this.Close();
            regisrar.Show();
        }
    }
}
