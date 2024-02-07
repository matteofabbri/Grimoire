using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Enroll_in_Retirement_Savings_PlansInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Enroll_in_Retirement_Savings_Plans_RequestType Enroll_in_Retirement_Savings_Plans_Request;

		public Enroll_in_Retirement_Savings_PlansInput()
		{
		}

		public Enroll_in_Retirement_Savings_PlansInput(Workday_Common_HeaderType Workday_Common_Header, Enroll_in_Retirement_Savings_Plans_RequestType Enroll_in_Retirement_Savings_Plans_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Enroll_in_Retirement_Savings_Plans_Request = Enroll_in_Retirement_Savings_Plans_Request;
		}
	}
}
