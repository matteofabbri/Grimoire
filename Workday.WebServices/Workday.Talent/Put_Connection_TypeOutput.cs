using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Connection_TypeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Connection_Type_ResponseType Put_Connection_Type_Response;

		public Put_Connection_TypeOutput()
		{
		}

		public Put_Connection_TypeOutput(Put_Connection_Type_ResponseType Put_Connection_Type_Response)
		{
			this.Put_Connection_Type_Response = Put_Connection_Type_Response;
		}
	}
}
