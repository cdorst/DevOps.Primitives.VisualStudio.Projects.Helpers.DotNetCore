namespace DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore
{
    public static class SdkProperties
    {
        public static MsBuildProperty Authors(in string value)
            => new MsBuildProperty(nameof(Authors), in value, default(MsBuildCondition));

        public static MsBuildProperty Copyright(in string value)
            => new MsBuildProperty(nameof(Copyright), in value, default(MsBuildCondition));

        public static MsBuildProperty Description(in string value)
            => new MsBuildProperty(nameof(Description), in value, default(MsBuildCondition));

        public static MsBuildProperty GeneratePackageOnBuild()
            => new MsBuildProperty(nameof(GeneratePackageOnBuild), "true", default(MsBuildCondition));

        public static MsBuildProperty LangVersion(in string value = "latest")
            => new MsBuildProperty(nameof(LangVersion), in value, default(MsBuildCondition));

        public static MsBuildProperty PackageIconUrl(in string value)
            => new MsBuildProperty(nameof(PackageIconUrl), in value, default(MsBuildCondition));

        public static MsBuildProperty PackageId(in string value)
            => new MsBuildProperty(nameof(PackageId), in value, default(MsBuildCondition));

        public static MsBuildProperty PackageLicenseUrl(in string value)
            => new MsBuildProperty(nameof(PackageLicenseUrl), in value, default(MsBuildCondition));

        public static MsBuildProperty PackageProjectUrl(in string value)
            => new MsBuildProperty(nameof(PackageProjectUrl), in value, default(MsBuildCondition));

        public static MsBuildProperty RepositoryUrl(in string value)
            => new MsBuildProperty(nameof(RepositoryUrl), in value, default(MsBuildCondition));

        public static MsBuildProperty TargetFramework(in string value = TargetFrameworkMonikers.TargetFramework)
            => new MsBuildProperty(nameof(TargetFramework), in value, default(MsBuildCondition));

        public static MsBuildProperty Version(in string value)
            => new MsBuildProperty(nameof(Version), in value, default(MsBuildCondition));
    }
}
