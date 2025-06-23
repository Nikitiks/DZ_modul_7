using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_modul_7
{
    class Car : IDrivable
    {
        public void Drive()
        {
            Console.WriteLine("Ведём машину");
        }

        public void StartEngine()
        {
            Console.WriteLine("Заводим двигатель машины");
        }

        public void StopEngine()
        {
            Console.WriteLine("Глушим двигатель машины");
        }
    }

    class Motorcycle : IDrivable
    {
        public void Drive()
        {
            Console.WriteLine("Ведём мотоцикл");
        }

        public void StartEngine()
        {
            Console.WriteLine("Заводим двигатель мотоцикла");
        }

        public void StopEngine()
        {
            Console.WriteLine("Глушим двигатель мотоцикла");
        }
    }
}
