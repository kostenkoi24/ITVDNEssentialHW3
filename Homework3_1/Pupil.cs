﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3_1
{
    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Pupil.Study");
        }
        public virtual void Read()
        {
            Console.WriteLine("Pupil.Read");
        }
        public virtual void Write()
        {
            Console.WriteLine("Pupil.Write");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Pupil.Relax");
        }
    }

    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("ExcelentPupil.Study");
        }
        public override void Read()
        {
            Console.WriteLine("ExcelentPupil.Read");
        }
        public override void Write()
        {
            Console.WriteLine("ExcelentPupil.Write");
        }
        public override void Relax()
        {
            Console.WriteLine("ExcelentPupil.Relax");
        }
    }
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("GoodPupil.Study");
        }
        public override void Read()
        {
            Console.WriteLine("GoodPupil.Read");
        }
        public override void Write()
        {
            Console.WriteLine("GoodPupil.Write");
        }
        public override void Relax()
        {
            Console.WriteLine("GoodPupil.Relax");
        }

    }
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("BadPupil.Study");
        }
        public override void Read()
        {
            Console.WriteLine("BadPupil.Read");
        }
        public override void Write()
        {
            Console.WriteLine("BadPupil.Write");
        }
        public override void Relax()
        {
            Console.WriteLine("BadPupil.Relax");
        }
    }
}
