using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("WinSCP - Windows Secure Copy Protocol")]
[assembly: AssemblyDescription("WinSCP written in C# for .NET")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Programify Ltd")]
[assembly: AssemblyProduct("WinSCP")]
[assembly: AssemblyCopyright("Copyright © 2020")]
[assembly: AssemblyTrademark("Programify")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
//[assembly: Guid("3b942a79-2a6e-4549-a28c-36f8be81c101")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
//[assembly: AssemblyVersion("1.0.0.0")]
//[assembly: AssemblyFileVersion("1.0.0.0")]

// The following GUID is for the ID of the typelib if this project is exposed to COM
// Duplicated in ConsoleRunner.cpp
[assembly: Guid("a0b93468-d98a-4845-a234-8076229ad93f")]

[assembly: AssemblyVersion(WinSCP.AssemblyConstants.Version)]
[assembly: AssemblyFileVersion(WinSCP.AssemblyConstants.Version)]
[assembly: AssemblyInformationalVersion(WinSCP.AssemblyConstants.ProductVersion)]

//[assembly: CLSCompliant(true)]

[assembly: InternalsVisibleTo("Tests")]

namespace WinSCP
{
    internal static class AssemblyConstants
    {
        public const string UndefinedProductVersion = "9.9.9.9";

        public const string Version = "1.7.2.0";
        public const string ProductVersion = "5.15.2.0";
      //public const string ProductVersion = "5.16.7.0";  // This is the true version number (req'd by WinSCP.EXE).
    }
}
