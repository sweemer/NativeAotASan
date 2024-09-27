using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NativeAotASan;

public sealed partial class Interop
{
    [LibraryImport("nativeaotasan")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void hello_world();
}

public sealed class Program
{
    public static void Main()
    {
        NativeAotASan.Interop.hello_world();
    }
}
