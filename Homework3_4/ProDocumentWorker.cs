using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3_4
{
    class ProDocumentWorker : DocumentWorker
    {
       
        public override void EditDocument()
        {
            Console.WriteLine("Документ відредаговано");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах є у версії Експерт");
        }
    }


    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережений у новому форматі");
        }
    }
}
