using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.ProfessionalServicesAutomation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Professional_Services_Automation", ConfigurationName = "ProfessionalServicesAutomation.Professional_Services_AutomationPort")]
	public interface Professional_Services_AutomationPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Add_Update_Expense_ReportOutput Add_Update_Expense_Report(Add_Update_Expense_ReportInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Add_Update_Expense_ReportOutput> Add_Update_Expense_ReportAsync(Add_Update_Expense_ReportInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_Expense_Report_OldOutput Cancel_Expense_Report_Old(Cancel_Expense_Report_OldInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_Expense_Report_OldOutput> Cancel_Expense_Report_OldAsync(Cancel_Expense_Report_OldInput request);
	}
}
