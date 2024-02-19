using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // interface new'lenemez
            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());

        }
    }
    interface IPersonManager
    {
        //unimplemented operation
        void Add();
        void Update();
    }
    //inherits - class ---------- implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");

        }

    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajer eklendi");

        }

        public void Update()
        {
            Console.WriteLine("Stajer güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            //CustomerManager customerManager = new CustomerManager();
            personManager.Add();
        }
    }
}
