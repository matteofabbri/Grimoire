using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Health_Care_RateOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Health_Care_Rate_ResponseType Put_Health_Care_Rate_Response;

		public Put_Health_Care_RateOutput()
		{
		}

		public Put_Health_Care_RateOutput(Put_Health_Care_Rate_ResponseType Put_Health_Care_Rate_Response)
		{
			this.Put_Health_Care_Rate_Response = Put_Health_Care_Rate_Response;
		}
	}
}
