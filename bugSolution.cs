public class ExampleClass
{
    public int MyProperty { get; set; }

    // Initialize MyProperty in the constructor
    public ExampleClass()
    {
        MyProperty = 0; // Or any other default value
    }

    public void MyMethod()
    {
        int value = MyProperty * 2; 
    }
}