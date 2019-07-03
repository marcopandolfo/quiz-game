using GUI.services;
using GUI.util;
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
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
        }

        private void BttnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BttnClose_Click(object sender, EventArgs e)
        {
            Questions.ActiveForm.Close();
        }

        private void bttnCadastrar_Click(object sender, EventArgs e)
        {
            string question = txtBoxQuestion.Text.Replace("\n", String.Empty).Replace("\r", String.Empty).Replace("\t", String.Empty);
            string correct_answer = txtAlternativeA.Text;
            string AltB = txtAlternativeB.Text;
            string AltC = txtAlternativeC.Text;
            string AltD = txtAlternativeD.Text;
            string category = comboCategory.Text;

            if (ValidaInputs(question, correct_answer, AltB, AltC, AltD, category))
            {
                MessageBoxService.ShowMessage("Houve um erro", "Nenhum dos campos podem estar vazios!");
                return;
            }

            string incorrect_answers = $"{AltB}/{AltC}/{AltD}";

            Question Question = new Question(question, correct_answer, category, incorrect_answers);

            QuestionService.SaveQuestion(Question);

            MessageBoxService.ShowMessage("Questão cadastrada", "Parabéns, sua questão foi cadastrada com sucesso!");
        }

        // Verifica se algum input é null ou empty e retorna true se for
        private bool ValidaInputs(string question, string correct_answer, string altB, string altC, string altD, string category)
        {
            return String.IsNullOrEmpty(question) || String.IsNullOrEmpty(correct_answer) || String.IsNullOrEmpty(altB) || String.IsNullOrEmpty(altC) || String.IsNullOrEmpty(altD) || String.IsNullOrEmpty(category);
        }
    }
}
