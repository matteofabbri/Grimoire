using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Contact_TypesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Contact_Types_ResponseType Get_Contact_Types_Response;

		public Get_Contact_TypesOutput()
		{
		}

		public Get_Contact_TypesOutput(Get_Contact_Types_ResponseType Get_Contact_Types_Response)
		{
			this.Get_Contact_Types_Response = Get_Contact_Types_Response;
		}
	}
}
