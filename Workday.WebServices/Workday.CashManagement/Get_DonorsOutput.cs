using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_DonorsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Donors_ResponseType Get_Donors_Response;

		public Get_DonorsOutput()
		{
		}

		public Get_DonorsOutput(Get_Donors_ResponseType Get_Donors_Response)
		{
			this.Get_Donors_Response = Get_Donors_Response;
		}
	}
}
