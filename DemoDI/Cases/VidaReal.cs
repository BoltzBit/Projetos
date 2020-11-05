using System;

namespace DemoDI.Cases
{
	public class Client
	{
		public int ClientID { get; set; }
		public string Nome { get; set; }
		public string Email { get; set; }
		public string Cpf { get; set; }
		public DateTime DateRegister { get; set; }
	}
	
	public interface IClientRepository
	{
		void AddClient(Client client);
	}
	
	public class ClientRepository : IClientRepository
	{
		public void AddClient(Client client)
		{
			//logica para adicionar client
		}
	}
	
	public interface IClientServices
	{
		void AddClient(Client client);
	}
	
	public class ClientServices : IClientServices
	{
		private readonly IClientRepository _clientRepository;
		
		public ClientServices(IClientRepository clientRepository)
		{
			_clientRepository = clientRepository;
		}
		
		public void AddClient(Client client)
		{
			_clientRepository.AddClient(client);
		}
	}
}
