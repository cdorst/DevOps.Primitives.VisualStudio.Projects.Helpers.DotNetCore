using DevOps.Primitives.NuGet;
using DevOps.Primitives.VisualStudio.Projects.Helpers.Common;
using System.Collections.Generic;
using System.Linq;
using static DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore.TargetFrameworkMonikers;

namespace DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore
{
    public static class DotNetCoreProjects
    {
        public static Project Create(
            in string name,
            in string targetFrameworkMoniker = TargetFramework,
            in IEnumerable<NuGetReference> nuGetReferences = default,
            in IEnumerable<ProjectReference> projectReferences = default,
            in NuGetPackageInfo nuGetPackageInfo = default)
            => new Project(in name,
                ProjectFiles.Create(ProjectType.MicrosoftNetSdk,
                    GetProperties(in nuGetPackageInfo, in targetFrameworkMoniker),
                    GetItems(in nuGetReferences, in projectReferences)));

        private static MsBuildItemGroupList GetItems(
            in IEnumerable<NuGetReference> nuGetReferences,
            in IEnumerable<ProjectReference> projectReferences)
            => nuGetReferences == null && projectReferences == null ? null
            : PackageProjectReferenceItems.Create(in nuGetReferences, in projectReferences);

        private static MsBuildPropertyGroupList GetProperties(
            in NuGetPackageInfo nuGetPackageInfo,
            in string targetFrameworkMoniker = TargetFramework)
            => PropertyGroupLists.Create(
                GetPropertyGroups(nuGetPackageInfo, targetFrameworkMoniker).ToArray());

        private static IEnumerable<MsBuildPropertyGroup> GetPropertyGroups(NuGetPackageInfo nuGetPackageInfo, string targetFrameworkMoniker = TargetFramework)
        {
            yield return SdkPropertyGroups.TargetAndLangVersion(targetFrameworkMoniker);
            if (nuGetPackageInfo != null) yield return SdkPropertyGroups.NuGetPackageInfo(nuGetPackageInfo);
        }
    }
}
