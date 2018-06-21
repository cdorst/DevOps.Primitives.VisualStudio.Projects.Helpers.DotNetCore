using static System.String;

namespace DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore
{
    public static class TargetFrameworkMonikers
    {
        internal const string TargetFramework = "netstandard2.0";

        private const string dot = ".";
        private const string net = nameof(net);
        private const string netcoreapp = nameof(netcoreapp);
        private const string netstandard = nameof(netstandard);

        public static string DotNetCoreApp(in string version = "2.1") => Concat(netcoreapp, version);
        public static string DotNetFramework(in string version = "4.7.2") => Concat(net, version.Replace(dot, Empty));
        public static string DotNetStandard(in string version = "2.0") => Concat(netstandard, version);
    }
}
