using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_CustomerOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Customer_ResponseType Put_Customer_Response;

		public Put_CustomerOutput()
		{
		}

		public Put_CustomerOutput(Put_Customer_ResponseType Put_Customer_Response)
		{
			this.Put_Customer_Response = Put_Customer_Response;
		}
	}
}
