using DevOps.Primitives.VisualStudio.Projects.Helpers.Common;
using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore
{
    public static class PackageProjectReferenceItems
    {
        public static MsBuildItemGroupList Create(IEnumerable<PackageReference> packageReferences = null, IEnumerable<ProjectReference> projectReferences = null)
        {
            var list = new List<MsBuildItemGroup>();
            if (packageReferences?.Any() ?? false) list.Add(PackageReferences.Create(packageReferences.ToArray()));
            if (projectReferences?.Any() ?? false) list.Add(ProjectReferences.Create(projectReferences.ToArray()));
            return ItemGroupLists.Create(list.ToArray());
        }
    }
}
