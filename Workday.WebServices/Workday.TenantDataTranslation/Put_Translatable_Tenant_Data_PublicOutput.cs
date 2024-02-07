using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.TenantDataTranslation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Translatable_Tenant_Data_PublicOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Translatable_Tenant_Data_Public_ResponseType Put_Translatable_Tenant_Data_Public_Response;

		public Put_Translatable_Tenant_Data_PublicOutput()
		{
		}

		public Put_Translatable_Tenant_Data_PublicOutput(Put_Translatable_Tenant_Data_Public_ResponseType Put_Translatable_Tenant_Data_Public_Response)
		{
			this.Put_Translatable_Tenant_Data_Public_Response = Put_Translatable_Tenant_Data_Public_Response;
		}
	}
}
