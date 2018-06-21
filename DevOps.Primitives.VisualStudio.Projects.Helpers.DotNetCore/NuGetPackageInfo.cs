namespace DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore
{
    public class NuGetPackageInfo
    {
        public NuGetPackageInfo() { }
        public NuGetPackageInfo(
            in string version,
            in string authors,
            in string copyright,
            in string description,
            in string packageIconUrl,
            in string packageLicenseUrl,
            in string packageProjectUrl,
            in string repositoryUrl,
            in bool? generatePackageOnBuild = false,
            in string packageId = default)
        {
            Authors = authors;
            Copyright = copyright;
            Description = description;
            GeneratePackageOnBuild = generatePackageOnBuild;
            PackageIconUrl = packageIconUrl;
            PackageId = packageId;
            PackageLicenseUrl = packageLicenseUrl;
            PackageProjectUrl = packageProjectUrl;
            RepositoryUrl = repositoryUrl;
            Version = version;
        }

        public string Authors { get; set; }
        public string Copyright { get; set; }
        public string Description { get; set; }
        public bool? GeneratePackageOnBuild { get; set; }
        public string PackageIconUrl { get; set; }
        public string PackageId { get; set; }
        public string PackageLicenseUrl { get; set; }
        public string PackageProjectUrl { get; set; }
        public string RepositoryUrl { get; set; }
        public string Version { get; set; }
    }
}
