using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.services;
using System.Windows.Forms;

namespace GUI
{
    public partial class Game : Form
    {
        public string Category { get; set; }
        public Game(Question question, string category = "", int round = 0)
        {
            InitializeComponent();
            Construct(question);
            RenderRound(round);
            this.Category = category;
        }

        private void Construct(Question question)
        {
            if (question.question == null)
            {
                MessageBoxService.ShowMessage("Ocorreu um erro!", "Não existem questões no banco de dados dessa categoria\nClique em OK para adicionar");
                this.Hide();
                Questions questions = new Questions();
                questions.Closed += (s, args) => this.Close();
                questions.Show();
                return;
            }
            mainLabel.Text = question.question;
            string[] Incorrect_Answers = question.incorrect_answers.Split('/');
            MountAlternatives(question, Incorrect_Answers);
            InitButtonsEvents();
        }

        private void ButtonsHandler(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button == null) return;

            // Correct alternative
            if (button.Tag != null)
            {
                button.BackColor = Color.Green;
                MessageBoxService.ShowMessage("Parabéns!", "Parabéns!\nAlternativa CORRETA!");
                NextLevel(int.Parse(lblRound.Text));
                return;
            }

            // Incorrect
            button.BackColor = Color.Red;
            MessageBoxService.ShowMessage("Você Perdeu!", $"Fim de jogo!\nAlternativa INCORRETA!\nClique em OK para jogar novamente!\nVocê fez {lblRound.Text} pontos!");
            GameOver();

        }

        private void NextLevel(int round)
        {
            Question q = QuestionService.GetRandomQuestion();
            this.Hide();
            Game game = new Game(q, this.Category, round);
            game.Closed += (s, args) => this.Close();
            game.Show();
        }

        private void MountAlternatives(Question question, string[] incorrect_answers)
        {
            switch (RandomNumbers.Random(4))
            {
                case 0:
                    bttn1.Text = question.correct_answer;
                    bttn1.Tag = "Correct";
                    bttn2.Text = incorrect_answers[0];
                    bttn3.Text = incorrect_answers[1];
                    bttn4.Text = incorrect_answers[2];
                    break;

                case 1:
                    bttn2.Text = question.correct_answer;
                    bttn2.Tag = "Correct";
                    bttn3.Text = incorrect_answers[1];
                    bttn1.Text = incorrect_answers[0];
                    bttn4.Text = incorrect_answers[2];
                    break;

                case 2:
                    bttn3.Text = question.correct_answer;
                    bttn3.Tag = "Correct";
                    bttn2.Text = incorrect_answers[2];
                    bttn1.Text = incorrect_answers[0];
                    bttn4.Text = incorrect_answers[1];
                    break;

                case 3:
                    bttn4.Text = question.correct_answer;
                    bttn4.Tag = "Correct";
                    bttn3.Text = incorrect_answers[2];
                    bttn1.Text = incorrect_answers[0];
                    bttn2.Text = incorrect_answers[1];
                    break;
            }
        }

        private void GameOver()
        {
            this.Hide();
            EscolherCategoria aux = new EscolherCategoria();
            aux.Closed += (s, args) => this.Close();
            aux.Show();
        }


        private void BttnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BttnClose_Click(object sender, EventArgs e)
        {
            Game.ActiveForm.Close();
        }

        private void InitButtonsEvents()
        {
            bttn1.Click += ButtonsHandler;
            bttn2.Click += ButtonsHandler;
            bttn3.Click += ButtonsHandler;
            bttn4.Click += ButtonsHandler;
        }

        private void RenderRound(int round)
        {
            round++;
            lblRound.Text = round.ToString();
        }
    }
}
