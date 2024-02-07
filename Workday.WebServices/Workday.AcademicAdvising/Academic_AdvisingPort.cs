using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.AcademicAdvising
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Academic_Advising", ConfigurationName = "Academic_AdvisingService.Academic_AdvisingPort")]
	public interface Academic_AdvisingPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Academic_Progress_for_StudentOutput Get_Academic_Progress_for_Student(Get_Academic_Progress_for_StudentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Academic_Progress_for_StudentOutput> Get_Academic_Progress_for_StudentAsync(Get_Academic_Progress_for_StudentInput request);
	}
}
