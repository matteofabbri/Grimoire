using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Enroll_in_Retirement_Savings_PlansOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Enroll_in_Retirement_Savings_Plans_ResponseType Enroll_in_Retirement_Savings_Plans_Response;

		public Enroll_in_Retirement_Savings_PlansOutput()
		{
		}

		public Enroll_in_Retirement_Savings_PlansOutput(Enroll_in_Retirement_Savings_Plans_ResponseType Enroll_in_Retirement_Savings_Plans_Response)
		{
			this.Enroll_in_Retirement_Savings_Plans_Response = Enroll_in_Retirement_Savings_Plans_Response;
		}
	}
}
