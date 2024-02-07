using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Business_ConnectionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Business_Connection_ResponseType Put_Business_Connection_Response;

		public Put_Business_ConnectionOutput()
		{
		}

		public Put_Business_ConnectionOutput(Put_Business_Connection_ResponseType Put_Business_Connection_Response)
		{
			this.Put_Business_Connection_Response = Put_Business_Connection_Response;
		}
	}
}
