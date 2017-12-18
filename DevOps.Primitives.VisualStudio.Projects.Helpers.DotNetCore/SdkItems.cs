using DevOps.Primitives.VisualStudio.Projects.Helpers.Common;

namespace DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore
{
    public static class SdkItems
    {
        public static MsBuildItem PackageReference(PackageReference package)
            => PackageReference(package.Include, package.Version);

        public static MsBuildItem PackageReference(string include, string version)
            => new MsBuildItem(nameof(PackageReference), ItemAttributeLists.Create(
                new MsBuildItemAttribute(nameof(DotNetCore.PackageReference.Include), include),
                new MsBuildItemAttribute(nameof(DotNetCore.PackageReference.Version), version)),
                default(string));

        public static MsBuildItem ProjectReference(ProjectReference project)
            => ProjectReference(project.Include);

        public static MsBuildItem ProjectReference(string relativePath)
            => new MsBuildItem(nameof(ProjectReference), ItemAttributeLists.Create(
                new MsBuildItemAttribute(nameof(DotNetCore.ProjectReference.Include), relativePath)),
                default(string));
    }
}
