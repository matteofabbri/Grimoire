using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payroll_Federal_W4_Tax_ElectionOutput
	{
		[MessageBodyMember(Name = "Get_Payroll_Federal_W-4_Tax_Elections_Response", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Get_Payroll_Federal_W-4_Tax_Elections_Response")]
		public Get_Payroll_Federal_W4_Tax_Elections_ResponseType Get_Payroll_Federal_W4_Tax_Elections_Response;

		public Get_Payroll_Federal_W4_Tax_ElectionOutput()
		{
		}

		public Get_Payroll_Federal_W4_Tax_ElectionOutput(Get_Payroll_Federal_W4_Tax_Elections_ResponseType Get_Payroll_Federal_W4_Tax_Elections_Response)
		{
			this.Get_Payroll_Federal_W4_Tax_Elections_Response = Get_Payroll_Federal_W4_Tax_Elections_Response;
		}
	}
}
