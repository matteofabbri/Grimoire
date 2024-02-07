using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Health_Care_RatesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Health_Care_Rates_RequestType Get_Health_Care_Rates_Request;

		public Get_Health_Care_RatesInput()
		{
		}

		public Get_Health_Care_RatesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Health_Care_Rates_RequestType Get_Health_Care_Rates_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Health_Care_Rates_Request = Get_Health_Care_Rates_Request;
		}
	}
}
