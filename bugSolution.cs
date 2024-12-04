public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass(int initialValue)
    {
        MyProperty = initialValue;
    }

    public void MyMethod()
    {
        // Accessing the property after initialization
        int value = MyProperty * 2; 
        Console.WriteLine(value);
    }

    public void MyMethod2()
    {
        MyProperty = 10; //Initialize it here
        int value = MyProperty * 2;
        Console.WriteLine(value);
    }
} 