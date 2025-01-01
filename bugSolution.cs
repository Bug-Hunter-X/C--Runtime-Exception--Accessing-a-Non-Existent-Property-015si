public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Check for null before accessing the property
        if (this.MyProperty != null) 
        {
            int value = this.MyProperty; 
            // Do something with the value 
        } else {
            // handle the case where property is null
            Console.WriteLine("MyProperty is null");
        }
    }
}