using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_LanguagesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Languages_ResponseType Manage_Languages_Response;

		public Manage_LanguagesOutput()
		{
		}

		public Manage_LanguagesOutput(Manage_Languages_ResponseType Manage_Languages_Response)
		{
			this.Manage_Languages_Response = Manage_Languages_Response;
		}
	}
}
