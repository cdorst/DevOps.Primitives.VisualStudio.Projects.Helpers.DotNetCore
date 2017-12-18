namespace DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore
{
    public static class SdkProperties
    {
        public static MsBuildProperty Authors(string value)
            => new MsBuildProperty(nameof(Authors), value, default(string));

        public static MsBuildProperty Description(string value)
            => new MsBuildProperty(nameof(Description), value, default(string));

        public static MsBuildProperty GeneratePackageOnBuild()
            => new MsBuildProperty(nameof(GeneratePackageOnBuild), "true", default(string));
        public static MsBuildProperty LangVersion(string value = "latest")
            => new MsBuildProperty(nameof(LangVersion), value, default(string));

        public static MsBuildProperty PackageId(string value)
            => new MsBuildProperty(nameof(PackageId), value, default(string));

        public static MsBuildProperty TargetFramework(string value = "netstandard2.0")
            => new MsBuildProperty(nameof(TargetFramework), value, default(string));

        public static MsBuildProperty Version(string value)
            => new MsBuildProperty(nameof(Version), value, default(string));
    }
}
