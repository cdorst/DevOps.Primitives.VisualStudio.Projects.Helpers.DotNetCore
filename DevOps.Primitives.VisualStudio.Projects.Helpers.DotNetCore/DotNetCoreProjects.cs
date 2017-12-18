using DevOps.Primitives.VisualStudio.Projects.Helpers.Common;
using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore
{
    public static class DotNetCoreProjects
    {
        public static Project Create(string name, IEnumerable<PackageReference> packageReferences = null, IEnumerable<ProjectReference> projectReferences = null, NuGetPackageInfo nuGetPackageInfo = null)
            => new Project(name,
                ProjectFiles.Create(ProjectType.MicrosoftNetSdk,
                    GetProperties(nuGetPackageInfo),
                    GetItems(packageReferences, projectReferences)));

        private static MsBuildItemGroupList GetItems(IEnumerable<PackageReference> packageReferences, IEnumerable<ProjectReference> projectReferences)
            => packageReferences != null || projectReferences != null
            ? PackageProjectReferenceItems.Create(packageReferences, projectReferences)
            : null;

        private static MsBuildPropertyGroupList GetProperties(NuGetPackageInfo nuGetPackageInfo)
            => PropertyGroupLists.Create(
                GetPropertyGroups(nuGetPackageInfo).ToArray());

        private static IEnumerable<MsBuildPropertyGroup> GetPropertyGroups(NuGetPackageInfo nuGetPackageInfo)
        {
            yield return SdkPropertyGroups.TargetAndLangVersion();
            if (nuGetPackageInfo != null) yield return SdkPropertyGroups.NuGetPackageInfo(nuGetPackageInfo);
        }
    }
}
