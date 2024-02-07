using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.DynamicDocumentGeneration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Dynamic_Document_Generation", ConfigurationName = "Dynamic_Document_GenerationService.Dynamic_Document_GenerationPort")]
	public interface Dynamic_Document_GenerationPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Text_Block_CategoriesOutput Get_Text_Block_Categories(Get_Text_Block_CategoriesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Text_Block_CategoriesOutput> Get_Text_Block_CategoriesAsync(Get_Text_Block_CategoriesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Text_Block_CategoryOutput Put_Text_Block_Category(Put_Text_Block_CategoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Text_Block_CategoryOutput> Put_Text_Block_CategoryAsync(Put_Text_Block_CategoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Text_BlocksOutput Get_Text_Blocks(Get_Text_BlocksInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Text_BlocksOutput> Get_Text_BlocksAsync(Get_Text_BlocksInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Text_BlockOutput Put_Text_Block(Put_Text_BlockInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Text_BlockOutput> Put_Text_BlockAsync(Put_Text_BlockInput request);
	}
}
