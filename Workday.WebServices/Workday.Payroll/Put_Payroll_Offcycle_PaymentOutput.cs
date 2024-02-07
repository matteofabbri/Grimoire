using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payroll_Offcycle_PaymentOutput
	{
		[MessageBodyMember(Name = "Put_Payroll_Off-cycle_Payment_Response", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Put_Payroll_Off-cycle_Payment_Response")]
		public Put_Payroll_Offcycle_Payment_ResponseType Put_Payroll_Offcycle_Payment_Response;

		public Put_Payroll_Offcycle_PaymentOutput()
		{
		}

		public Put_Payroll_Offcycle_PaymentOutput(Put_Payroll_Offcycle_Payment_ResponseType Put_Payroll_Offcycle_Payment_Response)
		{
			this.Put_Payroll_Offcycle_Payment_Response = Put_Payroll_Offcycle_Payment_Response;
		}
	}
}
