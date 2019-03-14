using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Frontend.Mvc.Models;
using Telerik.Sitefinity.Model;

namespace HappyCodingThis.Forums.Widget.Mvc.Models
{
	public class ForumModel
	{
		public Guid ListForumsTemplateId { get; set; }
		public Guid ListOfThreadsTemplateId { get; set; }
		public Guid ListOfPostsTemplateId { get; set; }
		public Guid ListOfForumGroupsTemplateId { get; set; }
		public bool ShowBreadcrumb { get; set; }
		public bool IncludeFullPathFromHome { get; set; }
		public bool ForumGroupFirstLevel { get; set; }
		public Guid ProfilePageId { get; set; }
		public ForumDisplaySetting FourmDisplaySetting { get; set; }
		public ForumFunctionality FourmFunctionality { get; set; }

	}

	public enum ForumDisplaySetting
	{
		AllForums,
		ForumsFromSelectedGroups,
		SelectedForums
	}

	public enum ForumFunctionality
	{
		FullForumFunctionality,
		FourmListOnly,
		ThreadsOnly,
		PostsOfOneThreadOnly
	}
}
