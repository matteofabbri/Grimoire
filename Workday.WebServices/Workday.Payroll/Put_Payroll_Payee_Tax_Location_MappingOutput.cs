using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payroll_Payee_Tax_Location_MappingOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Payroll_Payee_Tax_Location_Mapping_ResponseType Put_Payroll_Payee_Tax_Location_Mapping_Response;

		public Put_Payroll_Payee_Tax_Location_MappingOutput()
		{
		}

		public Put_Payroll_Payee_Tax_Location_MappingOutput(Put_Payroll_Payee_Tax_Location_Mapping_ResponseType Put_Payroll_Payee_Tax_Location_Mapping_Response)
		{
			this.Put_Payroll_Payee_Tax_Location_Mapping_Response = Put_Payroll_Payee_Tax_Location_Mapping_Response;
		}
	}
}
