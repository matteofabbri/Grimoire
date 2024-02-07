using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Benefit_Annual_RatesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Benefit_Annual_Rates_ResponseType Get_Benefit_Annual_Rates_Response;

		public Get_Benefit_Annual_RatesOutput()
		{
		}

		public Get_Benefit_Annual_RatesOutput(Get_Benefit_Annual_Rates_ResponseType Get_Benefit_Annual_Rates_Response)
		{
			this.Get_Benefit_Annual_Rates_Response = Get_Benefit_Annual_Rates_Response;
		}
	}
}
