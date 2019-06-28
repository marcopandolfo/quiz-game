using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Question
    {
        public string Name { get; set; }
        public string Corret_Answer { get; set; }
        public string Incorrect_Answer1 { get; set; }
        public string Incorrect_Answer2 { get; set; }
        public string Incorrect_Answer3 { get; set; }

        public Question(string name, string corret_Answer, string incorrect_Answer1, string incorrect_Answer2, string incorrect_Answer3)
        {
            this.Name = name;
            this.Corret_Answer = corret_Answer;
            this.Incorrect_Answer1 = incorrect_Answer1;
            this.Incorrect_Answer2 = incorrect_Answer2;
            this.Incorrect_Answer3 = incorrect_Answer3;
        }
    }
}
