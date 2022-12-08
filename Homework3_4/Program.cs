using System;

namespace Homework3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            
            Console.WriteLine("1 - Pro; \n2 - Exp \nВведіть номер ключа або натисніть Enter: ");

            int.TryParse(Console.ReadLine(), out int key);

            DocumentWorker documentWorker = new DocumentWorker();

            if (key == 0)
            {
                documentWorker.OpenDocument();
                documentWorker.EditDocument();
                documentWorker.SaveDocument();
            }
            else if (key == 1)
            {
                ProDocumentWorker proDocumentWorker = new ProDocumentWorker();
                DocumentWorker document = proDocumentWorker;
                document.OpenDocument();
                document.EditDocument();
                document.SaveDocument();
            }
            else if (key == 2)
            {
                ExpertDocumentWorker expertDocumentWorker = new ExpertDocumentWorker();
                DocumentWorker document = expertDocumentWorker;
                document.OpenDocument();
                document.EditDocument();
                document.SaveDocument();
            }

            //Console.WriteLine(key);
            Console.ReadKey();

        }
    }
}
