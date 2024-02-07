using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payee_Tax_CodeInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Payee_Tax_Code_RequestType Put_Payee_Tax_Code_Request;

		public Put_Payee_Tax_CodeInput()
		{
		}

		public Put_Payee_Tax_CodeInput(Workday_Common_HeaderType Workday_Common_Header, Put_Payee_Tax_Code_RequestType Put_Payee_Tax_Code_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Payee_Tax_Code_Request = Put_Payee_Tax_Code_Request;
		}
	}
}
