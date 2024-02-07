using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payroll_Federal_W4_Tax_ElectionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Name = "Get_Payroll_Federal_W-4_Tax_Elections_Request", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Get_Payroll_Federal_W-4_Tax_Elections_Request")]
		public Get_Payroll_Federal_W4_Tax_Elections_RequestType Get_Payroll_Federal_W4_Tax_Elections_Request;

		public Get_Payroll_Federal_W4_Tax_ElectionInput()
		{
		}

		public Get_Payroll_Federal_W4_Tax_ElectionInput(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Federal_W4_Tax_Elections_RequestType Get_Payroll_Federal_W4_Tax_Elections_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Payroll_Federal_W4_Tax_Elections_Request = Get_Payroll_Federal_W4_Tax_Elections_Request;
		}
	}
}
