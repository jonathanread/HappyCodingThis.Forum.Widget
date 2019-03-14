using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Frontend.Mvc.Models;
using Telerik.Sitefinity.Model;

namespace HappyCodingThis.Forums.Widget.Mvc.Models
{
	public class ForumViewModel : ContentModelBase
	{
		protected override IQueryable<IDataItem> GetItemsQuery()
		{
			throw new NotImplementedException();
		}
	}
}
