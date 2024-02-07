using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payroll_Federal_W4_Tax_ElectionOutput
	{
		[MessageBodyMember(Name = "Put_Payroll_Federal_W-4_Tax_Election_Response", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Put_Payroll_Federal_W-4_Tax_Election_Response")]
		public Put_Payroll_Federal_W4_Tax_Election_ResponseType Put_Payroll_Federal_W4_Tax_Election_Response;

		public Put_Payroll_Federal_W4_Tax_ElectionOutput()
		{
		}

		public Put_Payroll_Federal_W4_Tax_ElectionOutput(Put_Payroll_Federal_W4_Tax_Election_ResponseType Put_Payroll_Federal_W4_Tax_Election_Response)
		{
			this.Put_Payroll_Federal_W4_Tax_Election_Response = Put_Payroll_Federal_W4_Tax_Election_Response;
		}
	}
}
