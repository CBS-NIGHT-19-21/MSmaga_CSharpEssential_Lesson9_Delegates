namespace Task_Additional_AnonymousMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание Дополнительное
            //Используя Visual Studio, создайте проект по шаблону Console Application. 
            //Создайте анонимный метод, который принимает в качестве параметров три целочисленных аргумента и 
            //возвращает среднее арифметическое этих аргументов.
            #endregion

            double a = 13, b = 19, c = 139;

            // Define delegate instance using namespace and actual input parameters.
            Avg avg = delegate (double a, double b, double c) { return (a + b + c) / 3; };

            Console.WriteLine("Avg of array elements = {0}",avg(a, b, c));

            Console.ReadLine();
        }
    }
}



