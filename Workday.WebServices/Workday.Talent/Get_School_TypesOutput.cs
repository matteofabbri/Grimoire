using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_School_TypesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_School_Types_ResponseType Get_School_Types_Response;

		public Get_School_TypesOutput()
		{
		}

		public Get_School_TypesOutput(Get_School_Types_ResponseType Get_School_Types_Response)
		{
			this.Get_School_Types_Response = Get_School_Types_Response;
		}
	}
}
