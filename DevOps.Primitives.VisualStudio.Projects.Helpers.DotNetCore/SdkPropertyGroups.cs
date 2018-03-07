using DevOps.Primitives.VisualStudio.Projects.Helpers.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using static DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore.SdkProperties;

namespace DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore
{
    public static class SdkPropertyGroups
    {
        public static MsBuildPropertyGroup TargetAndLangVersion(string targetFrameworkMoniker = "netstandard2.0")
            => PropertyGroups.Create(
                LangVersion(),
                TargetFramework(targetFrameworkMoniker));

        public static MsBuildPropertyGroup NuGetPackageInfo(NuGetPackageInfo info)
        {
            if (info == null) throw new ArgumentNullException(nameof(info));
            var properties = GetNuGetPackageProperties(info);
            return PropertyGroups.Create(
                properties.OrderBy(p => p.ElementName.Value).ToArray());
        }

        private static List<MsBuildProperty> GetNuGetPackageProperties(NuGetPackageInfo info)
        {
            var properties = new List<MsBuildProperty>
            {
                Authors(info.Authors),
                Copyright(info.Copyright),
                Description(info.Description),
                PackageIconUrl(info.PackageIconUrl),
                PackageLicenseUrl(info.PackageLicenseUrl),
                PackageProjectUrl(info.PackageProjectUrl),
                RepositoryUrl(info.RepositoryUrl),
                Version(info.Version)
            };
            if (info.GeneratePackageOnBuild == true) properties.Add(GeneratePackageOnBuild());
            if (!string.IsNullOrWhiteSpace(info.PackageId)) properties.Add(PackageId(info.PackageId));
            return properties;
        }
    }
}
