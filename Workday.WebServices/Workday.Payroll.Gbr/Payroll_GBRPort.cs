using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Payroll_GBR", ConfigurationName = "Payroll.Gbr.Payroll_GBRPort")]
	public interface Payroll_GBRPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payee_Tax_CodeOutput Put_Payee_Tax_Code(Put_Payee_Tax_CodeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payee_Tax_CodeOutput> Put_Payee_Tax_CodeAsync(Put_Payee_Tax_CodeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payee_Tax_CodesOutput Get_Payee_Tax_Codes(Get_Payee_Tax_CodesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payee_Tax_CodesOutput> Get_Payee_Tax_CodesAsync(Get_Payee_Tax_CodesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payroll_Payee_Student_LoanOutput Put_Payroll_Payee_Student_Loan(Put_Payroll_Payee_Student_LoanInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payroll_Payee_Student_LoanOutput> Put_Payroll_Payee_Student_LoanAsync(Put_Payroll_Payee_Student_LoanInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_Payee_Student_LoansOutput Get_Payroll_Payee_Student_Loans(Get_Payroll_Payee_Student_LoansInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_Payee_Student_LoansOutput> Get_Payroll_Payee_Student_LoansAsync(Get_Payroll_Payee_Student_LoansInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payroll_Payee_NIOutput Put_Payroll_Payee_NI(Put_Payroll_Payee_NIInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payroll_Payee_NIOutput> Put_Payroll_Payee_NIAsync(Put_Payroll_Payee_NIInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_Payee_NIsOutput Get_Payroll_Payee_NIs(Get_Payroll_Payee_NIsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_Payee_NIsOutput> Get_Payroll_Payee_NIsAsync(Get_Payroll_Payee_NIsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_IDsOutput Get_Payroll_IDs(Get_Payroll_IDsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_IDsOutput> Get_Payroll_IDsAsync(Get_Payroll_IDsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payroll_IDOutput Put_Payroll_ID(Put_Payroll_IDInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payroll_IDOutput> Put_Payroll_IDAsync(Put_Payroll_IDInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payroll_SSP_HistoryOutput Put_Payroll_SSP_History(Put_Payroll_SSP_HistoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payroll_SSP_HistoryOutput> Put_Payroll_SSP_HistoryAsync(Put_Payroll_SSP_HistoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_SSP_HistoryOutput Get_Payroll_SSP_History(Get_Payroll_SSP_HistoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_SSP_HistoryOutput> Get_Payroll_SSP_HistoryAsync(Get_Payroll_SSP_HistoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Pensions_Auto_Enrolment_External_Assessment_HistoryOutput Put_Pensions_Auto_Enrolment_External_Assessment_History(Put_Pensions_Auto_Enrolment_External_Assessment_HistoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Pensions_Auto_Enrolment_External_Assessment_HistoryOutput> Put_Pensions_Auto_Enrolment_External_Assessment_HistoryAsync(Put_Pensions_Auto_Enrolment_External_Assessment_HistoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Pensions_Auto_Enrolment_External_Assessment_HistoryOutput Get_Pensions_Auto_Enrolment_External_Assessment_History(Get_Pensions_Auto_Enrolment_External_Assessment_HistoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Pensions_Auto_Enrolment_External_Assessment_HistoryOutput> Get_Pensions_Auto_Enrolment_External_Assessment_HistoryAsync(Get_Pensions_Auto_Enrolment_External_Assessment_HistoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Worker_Pensions_Auto_Enrolment_DetailsOutput Put_Worker_Pensions_Auto_Enrolment_Details(Put_Worker_Pensions_Auto_Enrolment_DetailsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Worker_Pensions_Auto_Enrolment_DetailsOutput> Put_Worker_Pensions_Auto_Enrolment_DetailsAsync(Put_Worker_Pensions_Auto_Enrolment_DetailsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Worker_Pensions_Auto_Enrolment_DetailsOutput Get_Worker_Pensions_Auto_Enrolment_Details(Get_Worker_Pensions_Auto_Enrolment_DetailsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Worker_Pensions_Auto_Enrolment_DetailsOutput> Get_Worker_Pensions_Auto_Enrolment_DetailsAsync(Get_Worker_Pensions_Auto_Enrolment_DetailsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payroll_Payee_RTIOutput Put_Payroll_Payee_RTI(Put_Payroll_Payee_RTIInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payroll_Payee_RTIOutput> Put_Payroll_Payee_RTIAsync(Put_Payroll_Payee_RTIInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_Payee_RTIsOutput Get_Payroll_Payee_RTIs(Get_Payroll_Payee_RTIsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_Payee_RTIsOutput> Get_Payroll_Payee_RTIsAsync(Get_Payroll_Payee_RTIsInput request);
	}
}
