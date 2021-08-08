using System;

namespace InterFaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[] { new TechWorker(), new Managers() };

            foreach (var worker in workers)
            {
                worker.Add();
            }

           

            Console.ReadLine();
        }
    }
}
