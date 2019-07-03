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
            Game game = new Game(question);
            game.Show();
            this.Visible = this.Enabled = false;
        }

        // História
        private void bttnCategoryA_Click(object sender, EventArgs e)
        {

        }
    }
}
