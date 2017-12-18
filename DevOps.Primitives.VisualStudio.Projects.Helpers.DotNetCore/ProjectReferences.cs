using DevOps.Primitives.VisualStudio.Projects.Helpers.Common;
using System.Collections.Generic;

namespace DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore
{
    public static class ProjectReferences
    {
        public static MsBuildItemGroup Create(params ProjectReference[] projects)
        {
            var items = new List<MsBuildItem>();
            foreach (var project in projects) items.Add(SdkItems.ProjectReference(project));
            return ItemGroups.Create(items.ToArray());
        }
    }
}
