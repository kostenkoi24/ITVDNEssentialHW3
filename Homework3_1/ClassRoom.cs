using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3_1
{
    class ClassRoom
    {
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            Show(pupil1);
            Show(pupil2);
            Show(pupil3);
            Show(pupil4);
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            Show(pupil1);
            Show(pupil2);
            Show(pupil3);
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            Show(pupil1);
            Show(pupil2);
        }
        void Show(Pupil pupil)
        {
            pupil.Read();
            pupil.Relax();
            pupil.Study();
            pupil.Write();
        }
    }
}
