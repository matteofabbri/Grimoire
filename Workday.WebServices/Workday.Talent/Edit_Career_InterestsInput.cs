using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_Career_InterestsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Edit_Career_Interests_RequestType Edit_Career_Interests_Request;

		public Edit_Career_InterestsInput()
		{
		}

		public Edit_Career_InterestsInput(Workday_Common_HeaderType Workday_Common_Header, Edit_Career_Interests_RequestType Edit_Career_Interests_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Edit_Career_Interests_Request = Edit_Career_Interests_Request;
		}
	}
}
