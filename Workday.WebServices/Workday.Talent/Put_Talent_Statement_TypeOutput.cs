using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Talent_Statement_TypeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Talent_Statement_Type_ResponseType Put_Talent_Statement_Type_Response;

		public Put_Talent_Statement_TypeOutput()
		{
		}

		public Put_Talent_Statement_TypeOutput(Put_Talent_Statement_Type_ResponseType Put_Talent_Statement_Type_Response)
		{
			this.Put_Talent_Statement_Type_Response = Put_Talent_Statement_Type_Response;
		}
	}
}
