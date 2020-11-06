using System;


namespace DemoDI.Cases
{
	public class OperationService
	{
		public OperationService(
			IOperationTransient operationTransient,
			IOperationScoped operationScoped,
			IOperationSingleton operationSingleton,
			IOperationSingletonInstance operationSingletonInstance
		)
		{
			Transient = operationTransient;
			Scoped = operationScoped;
			Singleton = operationSingleton;
			SingletonInstance = operationSingletonInstance;
		}
		
		public IOperationTransient Transient { get; }
		public IOperationScoped Scoped { get; }
		public IOperationSingleton Singleton { get; }
		public IOperationSingletonInstance SingletonInstance { get; }
	}
	
	public class Operation : IOperationTransient, IOperationScoped, IOperationSingleton, IOperationSingletonInstance
	{
		public Operation() : this(Guid.NewGuid()){}
		
		public Operation(Guid id)
		{
			OperationId = id;
		}
		
		public Guid OperationId { get; }
	}
	
	public interface IOperation
	{
		Guid OperationId { get; }
	}
	
	public interface IOperationTransient : IOperation {}
	
	public interface IOperationScoped : IOperation {}
	
	public interface IOperationSingleton : IOperation {}
	
	public interface IOperationSingletonInstance : IOperation {}
}
