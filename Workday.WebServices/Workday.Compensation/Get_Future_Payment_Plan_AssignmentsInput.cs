using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Future_Payment_Plan_AssignmentsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Future_Payment_Plan_Assignments_RequestType Get_Future_Payment_Plan_Assignments_Request;

		public Get_Future_Payment_Plan_AssignmentsInput()
		{
		}

		public Get_Future_Payment_Plan_AssignmentsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Future_Payment_Plan_Assignments_RequestType Get_Future_Payment_Plan_Assignments_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Future_Payment_Plan_Assignments_Request = Get_Future_Payment_Plan_Assignments_Request;
		}
	}
}
