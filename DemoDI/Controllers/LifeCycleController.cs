using System;
using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
	public class LifeCycleController : Controller
	{
		public OperationService OperationService { get; }
		public OperationService OperationService2 { get; }
		
		public LifeCycleController(OperationService operationService, OperationService operationService2)
		{
			OperationService = operationService;
			OperationService2 = operationService2;
		}
		
		public string Index()
		{
			return 
				"Primeira instência: " + Environment.NewLine + 
				OperationService.Transient.OperationId + Environment.NewLine +
				OperationService.Scoped.OperationId + Environment.NewLine + 
				OperationService.Singleton.OperationId + Environment.NewLine +
				OperationService.SingletonInstance.OperationId + Environment.NewLine +
				
				Environment.NewLine + 
				Environment.NewLine +
				
				"Segunda Instência: " + Environment.NewLine + 
				OperationService2.Transient.OperationId + Environment.NewLine +
				OperationService2.Scoped.OperationId + Environment.NewLine +
				OperationService2.Singleton.OperationId + Environment.NewLine +
				OperationService2.SingletonInstance.OperationId + Environment.NewLine;
		}
	}
}
