using System;
using System.Collections.Generic;
using System.Text;

namespace InterFaces
{
    interface IWorker
    {
        void Add();
        void Delete();
        void Update();
       
    }

    public class TechWorker : IWorker
    {
        public void Add()
        {
            Console.WriteLine("Tech staff added");
        }

        public void Delete()
        {
            Console.WriteLine("Tech staff deleted");
        }

        public void Update()
        {
            Console.WriteLine("Tech staff updated");
        }

     
    }

    public class Managers : IWorker
    {
        public void Add()
        {
            Console.WriteLine("Manager added");
        }

        public void Delete()
        {
            Console.WriteLine("Manager  deleted");
        }

        public void Update()
        {
            Console.WriteLine("Manager  updated");
        }
    }
}
