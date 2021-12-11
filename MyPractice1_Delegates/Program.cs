namespace Delegates
{
    class Program
    {   // Declare this platform methods for output of string message.
        static void ShowWithEqual(string message) => Console.WriteLine(message + new string('=', 13));
 
        static void ShowWithPlus(string message) => Console.WriteLine(message + new string('+', 13));
   
        static void Main(string[] args)
        {
            // Instance class Account.
            Account account = new Account();

            // Add this platform methods ShowWithEqual() and ShowWithPlus()
            // to the multicast delegate ClassDelegate as a field of the Account instance
            // using public method of Account class - AddMethod().
            for (int i = 0; i < 5; i++)
            {
                account.AddMethod(ShowWithEqual);
                account.AddMethod(ShowWithPlus);
            }

            // Call all this platform methods ShowWithEqual() and ShowWithPlus()
            // through method ShowMessage().
            account.ShowMessage("Hi, there!");


            Console.WriteLine(new string('_', 19));

            // Sub this platform methods ShowWithEqual() 3 times
            // from the multicast delegate ClassDelegate as a field of the Account instance
            // using public method of Account class - AddMethod().
            for (int i = 0; i < 3; i++)
            {
                account.SubMethod(ShowWithEqual);
            }

            // Call the rest of this platform methods placed the in delegate ClassDelegate
            // as a field of the Account instance.
            account.ShowMessage("Hi, there!");


            // Assign an anonymous method to the delegate.
            Delegate2 _myDelegate2 = delegate ()
            {
                Console.WriteLine("\nBlah blah blah");
            };
            _myDelegate2();

            // Delay.
            Console.ReadLine();
        }
    }
}

