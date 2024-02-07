using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.TenantDataTranslation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Translatable_Tenant_Data_PublicInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Translatable_Tenant_Data_Public_RequestType Get_Translatable_Tenant_Data_Public_Request;

		public Get_Translatable_Tenant_Data_PublicInput()
		{
		}

		public Get_Translatable_Tenant_Data_PublicInput(Workday_Common_HeaderType Workday_Common_Header, Get_Translatable_Tenant_Data_Public_RequestType Get_Translatable_Tenant_Data_Public_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Translatable_Tenant_Data_Public_Request = Get_Translatable_Tenant_Data_Public_Request;
		}
	}
}
