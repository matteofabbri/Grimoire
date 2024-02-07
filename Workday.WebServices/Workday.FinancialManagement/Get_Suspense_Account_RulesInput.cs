using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Suspense_Account_RulesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Suspense_Account_Rules_RequestType Get_Suspense_Account_Rules_Request;

		public Get_Suspense_Account_RulesInput()
		{
		}

		public Get_Suspense_Account_RulesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Suspense_Account_Rules_RequestType Get_Suspense_Account_Rules_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Suspense_Account_Rules_Request = Get_Suspense_Account_Rules_Request;
		}
	}
}
