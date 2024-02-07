using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_Job_HistoryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Job_History_ResponseType Manage_Job_History_Response;

		public Manage_Job_HistoryOutput()
		{
		}

		public Manage_Job_HistoryOutput(Manage_Job_History_ResponseType Manage_Job_History_Response)
		{
			this.Manage_Job_History_Response = Manage_Job_History_Response;
		}
	}
}
