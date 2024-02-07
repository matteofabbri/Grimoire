using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Citizenship_StatusesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Citizenship_Statuses_RequestType Get_Citizenship_Statuses_Request;

		public Get_Citizenship_StatusesInput()
		{
		}

		public Get_Citizenship_StatusesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Citizenship_Statuses_RequestType Get_Citizenship_Statuses_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Citizenship_Statuses_Request = Get_Citizenship_Statuses_Request;
		}
	}
}
