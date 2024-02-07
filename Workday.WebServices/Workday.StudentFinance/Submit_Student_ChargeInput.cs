using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentFinance
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Student_ChargeInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Student_Charge_RequestType Submit_Student_Charge_Request;

		public Submit_Student_ChargeInput()
		{
		}

		public Submit_Student_ChargeInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Student_Charge_RequestType Submit_Student_Charge_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Student_Charge_Request = Submit_Student_Charge_Request;
		}
	}
}
