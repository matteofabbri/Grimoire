using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Catalog_of_Federal_Domestic_AssistanceOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Catalog_of_Federal_Domestic_Assistance_ResponseType Get_Catalog_of_Federal_Domestic_Assistance_Response;

		public Get_Catalog_of_Federal_Domestic_AssistanceOutput()
		{
		}

		public Get_Catalog_of_Federal_Domestic_AssistanceOutput(Get_Catalog_of_Federal_Domestic_Assistance_ResponseType Get_Catalog_of_Federal_Domestic_Assistance_Response)
		{
			this.Get_Catalog_of_Federal_Domestic_Assistance_Response = Get_Catalog_of_Federal_Domestic_Assistance_Response;
		}
	}
}
