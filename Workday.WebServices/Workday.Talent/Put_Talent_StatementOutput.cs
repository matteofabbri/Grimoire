using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Talent_StatementOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Talent_Statement_ResponseType Put_Talent_Statement_Response;

		public Put_Talent_StatementOutput()
		{
		}

		public Put_Talent_StatementOutput(Put_Talent_Statement_ResponseType Put_Talent_Statement_Response)
		{
			this.Put_Talent_Statement_Response = Put_Talent_Statement_Response;
		}
	}
}
