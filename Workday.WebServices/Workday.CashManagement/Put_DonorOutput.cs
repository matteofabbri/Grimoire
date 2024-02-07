using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_DonorOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Donor_ResponseType Put_Donor_Response;

		public Put_DonorOutput()
		{
		}

		public Put_DonorOutput(Put_Donor_ResponseType Put_Donor_Response)
		{
			this.Put_Donor_Response = Put_Donor_Response;
		}
	}
}
