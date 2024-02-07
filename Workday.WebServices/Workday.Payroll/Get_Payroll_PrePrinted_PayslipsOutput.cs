using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payroll_PrePrinted_PayslipsOutput
	{
		[MessageBodyMember(Name = "Get_Payroll_Pre-Printed_Payslips_Response", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Get_Payroll_Pre-Printed_Payslips_Response")]
		public Get_Payroll_PrePrinted_Payslips_ResponseType Get_Payroll_PrePrinted_Payslips_Response;

		public Get_Payroll_PrePrinted_PayslipsOutput()
		{
		}

		public Get_Payroll_PrePrinted_PayslipsOutput(Get_Payroll_PrePrinted_Payslips_ResponseType Get_Payroll_PrePrinted_Payslips_Response)
		{
			this.Get_Payroll_PrePrinted_Payslips_Response = Get_Payroll_PrePrinted_Payslips_Response;
		}
	}
}
