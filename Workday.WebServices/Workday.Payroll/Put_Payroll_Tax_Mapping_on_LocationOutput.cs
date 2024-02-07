using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payroll_Tax_Mapping_on_LocationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Payroll_Tax_Mapping_on_Location_ResponseType Put_Payroll_Tax_Mapping_on_Location_Response;

		public Put_Payroll_Tax_Mapping_on_LocationOutput()
		{
		}

		public Put_Payroll_Tax_Mapping_on_LocationOutput(Put_Payroll_Tax_Mapping_on_Location_ResponseType Put_Payroll_Tax_Mapping_on_Location_Response)
		{
			this.Put_Payroll_Tax_Mapping_on_Location_Response = Put_Payroll_Tax_Mapping_on_Location_Response;
		}
	}
}
