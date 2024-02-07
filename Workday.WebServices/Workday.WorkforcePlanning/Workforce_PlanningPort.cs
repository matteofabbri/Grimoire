using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.WorkforcePlanning
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Workforce_Planning", ConfigurationName = "WorkforcePlanning.Workforce_PlanningPort")]
	public interface Workforce_PlanningPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Headcount_Plan_StructuresOutput Get_Headcount_Plan_Structures(Get_Headcount_Plan_StructuresInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Headcount_Plan_StructuresOutput> Get_Headcount_Plan_StructuresAsync(Get_Headcount_Plan_StructuresInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Headcount_Plan_StructureOutput Put_Headcount_Plan_Structure(Put_Headcount_Plan_StructureInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Headcount_Plan_StructureOutput> Put_Headcount_Plan_StructureAsync(Put_Headcount_Plan_StructureInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Maintain_Headcount_PlanOutput Maintain_Headcount_Plan(Maintain_Headcount_PlanInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Maintain_Headcount_PlanOutput> Maintain_Headcount_PlanAsync(Maintain_Headcount_PlanInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Headcount_Plan_TemplatesOutput Get_Headcount_Plan_Templates(Get_Headcount_Plan_TemplatesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Headcount_Plan_TemplatesOutput> Get_Headcount_Plan_TemplatesAsync(Get_Headcount_Plan_TemplatesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Headcount_Plan_TemplateOutput Put_Headcount_Plan_Template(Put_Headcount_Plan_TemplateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Headcount_Plan_TemplateOutput> Put_Headcount_Plan_TemplateAsync(Put_Headcount_Plan_TemplateInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Headcount_PlansOutput Get_Headcount_Plans(Get_Headcount_PlansInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Headcount_PlansOutput> Get_Headcount_PlansAsync(Get_Headcount_PlansInput request);
	}
}
