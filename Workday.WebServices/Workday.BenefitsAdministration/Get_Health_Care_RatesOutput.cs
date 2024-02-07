using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Health_Care_RatesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Health_Care_Rates_ResponseType Get_Health_Care_Rates_Response;

		public Get_Health_Care_RatesOutput()
		{
		}

		public Get_Health_Care_RatesOutput(Get_Health_Care_Rates_ResponseType Get_Health_Care_Rates_Response)
		{
			this.Get_Health_Care_Rates_Response = Get_Health_Care_Rates_Response;
		}
	}
}
