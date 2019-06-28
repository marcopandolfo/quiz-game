using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Question
    {
        public int id { get; set; }
        public string question { get; set; }
        public string correct_answer { get; set; }
        public string category { get; set; }
        public string incorrect_answers { get; set; }

        public Question(string question, string corret_answer, string category, string incorrect_answers)
        {
            this.question = question;
            this.correct_answer = corret_answer;
            this.category = category;
            this.incorrect_answers = incorrect_answers;
        }
    }
}
