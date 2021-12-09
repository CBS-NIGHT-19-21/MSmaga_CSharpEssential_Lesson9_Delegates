namespace Delegates
{
    class Program
    {
        // Declare delegates as methods - references.

        // For methods what gets no input parameters and returns no value.
        delegate void Output();

        // For methods what gets int input parameter and returns string value.
        delegate string IntConvert(int intParameter);

        // For methods what gets double input parameter and returns string value.
        delegate string DoubleConvert(double doubleParameter);

      
        static void Main(string[] args)
        {
            Output output;
            output = Show;
            output.Invoke();
        }

        static void Show()
        {
            Console.WriteLine("Blah-Blah-Blah");
        }

    }
}

