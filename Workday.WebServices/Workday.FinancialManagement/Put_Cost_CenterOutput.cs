using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Cost_CenterOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Cost_Center_ResponseType Put_Cost_Center_Response;

		public Put_Cost_CenterOutput()
		{
		}

		public Put_Cost_CenterOutput(Put_Cost_Center_ResponseType Put_Cost_Center_Response)
		{
			this.Put_Cost_Center_Response = Put_Cost_Center_Response;
		}
	}
}
