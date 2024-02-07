using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_Awards_and_ActivitiesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Awards_and_Activities_RequestType Manage_Awards_and_Activities_Request;

		public Manage_Awards_and_ActivitiesInput()
		{
		}

		public Manage_Awards_and_ActivitiesInput(Workday_Common_HeaderType Workday_Common_Header, Manage_Awards_and_Activities_RequestType Manage_Awards_and_Activities_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Manage_Awards_and_Activities_Request = Manage_Awards_and_Activities_Request;
		}
	}
}
