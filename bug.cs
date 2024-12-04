public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property before it's initialized can lead to unexpected behavior.
        int value = MyProperty * 2; // Bug: MyProperty might be 0 if not explicitly initialized.
        Console.WriteLine(value);
    }
}