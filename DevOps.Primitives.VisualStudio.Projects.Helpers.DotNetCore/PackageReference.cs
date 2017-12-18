namespace DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore
{
    public class PackageReference
    {
        public PackageReference() { }
        public PackageReference(string include, string version)
        {
            Include = include;
            Version = version;
        }

        public string Include { get; set; }
        public string Version { get; set; }
    }
}
