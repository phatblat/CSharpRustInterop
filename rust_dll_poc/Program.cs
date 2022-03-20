using System.Runtime.InteropServices;


public class RustTest
{
    [DllImport("cs_call_rst")]
    private unsafe static extern Int32 add_numbers(Int32 number1, Int32 number2);

    static void Main(string[] args)
    {
        var addedNumbers = add_numbers(10, 5);
        Console.WriteLine(addedNumbers);
        Console.ReadLine();
    }
}