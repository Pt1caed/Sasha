using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    [Serializable]
    [DataContract]
    internal class QuizeResult
    {
        public QuizeResult(string name_quiz, string name_user, int max_points, double points, DateOnly date)
        {
            NameQuiz = name_quiz;
            NameUser = name_user;
            MaxPoints = max_points;
            Points = points;
            this.date = date;
        }
        private DateOnly date;
        private double points;
        
        [DataMember]
        public string NameUser { get; set; }

        [DataMember]
        public string NameQuiz { get; set; }

        [DataMember]
        public double Points
        {
            get
            {
                return points;
            }
            set
            {
                if(value > MaxPoints)
                {
                    points = MaxPoints;
                }
                else
                {
                    points = value;
                }
            }
        }

        [DataMember]
        public int MaxPoints {  get; set; }

        [DataMember]
        public string Date
        {
            get
            {
                return date.ToString("yyyy-MM-dd");
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    date = DateOnly.Parse(value);
                }
                else
                {
                    date = default;
                }
            }
        }



        public override string ToString()
        {
            return $"Ник: {NameUser} | Викторина: {NameQuiz} | Вопросов: {MaxPoints} | Правильных ответов: {Points} | {Math.Round(Points / (double)MaxPoints * 100)}% | Дата: {date}";
        }
    }
}
