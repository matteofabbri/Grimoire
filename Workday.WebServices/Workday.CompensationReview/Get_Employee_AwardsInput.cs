using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CompensationReview
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Employee_AwardsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Employee_Awards_RequestType Get_Employee_Awards_Request;

		public Get_Employee_AwardsInput()
		{
		}

		public Get_Employee_AwardsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Employee_Awards_RequestType Get_Employee_Awards_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Employee_Awards_Request = Get_Employee_Awards_Request;
		}
	}
}
