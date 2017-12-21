using DevOps.Primitives.NuGet;
using DevOps.Primitives.VisualStudio.Projects.Helpers.Common;

namespace DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore
{
    public static class SdkItems
    {
        public static MsBuildItem NuGetReference(NuGetReference package)
            => package.ReferenceType == ReferenceType.DotNetCliToolReference
                ? DotNetCliToolReference(package.Include, package.Version)
                : PackageReference(package.Include, package.Version);

        public static MsBuildItem DotNetCliToolReference(string include, string version)
            => GetReference(nameof(DotNetCliToolReference), include, version);

        public static MsBuildItem PackageReference(string include, string version)
            => GetReference(nameof(PackageReference), include, version);

        public static MsBuildItem ProjectReference(ProjectReference project)
            => ProjectReference(project.Include);

        public static MsBuildItem ProjectReference(string relativePath)
            => new MsBuildItem(nameof(ProjectReference), ItemAttributeLists.Create(
                new MsBuildItemAttribute(nameof(DotNetCore.ProjectReference.Include), relativePath)),
                default(string));

        private static MsBuildItem GetReference(string element, string include, string version)
            => new MsBuildItem(element, ItemAttributeLists.Create(
                new MsBuildItemAttribute(nameof(NuGet.NuGetReference.Include), include),
                new MsBuildItemAttribute(nameof(NuGet.NuGetReference.Version), version)),
                default(string));
    }
}
