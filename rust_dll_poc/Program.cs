using System.Runtime.InteropServices;

namespace rust_dll_poc;

public static class RustTest
{
    [DllImport("cs_call_rst", EntryPoint = "add_numbers", CallingConvention = CallingConvention.Cdecl)]
    private static extern Int32 add_numbers(Int32 number1, Int32 number2);

    private static void Main(string[] args)
    {
        Console.WriteLine("Calling into rust");
        var addedNumbers = add_numbers(10, 5);
        Console.WriteLine(addedNumbers);
        Console.ReadLine();
    }
}
