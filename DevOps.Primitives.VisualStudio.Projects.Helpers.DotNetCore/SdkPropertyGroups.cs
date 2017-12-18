using DevOps.Primitives.VisualStudio.Projects.Helpers.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore
{
    public static class SdkPropertyGroups
    {
        public static MsBuildPropertyGroup TargetAndLangVersion()
            => PropertyGroups.Create(
                SdkProperties.LangVersion(),
                SdkProperties.TargetFramework());

        public static MsBuildPropertyGroup NuGetPackageInfo(NuGetPackageInfo info)
        {
            if (info == null) throw new ArgumentNullException(nameof(info));
            var properties = GetNuGetPackageProperties(info);
            return PropertyGroups.Create(
                properties.OrderBy(p => p.ElementName).ToArray());
        }

        private static List<MsBuildProperty> GetNuGetPackageProperties(NuGetPackageInfo info)
        {
            var properties = new List<MsBuildProperty>
            {
                SdkProperties.Authors(info.Authors),
                SdkProperties.Description(info.Description),
                SdkProperties.Version(info.Version)
            };
            if (info.GeneratePackageOnBuild == true) properties.Add(SdkProperties.GeneratePackageOnBuild());
            if (!string.IsNullOrWhiteSpace(info.PackageId)) properties.Add(SdkProperties.PackageId(info.PackageId));
            return properties;
        }
    }
}
