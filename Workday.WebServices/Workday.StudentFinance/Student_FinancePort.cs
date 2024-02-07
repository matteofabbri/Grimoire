using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.StudentFinance
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Student_Finance", ConfigurationName = "StudentFinance.Student_FinancePort")]
	public interface Student_FinancePort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_ChargesOutput Get_Student_Charges(Get_Student_ChargesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_ChargesOutput> Get_Student_ChargesAsync(Get_Student_ChargesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Student_ChargeOutput Submit_Student_Charge(Submit_Student_ChargeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Student_ChargeOutput> Submit_Student_ChargeAsync(Submit_Student_ChargeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Historical_ChargesOutput Get_Student_Historical_Charges(Get_Student_Historical_ChargesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Historical_ChargesOutput> Get_Student_Historical_ChargesAsync(Get_Student_Historical_ChargesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Historical_PaymentsOutput Get_Student_Historical_Payments(Get_Student_Historical_PaymentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Historical_PaymentsOutput> Get_Student_Historical_PaymentsAsync(Get_Student_Historical_PaymentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Student_ChargesOutput Import_Student_Charges(Import_Student_ChargesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Student_ChargesOutput> Import_Student_ChargesAsync(Import_Student_ChargesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Student_ChargesOutput Import_Student_Historical_Charges(Import_Student_Historical_ChargesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Student_ChargesOutput> Import_Student_Historical_ChargesAsync(Import_Student_Historical_ChargesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Student_ChargesOutput Import_Student_Historical_Payment(Import_Student_Historical_PaymentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Student_ChargesOutput> Import_Student_Historical_PaymentAsync(Import_Student_Historical_PaymentInput request);
	}
}
