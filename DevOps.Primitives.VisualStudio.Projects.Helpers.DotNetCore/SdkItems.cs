using DevOps.Primitives.NuGet;
using DevOps.Primitives.VisualStudio.Projects.Helpers.Common;

namespace DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore
{
    public static class SdkItems
    {
        public static MsBuildItem NuGetReference(in NuGetReference package)
            => PackageReference(
                package.Include.Value,
                package.Version.Value);

        public static MsBuildItem PackageReference(in string include, in string version)
            => GetReference(nameof(PackageReference), in include, in version);

        public static MsBuildItem ProjectReference(in ProjectReference project)
            => ProjectReference(project.Include);

        public static MsBuildItem ProjectReference(in string relativePath)
            => new MsBuildItem(nameof(ProjectReference), ItemAttributeLists.Create(
                new MsBuildItemAttribute(nameof(DotNetCore.ProjectReference.Include), in relativePath)),
                default(string));

        private static MsBuildItem GetReference(in string element, in string include, in string version)
            => new MsBuildItem(in element, ItemAttributeLists.Create(
                new MsBuildItemAttribute(nameof(NuGet.NuGetReference.Include), in include),
                new MsBuildItemAttribute(nameof(NuGet.NuGetReference.Version), in version)),
                default(string));
    }
}
