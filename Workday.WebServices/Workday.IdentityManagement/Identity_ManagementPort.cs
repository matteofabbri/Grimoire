using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.IdentityManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Identity_Management", ConfigurationName = "Identity_ManagementService.Identity_ManagementPort")]
	public interface Identity_ManagementPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Unidentified_SignonsOutput Get_Unidentified_Signons(Get_Unidentified_SignonsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Unidentified_SignonsOutput> Get_Unidentified_SignonsAsync(Get_Unidentified_SignonsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Workday_Account_SignonsOutput Get_Workday_Account_Signons(Get_Workday_Account_SignonsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Workday_Account_SignonsOutput> Get_Workday_Account_SignonsAsync(Get_Workday_Account_SignonsInput request);
	}
}
