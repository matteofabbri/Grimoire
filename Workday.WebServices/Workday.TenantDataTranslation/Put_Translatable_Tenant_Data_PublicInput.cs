using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.TenantDataTranslation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Translatable_Tenant_Data_PublicInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Translatable_Tenant_Data_Public_RequestType Put_Translatable_Tenant_Data_Public_Request;

		public Put_Translatable_Tenant_Data_PublicInput()
		{
		}

		public Put_Translatable_Tenant_Data_PublicInput(Workday_Common_HeaderType Workday_Common_Header, Put_Translatable_Tenant_Data_Public_RequestType Put_Translatable_Tenant_Data_Public_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Translatable_Tenant_Data_Public_Request = Put_Translatable_Tenant_Data_Public_Request;
		}
	}
}
