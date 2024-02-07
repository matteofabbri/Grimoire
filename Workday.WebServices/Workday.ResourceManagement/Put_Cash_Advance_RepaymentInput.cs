using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Cash_Advance_RepaymentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Cash_Advance_Repayment_RequestType Put_Cash_Advance_Repayment_Request;

		public Put_Cash_Advance_RepaymentInput()
		{
		}

		public Put_Cash_Advance_RepaymentInput(Workday_Common_HeaderType Workday_Common_Header, Put_Cash_Advance_Repayment_RequestType Put_Cash_Advance_Repayment_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Cash_Advance_Repayment_Request = Put_Cash_Advance_Repayment_Request;
		}
	}
}
