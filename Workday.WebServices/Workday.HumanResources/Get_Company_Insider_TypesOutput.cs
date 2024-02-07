using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Company_Insider_TypesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Company_Insider_Types_ResponseType Get_Company_Insider_Types_Response;

		public Get_Company_Insider_TypesOutput()
		{
		}

		public Get_Company_Insider_TypesOutput(Get_Company_Insider_Types_ResponseType Get_Company_Insider_Types_Response)
		{
			this.Get_Company_Insider_Types_Response = Get_Company_Insider_Types_Response;
		}
	}
}
