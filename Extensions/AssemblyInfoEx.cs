using System.Reflection;

namespace DoubleJumpCS2.Extensions
{
    internal static class AssemblyInfoEx
    {
        public static string GetVersion()
        {
            /*return Assembly
                .GetExecutingAssembly()
                .GetCustomAttribute<AssemblyVersionAttribute>()
                .Version;*/
            
            
            var version = typeof(AssemblyInfoEx).Assembly
                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
            return version ?? "1.0.0"; // Default version if not found
        }

        public static string GetAuthor()
        {
            return Assembly
                .GetExecutingAssembly()
                .GetCustomAttribute<AssemblyCopyrightAttribute>()
                .Copyright;
        }
    }
}
