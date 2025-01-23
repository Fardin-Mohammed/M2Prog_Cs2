using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RijSchool
{
    internal class LesUur
    {
        internal int tijd;
        internal Student student;
        internal RijLeraar rijLeraar;
        internal Auto auto;
    }


    LesUur lesUur = new LesUur()
    {
        auto = auto1,
        rijLeraar = rijLeraar,

        tijd = 1130
    };
}
