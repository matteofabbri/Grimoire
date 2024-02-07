using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payroll_Offcycle_PaymentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Name = "Put_Payroll_Off-cycle_Payment_Request", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Put_Payroll_Off-cycle_Payment_Request")]
		public Put_Payroll_Offcycle_Payment_RequestType Put_Payroll_Offcycle_Payment_Request;

		public Put_Payroll_Offcycle_PaymentInput()
		{
		}

		public Put_Payroll_Offcycle_PaymentInput(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Offcycle_Payment_RequestType Put_Payroll_Offcycle_Payment_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Payroll_Offcycle_Payment_Request = Put_Payroll_Offcycle_Payment_Request;
		}
	}
}
