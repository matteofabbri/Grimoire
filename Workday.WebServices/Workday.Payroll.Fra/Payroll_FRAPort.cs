using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.Payroll.Fra
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Payroll_FRA", ConfigurationName = "Payroll.Fra.Payroll_FRAPort")]
	public interface Payroll_FRAPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_DSN_DataOutput Get_DSN_Data(Get_DSN_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_DSN_DataOutput> Get_DSN_DataAsync(Get_DSN_DataInput request);
	}
}
