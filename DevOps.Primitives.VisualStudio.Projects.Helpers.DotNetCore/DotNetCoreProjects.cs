using DevOps.Primitives.NuGet;
using DevOps.Primitives.VisualStudio.Projects.Helpers.Common;
using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore
{
    public static class DotNetCoreProjects
    {
        public static Project Create(string name, string targetFrameworkMoniker = "netstandard2.0", IEnumerable<NuGetReference> nuGetReferences = null, IEnumerable<ProjectReference> projectReferences = null, NuGetPackageInfo nuGetPackageInfo = null)
            => new Project(name,
                ProjectFiles.Create(ProjectType.MicrosoftNetSdk,
                    GetProperties(nuGetPackageInfo, targetFrameworkMoniker),
                    GetItems(nuGetReferences, projectReferences)));

        private static MsBuildItemGroupList GetItems(IEnumerable<NuGetReference> nuGetReferences, IEnumerable<ProjectReference> projectReferences)
            => nuGetReferences == null && projectReferences == null ? null
            : PackageProjectReferenceItems.Create(nuGetReferences, projectReferences);

        private static MsBuildPropertyGroupList GetProperties(NuGetPackageInfo nuGetPackageInfo, string targetFrameworkMoniker = "netstandard2.0")
            => PropertyGroupLists.Create(
                GetPropertyGroups(nuGetPackageInfo, targetFrameworkMoniker).ToArray());

        private static IEnumerable<MsBuildPropertyGroup> GetPropertyGroups(NuGetPackageInfo nuGetPackageInfo, string targetFrameworkMoniker = "netstandard2.0")
        {
            yield return SdkPropertyGroups.TargetAndLangVersion(targetFrameworkMoniker);
            if (nuGetPackageInfo != null) yield return SdkPropertyGroups.NuGetPackageInfo(nuGetPackageInfo);
        }
    }
}
