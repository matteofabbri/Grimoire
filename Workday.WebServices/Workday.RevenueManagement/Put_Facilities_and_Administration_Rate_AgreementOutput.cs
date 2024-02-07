using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Facilities_and_Administration_Rate_AgreementOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Facilities_and_Administration_Rate_Agreement_ResponseType Put_Facilities_and_Administration_Rate_Agreement_Response;

		public Put_Facilities_and_Administration_Rate_AgreementOutput()
		{
		}

		public Put_Facilities_and_Administration_Rate_AgreementOutput(Put_Facilities_and_Administration_Rate_Agreement_ResponseType Put_Facilities_and_Administration_Rate_Agreement_Response)
		{
			this.Put_Facilities_and_Administration_Rate_Agreement_Response = Put_Facilities_and_Administration_Rate_Agreement_Response;
		}
	}
}
