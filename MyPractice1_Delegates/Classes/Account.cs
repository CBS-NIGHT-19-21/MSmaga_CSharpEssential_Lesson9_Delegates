// Declare a delegate as a container for a method - reference for crossplatform of the algorithm.
// A container for the method what gets string input parameter and returns no value.
delegate void ClassDelegate(string message);

class Account
{
    #region
    // A delegate is a data structure that refers to one or more methods. 

    // A delegate declaration defines a class that is derived from the class System.Delegate.A delegate
    // instance encapsulates an invocation list, which is a list of one or more methods, each of which is referred
    // to as a callable entity.
    #endregion

    // Instance the the delegate ClassDelegate as _myDelegate.
    ClassDelegate? _myDelegate;

    // Declare the public method ClassDelegate() for assigning
    // this platform method into the instance of delegate ClassDelegate.
    public void AddMethod(ClassDelegate showMessage)
    {
        _myDelegate += showMessage;
    }
    public void SubMethod(ClassDelegate showMessage)
    {
        if (_myDelegate != null)
        {
            _myDelegate  -= showMessage;
        }
        
    }

    // Call method placed in the instance of delegate ClassDelegate.
    public void ShowMessage(string str)
    {

        _myDelegate!(str);
    }
}
