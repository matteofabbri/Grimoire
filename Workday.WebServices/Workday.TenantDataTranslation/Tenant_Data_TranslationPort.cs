using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.TenantDataTranslation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Tenant_Data_Translation", ConfigurationName = "TenantDataTranslation.Tenant_Data_TranslationPort")]
	public interface Tenant_Data_TranslationPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Translatable_Tenant_Data_PublicOutput Get_Translatable_Tenant_Data_Public(Get_Translatable_Tenant_Data_PublicInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Translatable_Tenant_Data_PublicOutput> Get_Translatable_Tenant_Data_PublicAsync(Get_Translatable_Tenant_Data_PublicInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Translatable_Tenant_Data_PublicOutput Put_Translatable_Tenant_Data_Public(Put_Translatable_Tenant_Data_PublicInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Translatable_Tenant_Data_PublicOutput> Put_Translatable_Tenant_Data_PublicAsync(Put_Translatable_Tenant_Data_PublicInput request);
	}
}
