using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.SettlementServices
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Settlement_Services", ConfigurationName = "SettlementServices.Settlement_ServicesPort")]
	public interface Settlement_ServicesPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payment_TypesOutput Get_Payment_Types(Get_Payment_TypesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payment_TypesOutput> Get_Payment_TypesAsync(Get_Payment_TypesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payment_TypeOutput Put_Payment_Type(Put_Payment_TypeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payment_TypeOutput> Put_Payment_TypeAsync(Put_Payment_TypeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payment_Acknowledgement_MessageOutput Put_Payment_Acknowledgement_Message(Put_Payment_Acknowledgement_MessageInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payment_Acknowledgement_MessageOutput> Put_Payment_Acknowledgement_MessageAsync(Put_Payment_Acknowledgement_MessageInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_PaymentsOutput Get_Payments(Get_PaymentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_PaymentsOutput> Get_PaymentsAsync(Get_PaymentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payment_MessagesOutput Get_Payment_Messages(Get_Payment_MessagesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payment_MessagesOutput> Get_Payment_MessagesAsync(Get_Payment_MessagesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Escheatment_ItemsOutput Get_Escheatment_Items(Get_Escheatment_ItemsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Escheatment_ItemsOutput> Get_Escheatment_ItemsAsync(Get_Escheatment_ItemsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Escheatment_ItemsOutput Submit_Escheatment_Items(Submit_Escheatment_ItemsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Escheatment_ItemsOutput> Submit_Escheatment_ItemsAsync(Submit_Escheatment_ItemsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Escheatable_Payment_Notification_DateOutput Put_Escheatable_Payment_Notification_Date(Put_Escheatable_Payment_Notification_DateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Escheatable_Payment_Notification_DateOutput> Put_Escheatable_Payment_Notification_DateAsync(Put_Escheatable_Payment_Notification_DateInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Settlement_RunOutput Submit_Settlement_Run(Submit_Settlement_RunInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Settlement_RunOutput> Submit_Settlement_RunAsync(Submit_Settlement_RunInput request);
	}
}
