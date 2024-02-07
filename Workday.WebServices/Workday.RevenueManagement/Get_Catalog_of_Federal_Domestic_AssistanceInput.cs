using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Catalog_of_Federal_Domestic_AssistanceInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Catalog_of_Federal_Domestic_Assistance_RequestType Get_Catalog_of_Federal_Domestic_Assistance_Request;

		public Get_Catalog_of_Federal_Domestic_AssistanceInput()
		{
		}

		public Get_Catalog_of_Federal_Domestic_AssistanceInput(Workday_Common_HeaderType Workday_Common_Header, Get_Catalog_of_Federal_Domestic_Assistance_RequestType Get_Catalog_of_Federal_Domestic_Assistance_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Catalog_of_Federal_Domestic_Assistance_Request = Get_Catalog_of_Federal_Domestic_Assistance_Request;
		}
	}
}
