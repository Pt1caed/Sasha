using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class WrongOrCorrectAnswer
    {
        public WrongOrCorrectAnswer(string answer, bool iscorrect) { Answer = answer; IsCorrect = iscorrect; }

        public string? Answer {  get; set; }
        public bool IsCorrect {  get; set; }
    }
}
