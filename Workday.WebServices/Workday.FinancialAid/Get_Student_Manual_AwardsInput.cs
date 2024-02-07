using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Student_Manual_AwardsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Student_Manual_Awards_RequestType Get_Student_Manual_Awards_Request;

		public Get_Student_Manual_AwardsInput()
		{
		}

		public Get_Student_Manual_AwardsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Manual_Awards_RequestType Get_Student_Manual_Awards_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Student_Manual_Awards_Request = Get_Student_Manual_Awards_Request;
		}
	}
}
