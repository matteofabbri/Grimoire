using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Connection_TypesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Connection_Types_ResponseType Get_Connection_Types_Response;

		public Get_Connection_TypesOutput()
		{
		}

		public Get_Connection_TypesOutput(Get_Connection_Types_ResponseType Get_Connection_Types_Response)
		{
			this.Get_Connection_Types_Response = Get_Connection_Types_Response;
		}
	}
}
