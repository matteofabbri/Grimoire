using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_Hiring_RestrictionsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Edit_Hiring_Restrictions_RequestType Edit_Hiring_Restrictions_Request;

		public Edit_Hiring_RestrictionsInput()
		{
		}

		public Edit_Hiring_RestrictionsInput(Workday_Common_HeaderType Workday_Common_Header, Edit_Hiring_Restrictions_RequestType Edit_Hiring_Restrictions_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Edit_Hiring_Restrictions_Request = Edit_Hiring_Restrictions_Request;
		}
	}
}
