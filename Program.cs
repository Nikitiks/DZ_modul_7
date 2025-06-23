namespace DZ_modul_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Создайте интерфейс IOutput.В нём должно быть два метода:

            //void Show() — отображает информацию;
            //            void Show(string info) — отображает информацию и информационное сообщение, которое было указано в параметре info.
            //Создайте класс Array(массив целого типа) с необходимыми методами.Этот класс должен имплементировать интерфейс IOutput.

            //Метод Show() — отображает на экран элементы массива.

            //Метод Show(string info) — отображает на экран элементы массива и информационное сообщение, указанное в параметре info.

            //Напишите код для тестирования полученной функциональности.

            Array obj = new Array (new int[] { 4, 1, 3, 2, 7 });
            obj.Show();
            obj.Show("INFO:");

            //Задание 2
            //Создайте интерфейс IMath.В нём должно быть четыре метода:

            //int Max() — возвращает максимум;
            //            int Min() — возвращает минимум;
            //            float Avg() — возвращает среднеарифметическое;
            //            bool Search(int valueToSearch) — ищет valueSearch внутри контейнера данных.Возвращает true, если значение найдено.Возвращает false, если значение не найдено.
            //Класс, созданный в первом задании Array, должен имплементировать интерфейс IMath.

            //Метод Max — возвращает максимум среди элементов массива.

            //Метод Min — возвращает минимум среди элементов массива.

            //Метод Avg — возвращает среднеарифметическое среди элементов массива.

            //Метод Search — ищет значение внутри массива. Возвращает true, если значение найдено.Возвращает false, если значение не найдено.

            //Напишите код для тестирования полученной функциональности
            Console.WriteLine();
            Console.WriteLine(obj.Max());
            Console.WriteLine(obj.Min());
            Console.WriteLine("{0:0.00}", obj.Avg());
            int num = 3;
            if(obj.Search(num))
            { 
                Console.WriteLine("Число найденно: "+ num); 
            }
            else
            {
                Console.WriteLine("Такого числа нет");
            }

                //Задание 3
                //Создайте интерфейс ISort.В нём должно быть два метода:

                //void SortAsc() — сортировка по возрастанию;
                //            void SortDesc() — сортировка по убыванию;
                //            void SortByParam(bool isAsc) — сортировка в зависимости от переданного параметра. Если isAsc равен true, сортируем по возрастанию.Если isAsc равен false, сортируем по убыванию.
                //            Класс, созданный в первом задании Array, должен имплементировать интерфейс ISort.

                //Метод SortAsc — сортирует массив по возрастанию.

                //Метод SortDesc — сортирует массив по убыванию.

                //Метод SortByParam — сортирует массив в зависимости от переданного параметра.Если isAsc равен true, сортируем по возрастанию.Если isAsc равен false, сортируем по убыванию.

                //Напишите код для тестирования полученной функциональности.
                Console.WriteLine("SortAsc");
            obj.SortAsc();
            obj.Show();

            Console.WriteLine("SortDesc");
            obj.SortDesc();
            obj.Show();

            Console.WriteLine("SortByParam");
            bool srt = true;
            obj.SortByParam(srt);
            obj.Show();
            Console.WriteLine();
            //Задание 4
            //Создайте интерфейс IShape.Это интерфейс для геометрических фигур.Методы интерфейса:

            //CalculateArea();
            //            CalculatePerimeter().
            //Реализуйте интерфейс для нескольких фигур(круг, прямоугольник, треугольник).

            Circule c = new Circule (3,7);
            Console.WriteLine("Circule");
            Console.WriteLine("Area = {0:F2}", c.CalculateArea());
            Console.WriteLine("Perimetr = {0:F2}", c.CalculatePerimeter());
            Console.WriteLine();

            Square s = new Square(11, 4);
            Console.WriteLine("Square");
            Console.WriteLine("Area = {0:F2}", s.CalculateArea());
            Console.WriteLine("Perimetr = {0:F2}", s.CalculatePerimeter());
            Console.WriteLine();

            Triangle t = new Triangle(5, 7);
            Console.WriteLine("Triangle");
            Console.WriteLine("Area = {0:F2}", t.CalculateArea());
            Console.WriteLine("Perimetr = {0:F2}", t.CalculatePerimeter());
            Console.WriteLine();

            //Задание 5
            //Создайте интерфейс IDrivable.Это интерфейс для управления транспортными средствами. Методы интерфейса:

            //StartEngine();
            //            StopEngine();
            //            Drive().
            //Реализуйте интерфейс его в классах «Автомобиль» и «Мотоцикл».


            Car cr = new Car();
            cr.StartEngine();
            cr.Drive();
            cr.StopEngine();
            Console.WriteLine();

            Motorcycle moto = new Motorcycle();
            moto.StartEngine();
            moto.Drive();
            moto.StopEngine();
        }
    }
}
