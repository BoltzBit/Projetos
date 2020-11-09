using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
	public class GenericControllers : Controller
	{
		public IGenericRepository<Client> _clientRepository;
		
		public GenericControllers(IGenericRepository<Client> clientRepository)
		{
			_clientRepository = clientRepository;
		}
		
		public void Index()
		{
			_clientRepository.Add(new Client());
		}
	}
}
