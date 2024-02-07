using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_GoalsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Goals_ResponseType Manage_Goals_Response;

		public Manage_GoalsOutput()
		{
		}

		public Manage_GoalsOutput(Manage_Goals_ResponseType Manage_Goals_Response)
		{
			this.Manage_Goals_Response = Manage_Goals_Response;
		}
	}
}
