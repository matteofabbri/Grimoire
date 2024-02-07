using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Talent_Statement_TypesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Talent_Statement_Types_ResponseType Get_Talent_Statement_Types_Response;

		public Get_Talent_Statement_TypesOutput()
		{
		}

		public Get_Talent_Statement_TypesOutput(Get_Talent_Statement_Types_ResponseType Get_Talent_Statement_Types_Response)
		{
			this.Get_Talent_Statement_Types_Response = Get_Talent_Statement_Types_Response;
		}
	}
}
