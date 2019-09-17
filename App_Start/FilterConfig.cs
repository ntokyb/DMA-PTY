using System.Web;
using System.Web.Mvc;

namespace DMA__Pty__Ltd
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
