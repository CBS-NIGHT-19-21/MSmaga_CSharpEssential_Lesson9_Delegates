// Declare a delegate as a container for a method - reference for crossplatform of the algorithm.
// A container for the method what gets string input parameter and returns no value.
delegate void Delegate(string message);
delegate void Delegate2();

class Account
{
    #region
    // A delegate is a data structure that refers to one or more methods. 

    // A delegate declaration defines a class that is derived from the class System.Delegate.A delegate
    // instance encapsulates an invocation list, which is a list of one or more methods, each of which is referred
    // to as a callable entity.
    #endregion

    // Instance the the delegate Delegate as _myDelegate.
    Delegate? _myDelegate;

    // Declare the public method Delegate() for assigning
    // this platform method into the instance of delegate data structure Delegate.
    public void AddMethod(Delegate showMessage)
    {
        _myDelegate += showMessage;
    }
    public void SubMethod(Delegate showMessage)
    {
        if (_myDelegate != null)
        {
            _myDelegate -= showMessage;
        }
    }

    // Call method placed in the instance of delegate ClassDelegate.
    public void ShowMessage(string str)
    {
        _myDelegate!(str);
    }
}
