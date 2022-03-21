using System.Runtime.InteropServices;

namespace rust_dll_poc;

[StructLayout(LayoutKind.Sequential)]
public struct SampleStruct
{
    public Int16 field_one;
    public Int32 field_two;
}

public static class RustTest
{
    [DllImport("cs_call_rst", EntryPoint = "add_numbers", CallingConvention = CallingConvention.Cdecl)]
    private static extern Int32 add_numbers(Int32 number1, Int32 number2);

    [DllImport("cs_call_rst")]
    private static extern SampleStruct get_simple_struct();

    private static void Main(string[] args)
    {
        Console.WriteLine("Calling into rust");
        var addedNumbers = add_numbers(10, 5);
        Console.WriteLine($"Returned value: {addedNumbers}");
        Console.ReadLine();

        var simple_struct = get_simple_struct();
        Console.WriteLine(simple_struct.field_one);
        Console.WriteLine(simple_struct.field_two);
    }
}
