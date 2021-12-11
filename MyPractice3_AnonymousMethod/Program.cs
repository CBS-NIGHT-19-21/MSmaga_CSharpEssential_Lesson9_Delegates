namespace AnonymousMethod
{
    class Program
    {    
        // Declare delegate type Delegate.
        public delegate double DelegateAnonMethod(double operand1, double operand2);
        public delegate int DelegateLambdaExp(int operand1, int operand2);
        static void Main(string[] args)
        {
            // Instance Delegate and assign anonymous method what doesn`t have its signature.
            DelegateAnonMethod mD =new DelegateAnonMethod
            (delegate(double operand1, double operand2) { return operand1 * operand2; });

            // Instance Delegate and assign Lambda Expression what doesn`t have its signature.
            DelegateLambdaExp mLambda = (int operand1, int operand2) => { return operand1 * operand2; };
  

            // Call the anonymous method through a gelegate reference.
            Console.WriteLine(mD(13.0, 19.0));

            // Call the lambda expression through a gelegate reference.
            Console.WriteLine(mLambda(13, 19));


            // Delay.
            Console.ReadLine();
        }
    }
}

