namespace DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore
{
    public class NuGetPackageInfo
    {
        public NuGetPackageInfo() { }
        public NuGetPackageInfo(string version, string authors, string copyright, string description, string packageIconUrl, string packageLicenseUrl, string packageProjectUrl, string repositoryUrl, bool? generatePackageOnBuild = false, string packageId = null)
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
