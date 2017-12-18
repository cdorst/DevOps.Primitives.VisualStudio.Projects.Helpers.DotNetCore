using DevOps.Primitives.VisualStudio.Projects.Helpers.Common;
using System.Collections.Generic;

namespace DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore
{
    public static class PackageReferences
    {
        public static MsBuildItemGroup Create(params PackageReference[] packages)
        {
            var items = new List<MsBuildItem>();
            foreach (var package in packages) items.Add(SdkItems.PackageReference(package));
            return ItemGroups.Create(items.ToArray());
        }
    }
}
