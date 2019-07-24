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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void BttnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BttnClose_Click(object sender, EventArgs e)
        {
            Registrar.ActiveForm.Close();
        }

        private void BttnRegistrar_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Email = txtEmail.Text;
            string Password = txtPassword.Text;
            string ConfirmPassword = txtConfirmPassword.Text;

            if (ValidateInputs(Username, Email, Password, ConfirmPassword)) return;

            UserService.SaveUser(new User(Username, Email, Password));

            MessageBoxService.ShowMessage("Parabéns", "Cadastro efetuado com sucesso!\n\nClique em OK para entrar");

            this.Hide();
            Entrar entrar = new Entrar();
            entrar.Closed += (s, args) => this.Close();
            entrar.Show();


        }

        private bool ValidateEmail(string email)
        {
            return !email.Contains("@");
        }

        private bool ValidatePassword(string password, string confirmPassword)
        {
            return (password != confirmPassword);
        }

        // Valida os inputs
        private bool ValidateInputs(string nome, string email, string password, string confirmPassword)
        {
            if (String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(confirmPassword))
            {
                MessageBoxService.ShowMessage("Erro ao registrar", "Você deve preencher todos os campos");
                return true;
            }

            if (ValidateEmail(email))
            {
                MessageBoxService.ShowMessage("Erro ao registrar", "Formato de email invalido");
                return true;
            }

            if (ValidatePassword(password, confirmPassword))
            {
                MessageBoxService.ShowMessage("Erro ao registrar", "Suas senhas não são iguais");
                return true;
            }

            return false;
        }
    }
}
