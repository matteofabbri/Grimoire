using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Loan_Investor_TypeInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Loan_Investor_Type_RequestType Put_Loan_Investor_Type_Request;

		public Put_Loan_Investor_TypeInput()
		{
		}

		public Put_Loan_Investor_TypeInput(Workday_Common_HeaderType Workday_Common_Header, Put_Loan_Investor_Type_RequestType Put_Loan_Investor_Type_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Loan_Investor_Type_Request = Put_Loan_Investor_Type_Request;
		}
	}
}
