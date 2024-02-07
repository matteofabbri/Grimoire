using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payroll_Offcycle_PaymentsOutput
	{
		[MessageBodyMember(Name = "Get_Payroll_Off-cycle_Payments_Response", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Get_Payroll_Off-cycle_Payments_Response")]
		public Get_Payroll_Offcycle_Payments_ResponseType Get_Payroll_Offcycle_Payments_Response;

		public Get_Payroll_Offcycle_PaymentsOutput()
		{
		}

		public Get_Payroll_Offcycle_PaymentsOutput(Get_Payroll_Offcycle_Payments_ResponseType Get_Payroll_Offcycle_Payments_Response)
		{
			this.Get_Payroll_Offcycle_Payments_Response = Get_Payroll_Offcycle_Payments_Response;
		}
	}
}
