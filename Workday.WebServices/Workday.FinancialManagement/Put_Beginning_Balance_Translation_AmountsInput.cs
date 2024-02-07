using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Beginning_Balance_Translation_AmountsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Beginning_Balance_Translation_Amounts_RequestType Put_Beginning_Balance_Translation_Amounts_Request;

		public Put_Beginning_Balance_Translation_AmountsInput()
		{
		}

		public Put_Beginning_Balance_Translation_AmountsInput(Workday_Common_HeaderType Workday_Common_Header, Put_Beginning_Balance_Translation_Amounts_RequestType Put_Beginning_Balance_Translation_Amounts_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Beginning_Balance_Translation_Amounts_Request = Put_Beginning_Balance_Translation_Amounts_Request;
		}
	}
}
