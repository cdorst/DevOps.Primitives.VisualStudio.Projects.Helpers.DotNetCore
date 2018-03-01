namespace DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore
{
    public static class TargetFrameworkMonikers
    {
        private const string dot = ".";
        private const string net = nameof(net);
        private const string netcoreapp = nameof(netcoreapp);
        private const string netstandard = nameof(netstandard);

        public static string DotNetCoreApp(string version = "2.0") => $"{netcoreapp}{version}";
        public static string DotNetFramework(string version = "4.7.1") => $"{net}{version.Replace(dot, string.Empty)}";
        public static string DotNetStandard(string version = "2.0") => $"{netstandard}{version}";
    }
}
