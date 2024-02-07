using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_SkillsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Skills_RequestType Manage_Skills_Request;

		public Manage_SkillsInput()
		{
		}

		public Manage_SkillsInput(Workday_Common_HeaderType Workday_Common_Header, Manage_Skills_RequestType Manage_Skills_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Manage_Skills_Request = Manage_Skills_Request;
		}
	}
}
