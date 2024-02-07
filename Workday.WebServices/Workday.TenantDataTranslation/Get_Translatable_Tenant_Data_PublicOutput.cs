using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.TenantDataTranslation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Translatable_Tenant_Data_PublicOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Translatable_Tenant_Data_Public_ResponseType Get_Translatable_Tenant_Data_Public_Response;

		public Get_Translatable_Tenant_Data_PublicOutput()
		{
		}

		public Get_Translatable_Tenant_Data_PublicOutput(Get_Translatable_Tenant_Data_Public_ResponseType Get_Translatable_Tenant_Data_Public_Response)
		{
			this.Get_Translatable_Tenant_Data_Public_Response = Get_Translatable_Tenant_Data_Public_Response;
		}
	}
}
