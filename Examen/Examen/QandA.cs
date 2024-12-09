using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    [Serializable]
    [DataContract]
    internal class QandA
    {
        public QandA(string question, List<string> wrong_answer, List<string> correct_answer) 
        { 
            Question = question; 
            WrongAnswers = wrong_answer; 
            CorrectAnswers = correct_answer;  
        }
        [DataMember]
        public string? Question { get; set; }
        [DataMember]
        public List<string> WrongAnswers { get; set; }
        [DataMember]
        public List<string> CorrectAnswers {  get; set; }

    }
}
