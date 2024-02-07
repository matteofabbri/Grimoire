using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Catalog_of_Federal_Domestic_AssistanceInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Catalog_of_Federal_Domestic_Assistance_RequestType Put_Catalog_of_Federal_Domestic_Assistance_Request;

		public Put_Catalog_of_Federal_Domestic_AssistanceInput()
		{
		}

		public Put_Catalog_of_Federal_Domestic_AssistanceInput(Workday_Common_HeaderType Workday_Common_Header, Put_Catalog_of_Federal_Domestic_Assistance_RequestType Put_Catalog_of_Federal_Domestic_Assistance_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Catalog_of_Federal_Domestic_Assistance_Request = Put_Catalog_of_Federal_Domestic_Assistance_Request;
		}
	}
}
