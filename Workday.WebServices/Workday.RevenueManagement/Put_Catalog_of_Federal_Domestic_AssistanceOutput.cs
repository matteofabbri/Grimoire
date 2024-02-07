using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Catalog_of_Federal_Domestic_AssistanceOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Catalog_of_Federal_Domestic_Assistance_ResponseType Put_Catalog_of_Federal_Domestic_Assistance_Response;

		public Put_Catalog_of_Federal_Domestic_AssistanceOutput()
		{
		}

		public Put_Catalog_of_Federal_Domestic_AssistanceOutput(Put_Catalog_of_Federal_Domestic_Assistance_ResponseType Put_Catalog_of_Federal_Domestic_Assistance_Response)
		{
			this.Put_Catalog_of_Federal_Domestic_Assistance_Response = Put_Catalog_of_Federal_Domestic_Assistance_Response;
		}
	}
}
