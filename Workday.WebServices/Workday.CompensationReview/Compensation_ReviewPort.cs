using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.CompensationReview
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Compensation_Review", ConfigurationName = "Compensation_ReviewService.Compensation_ReviewPort")]
	public interface Compensation_ReviewPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Budget_PoolsOutput Get_Budget_Pools(Get_Budget_PoolsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Budget_PoolsOutput> Get_Budget_PoolsAsync(Get_Budget_PoolsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Employee_AwardsOutput Get_Employee_Awards(Get_Employee_AwardsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Employee_AwardsOutput> Get_Employee_AwardsAsync(Get_Employee_AwardsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Budget_PoolsOutput Import_Budget_Pools(Import_Budget_PoolsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Budget_PoolsOutput> Import_Budget_PoolsAsync(Import_Budget_PoolsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Budget_PoolsOutput Import_Employee_Awards(Import_Employee_AwardsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Budget_PoolsOutput> Import_Employee_AwardsAsync(Import_Employee_AwardsInput request);
	}
}
