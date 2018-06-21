using DevOps.Primitives.NuGet;
using DevOps.Primitives.VisualStudio.Projects.Helpers.Common;
using System.Collections.Generic;

namespace DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore
{
    public static class NuGetReferences
    {
        public static MsBuildItemGroup Create(params NuGetReference[] packages)
        {
            var items = new List<MsBuildItem>();
            foreach (var package in packages) items.Add(SdkItems.NuGetReference(in package));
            return ItemGroups.Create(items.ToArray());
        }
    }
}
