using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_External_Payroll_ActualsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_External_Payroll_Actuals_RequestType Put_External_Payroll_Actuals_Request;

		public Put_External_Payroll_ActualsInput()
		{
		}

		public Put_External_Payroll_ActualsInput(Workday_Common_HeaderType Workday_Common_Header, Put_External_Payroll_Actuals_RequestType Put_External_Payroll_Actuals_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_External_Payroll_Actuals_Request = Put_External_Payroll_Actuals_Request;
		}
	}
}
