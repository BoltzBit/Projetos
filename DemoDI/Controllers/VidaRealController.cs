using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
	public class VidaRealController : Controller
	{
		private readonly IClientServices _clientServices;
		
		public VidaRealController(IClientServices clientServices)
		{
			_clientServices = clientServices;
		}
		
		public void Index()
		{
			_clientServices.AddClient(new Client());
		}
	}
}
