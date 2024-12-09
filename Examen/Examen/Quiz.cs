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
    internal class Quiz
    {
        private string name_quiz;

        [DataMember]
        public string? NameQuiz
        { 
            get
            {
                return name_quiz;
            }
            set
            {
                string prohib_symbols = "\\/:*?\"<>| ";

                name_quiz = new string(value?.Where(q => !prohib_symbols.Contains(q)).ToArray());
            }
        }
        public Quiz(string name_quiz)
        {
            NameQuiz = name_quiz;
        }

    }
}
