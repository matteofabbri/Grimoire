using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payroll_Federal_W4_Tax_ElectionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Name = "Put_Payroll_Federal_W-4_Tax_Election_Request", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Put_Payroll_Federal_W-4_Tax_Election_Request")]
		public Put_Payroll_Federal_W4_Tax_Election_RequestType Put_Payroll_Federal_W4_Tax_Election_Request;

		public Put_Payroll_Federal_W4_Tax_ElectionInput()
		{
		}

		public Put_Payroll_Federal_W4_Tax_ElectionInput(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Federal_W4_Tax_Election_RequestType Put_Payroll_Federal_W4_Tax_Election_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Payroll_Federal_W4_Tax_Election_Request = Put_Payroll_Federal_W4_Tax_Election_Request;
		}
	}
}
