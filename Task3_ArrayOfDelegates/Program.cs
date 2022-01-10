namespace MyPractice1_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 3
            //Используя Visual Studio, создайте проект по шаблону Console Application. 
            //Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и возвращает 
            //среднее арифметическое возвращаемых значений методов, сообщенных с делегатами в массиве. 
            //Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int.
            #endregion

            // Define the method of the delegate.
            GetRndInt delegateRndInt = () =>
            {
                Random rnd = new Random();
                return rnd.Next(0, 10);
            };

            // Define the array of delegates.
            GetRndInt[] ArrDelegates = new GetRndInt[598];

            // Init the array of delegates.
            for (int i = 0; i < ArrDelegates.Length; i++)
            {
                ArrDelegates[i] = new GetRndInt(delegateRndInt);
            }

            // Define the anonymous method - array of delegates as a formal argument.
            ArryaDelegate AvgArray = (ArrDelegates) =>
            {
                int sum = 0;
                int delegResult = 0;

                // Call delegates from the array.
                for (int i = 0; i < ArrDelegates.Length; i++)
                {
                    delegResult = ArrDelegates[i].Invoke();
                    sum += delegResult;
                    Console.Write($"Result from delegate №{i} = {delegResult}\t Sum = {sum}\n");
                }

                Console.WriteLine(new string ('=',42));
 
                Console.WriteLine($"Sum = {sum}, Avg = {(float)sum / ArrDelegates.Length:F2}");
            };

            // Call the anonymous method of array of delegates.
            AvgArray(ArrDelegates);

            // Delay. 
            Console.ReadLine();
        }

    }
}



