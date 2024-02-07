using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_Career_InterestsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Career_Interest_ResponseType Manage_Career_Interest_Response;

		public Edit_Career_InterestsOutput()
		{
		}

		public Edit_Career_InterestsOutput(Manage_Career_Interest_ResponseType Manage_Career_Interest_Response)
		{
			this.Manage_Career_Interest_Response = Manage_Career_Interest_Response;
		}
	}
}
