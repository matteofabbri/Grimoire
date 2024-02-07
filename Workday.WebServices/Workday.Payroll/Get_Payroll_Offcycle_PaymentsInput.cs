using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payroll_Offcycle_PaymentsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Name = "Get_Payroll_Off-cycle_Payments_Request", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Get_Payroll_Off-cycle_Payments_Request")]
		public Get_Payroll_Offcycle_Payments_RequestType Get_Payroll_Offcycle_Payments_Request;

		public Get_Payroll_Offcycle_PaymentsInput()
		{
		}

		public Get_Payroll_Offcycle_PaymentsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Offcycle_Payments_RequestType Get_Payroll_Offcycle_Payments_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Payroll_Offcycle_Payments_Request = Get_Payroll_Offcycle_Payments_Request;
		}
	}
}
