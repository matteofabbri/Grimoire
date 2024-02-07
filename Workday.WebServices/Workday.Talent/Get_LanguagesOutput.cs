using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_LanguagesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Languages_ResponseType Get_Languages_Response;

		public Get_LanguagesOutput()
		{
		}

		public Get_LanguagesOutput(Get_Languages_ResponseType Get_Languages_Response)
		{
			this.Get_Languages_Response = Get_Languages_Response;
		}
	}
}
