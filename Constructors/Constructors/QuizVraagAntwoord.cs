using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_
{
    internal class QuizVraagAntwoord
    {
        internal string vraag;
        internal string gegevenAntwoord;
        internal bool isCorrect;

        internal QuizVraagAntwoord(string vraag, string gegevenAntwoord, bool isCorrect)
        {
            this.vraag = vraag;
            this.gegevenAntwoord = gegevenAntwoord;
            this.isCorrect = isCorrect;
        }
    }
}
