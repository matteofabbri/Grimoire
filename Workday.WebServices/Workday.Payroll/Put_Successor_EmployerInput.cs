using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Successor_EmployerInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Successor_Employer_RequestType Put_Successor_Employer_Request;

		public Put_Successor_EmployerInput()
		{
		}

		public Put_Successor_EmployerInput(Workday_Common_HeaderType Workday_Common_Header, Put_Successor_Employer_RequestType Put_Successor_Employer_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Successor_Employer_Request = Put_Successor_Employer_Request;
		}
	}
}
