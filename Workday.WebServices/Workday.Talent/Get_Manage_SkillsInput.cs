using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Manage_SkillsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Manage_Skills_RequestType Get_Manage_Skills_Request;

		public Get_Manage_SkillsInput()
		{
		}

		public Get_Manage_SkillsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Manage_Skills_RequestType Get_Manage_Skills_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Manage_Skills_Request = Get_Manage_Skills_Request;
		}
	}
}
