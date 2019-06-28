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
            string AltB = txtAlternativeC.Text;
            string AltC = txtAlternativeC.Text;
            string AltD = txtAlternativeC.Text;
            string category = "Categoria daora";
            string incorrect_answers = $"{correct_answer}/{AltB}/{AltC}/{AltD}";

            Question Question = new Question(question, correct_answer, category, incorrect_answers);

            QuestionService.PostQuestion(Question);

            MessageBoxService.ShowMessage("Questão cadastrada", "Parabéns, sua questão foi cadastrada com sucesso!");
        }
    }
}
