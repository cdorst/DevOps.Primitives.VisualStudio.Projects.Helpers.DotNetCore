namespace DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore
{
    public static class SdkProperties
    {
        public static MsBuildProperty Authors(string value)
            => new MsBuildProperty(nameof(Authors), value, default(string));

        public static MsBuildProperty Copyright(string value)
            => new MsBuildProperty(nameof(Copyright), value, default(string));

        public static MsBuildProperty Description(string value)
            => new MsBuildProperty(nameof(Description), value, default(string));

        public static MsBuildProperty GeneratePackageOnBuild()
            => new MsBuildProperty(nameof(GeneratePackageOnBuild), "true", default(string));

        public static MsBuildProperty LangVersion(string value = "latest")
            => new MsBuildProperty(nameof(LangVersion), value, default(string));

        public static MsBuildProperty PackageIconUrl(string value)
            => new MsBuildProperty(nameof(PackageIconUrl), value, default(string));

        public static MsBuildProperty PackageId(string value)
            => new MsBuildProperty(nameof(PackageId), value, default(string));

        public static MsBuildProperty PackageLicenseUrl(string value)
            => new MsBuildProperty(nameof(PackageLicenseUrl), value, default(string));

        public static MsBuildProperty PackageProjectUrl(string value)
            => new MsBuildProperty(nameof(PackageProjectUrl), value, default(string));

        public static MsBuildProperty RepositoryUrl(string value)
            => new MsBuildProperty(nameof(RepositoryUrl), value, default(string));

        public static MsBuildProperty TargetFramework(string value = "netstandard2.0")
            => new MsBuildProperty(nameof(TargetFramework), value, default(string));

        public static MsBuildProperty Version(string value)
            => new MsBuildProperty(nameof(Version), value, default(string));
    }
}
