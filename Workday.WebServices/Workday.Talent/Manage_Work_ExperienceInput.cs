using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_Work_ExperienceInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Work_Experience_RequestType Manage_Work_Experience_Request;

		public Manage_Work_ExperienceInput()
		{
		}

		public Manage_Work_ExperienceInput(Workday_Common_HeaderType Workday_Common_Header, Manage_Work_Experience_RequestType Manage_Work_Experience_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Manage_Work_Experience_Request = Manage_Work_Experience_Request;
		}
	}
}
