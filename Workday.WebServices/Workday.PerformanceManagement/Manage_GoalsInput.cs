using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_GoalsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Goals_RequestType Manage_Goals_Request;

		public Manage_GoalsInput()
		{
		}

		public Manage_GoalsInput(Workday_Common_HeaderType Workday_Common_Header, Manage_Goals_RequestType Manage_Goals_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Manage_Goals_Request = Manage_Goals_Request;
		}
	}
}
