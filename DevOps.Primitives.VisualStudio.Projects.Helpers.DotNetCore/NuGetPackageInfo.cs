namespace DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore
{
    public class NuGetPackageInfo
    {
        public NuGetPackageInfo() { }
        public NuGetPackageInfo(string authors, string description, string version, bool? generatePackageOnBuild = false, string packageId = null)
        {
            Authors = authors;
            Description = description;
            GeneratePackageOnBuild = generatePackageOnBuild;
            PackageId = packageId;
            Version = version;
        }

        public string Authors { get; set; }
        public string Description { get; set; }
        public bool? GeneratePackageOnBuild { get; set; }
        public string PackageId { get; set; }
        public string Version { get; set; }
    }
}
