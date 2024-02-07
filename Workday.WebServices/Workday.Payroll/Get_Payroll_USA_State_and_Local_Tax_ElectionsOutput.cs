using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payroll_USA_State_and_Local_Tax_ElectionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Payroll_USA_State_and_Local_Tax_Elections_ResponseType Get_Payroll_USA_State_and_Local_Tax_Elections_Response;

		public Get_Payroll_USA_State_and_Local_Tax_ElectionsOutput()
		{
		}

		public Get_Payroll_USA_State_and_Local_Tax_ElectionsOutput(Get_Payroll_USA_State_and_Local_Tax_Elections_ResponseType Get_Payroll_USA_State_and_Local_Tax_Elections_Response)
		{
			this.Get_Payroll_USA_State_and_Local_Tax_Elections_Response = Get_Payroll_USA_State_and_Local_Tax_Elections_Response;
		}
	}
}
