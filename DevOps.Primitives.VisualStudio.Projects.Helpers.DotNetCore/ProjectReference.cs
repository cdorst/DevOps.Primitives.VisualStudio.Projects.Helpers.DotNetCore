namespace DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore
{
    public class ProjectReference
    {
        public ProjectReference() { }
        public ProjectReference(string relativePath) { Include = relativePath; }

        public string Include { get; set; }
    }
}
