using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Contact_ConnectionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Contact_Connection_ResponseType Put_Contact_Connection_Response;

		public Put_Contact_ConnectionOutput()
		{
		}

		public Put_Contact_ConnectionOutput(Put_Contact_Connection_ResponseType Put_Contact_Connection_Response)
		{
			this.Put_Contact_Connection_Response = Put_Contact_Connection_Response;
		}
	}
}
