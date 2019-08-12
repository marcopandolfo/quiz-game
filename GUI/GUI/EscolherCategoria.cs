using GUI.services;
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
    public partial class EscolherCategoria : Form
    {
        public EscolherCategoria()
        {
            InitializeComponent();
        }

        // Todas
        private void bttnCategoryAll_Click(object sender, EventArgs e)
        {
            Question question = QuestionService.GetRandomQuestion();
            if (!VerifyQuestion(question)) return;

            this.Hide();
            Game game = new Game(question);
            game.Closed += (s, args) => this.Close();
            game.Show();
        }

        // História
        private void bttnCategoryA_Click(object sender, EventArgs e)
        {
            Question question = QuestionService.GetRandomQuestion("Historia");
            if (!VerifyQuestion(question)) return;
            Game game = new Game(question, "Historia");
            game.Show();
            this.Visible = this.Enabled = false;
        }

        // Geografia
        private void BttnCategoryC_Click(object sender, EventArgs e)
        {
            Question question = QuestionService.GetRandomQuestion("Geografia");
            if (!VerifyQuestion(question)) return;
            Game game = new Game(question, "Geografia");
            game.Show();
            this.Visible = this.Enabled = false;
        }

        // Ciência e Natureza
        private void BttnCategoryD_Click(object sender, EventArgs e)
        {
            Question question = QuestionService.GetRandomQuestion("Ciencia e Natureza");
            if (!VerifyQuestion(question)) return;
            Game game = new Game(question, "Ciencia e Natureza");
            game.Show();
            this.Visible = this.Enabled = false;
        }

        // Entreterimento
        private void BttnCategoryE_Click(object sender, EventArgs e)
        {
            Question question = QuestionService.GetRandomQuestion("Entreterimento");
            if (!VerifyQuestion(question)) return;
            Game game = new Game(question, "Entreterimento");
            game.Show();
            this.Visible = this.Enabled = false;
        }

        // Arte e Literatura
        private void BttnCategoryB_Click(object sender, EventArgs e)
        {
            Question question = QuestionService.GetRandomQuestion("Arte e Literatura");
            if (!VerifyQuestion(question)) return;
            Game game = new Game(question, "Arte e Literatura");
            game.Show();
            this.Visible = this.Enabled = false;
        }

        private void BttnClose_Click(object sender, EventArgs e)
        {
            EscolherCategoria.ActiveForm.Close();
        }

        private void BttnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool VerifyQuestion(Question question)
        {
            if (question.question == null)
            {
                MessageBoxService.ShowMessage("Ocorreu um erro!", "Não existem questões no banco de dados dessa categoria\nClique em OK para adicionar");
                this.Hide();
                Questions questions = new Questions();
                questions.Closed += (s, args) => this.Close();
                questions.Show();
                return false;
            }

            return true;
        }
    }
}
