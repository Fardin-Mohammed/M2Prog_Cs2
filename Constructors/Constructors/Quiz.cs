using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_
{
    internal class Quiz
    {
        internal string titel;
        internal List<QuizVraag> vragen;

        internal Quiz(string titel)
        {
            this.titel = titel;
            this.vragen = new List<QuizVraag>();
        }
    }
}
