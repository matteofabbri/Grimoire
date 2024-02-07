using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.Payroll.Can
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Payroll_CAN", ConfigurationName = "Payroll_CANService.Payroll_CANPort")]
	public interface Payroll_CANPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_CAN_Year_End_FormsOutput Get_Payroll_CAN_Year_End_Forms(Get_Payroll_CAN_Year_End_FormsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_CAN_Year_End_FormsOutput> Get_Payroll_CAN_Year_End_FormsAsync(Get_Payroll_CAN_Year_End_FormsInput request);
	}
}
