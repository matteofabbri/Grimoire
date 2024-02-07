using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_PublicationsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Publications_RequestType Manage_Publications_Request;

		public Manage_PublicationsInput()
		{
		}

		public Manage_PublicationsInput(Workday_Common_HeaderType Workday_Common_Header, Manage_Publications_RequestType Manage_Publications_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Manage_Publications_Request = Manage_Publications_Request;
		}
	}
}
