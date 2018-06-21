using DevOps.Primitives.VisualStudio.Projects.Helpers.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using static DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore.SdkProperties;
using static System.String;

namespace DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore
{
    public static class SdkPropertyGroups
    {
        public static MsBuildPropertyGroup TargetAndLangVersion(in string targetFrameworkMoniker = TargetFrameworkMonikers.TargetFramework)
            => PropertyGroups.Create(
                LangVersion(),
                TargetFramework(in targetFrameworkMoniker));

        public static MsBuildPropertyGroup NuGetPackageInfo(in NuGetPackageInfo info)
        {
            if (info == null) throw new ArgumentNullException(nameof(info));
            var properties = GetNuGetPackageProperties(in info);
            return PropertyGroups.Create(
                properties.OrderBy(p => p.ElementName.Value).ToArray());
        }

        private static List<MsBuildProperty> GetNuGetPackageProperties(in NuGetPackageInfo info)
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
            if (!IsNullOrWhiteSpace(info.PackageId)) properties.Add(PackageId(info.PackageId));
            return properties;
        }
    }
}
