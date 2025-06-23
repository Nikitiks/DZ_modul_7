using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_modul_7
{
    interface IOutput
    {
        void Show();
        void Show(string info);
    }


    interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);

    }

    interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);

    }

    interface IShape
    {
        double CalculateArea();
        double CalculatePerimeter();
    }

    interface IDrivable
    {
        void StartEngine();
        void StopEngine();
        void Drive();
    }
}
