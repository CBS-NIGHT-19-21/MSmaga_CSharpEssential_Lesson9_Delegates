namespace AnonymousMethod
{
    class Program
    {    
        // Declare delegate type Delegate.
        public delegate double DelegateAnonMethod(double operand1, double operand2);
        public delegate int DelegateLambdaExp(int operand1, int operand2);
        public delegate bool DelegateLambdaOper(float operand1, float operand2);
        static void Main(string[] args)
        {
            // Instance Delegate and assign anonymous method what doesn`t have its signature.
            DelegateAnonMethod mAnonMethod = new DelegateAnonMethod
            (delegate(double operand1, double operand2) { return operand1 * operand2; });

            // Instance Delegate and assign Lambda Expression what doesn`t have its signature.
            DelegateLambdaExp mLambdaExp = (int operand1, int operand2) => { return operand1 * operand2; };
  

            // Call the anonymous method through a gelegate reference.
            Console.WriteLine(mAnonMethod(13.0, 19.0));

            // Call the lambda expression through a gelegate reference.
            Console.WriteLine(mLambdaExp(13, 19));

            // Lambda operator has some lambda expressions.

            // Instance Delegate and assign Lambda Expression what doesn`t have its signature.
            DelegateLambdaOper mLambdaOper = (float operand1, float operand2) => 
            {
                float  buffer = operand1 * operand2;
                return (buffer % 2  < 13); 
            };

            // Call the Lambda operator through a gelegate reference.
            Console.WriteLine(mLambdaOper(13, 19));

            // Delay.
            Console.ReadLine();
        }
    }
}

