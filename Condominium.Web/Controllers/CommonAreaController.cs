using Condominium.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Condominium.Web.Controllers
{
	public class CommonAreaController : Controller
	{
		private readonly ICommonAreaApplication _commonArea;

		public CommonAreaController(ICommonAreaApplication commonArea)
		{
			this._commonArea = commonArea;
		}

		public IActionResult Index()
		{
			return View();
		}

	}
}
