using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Business_UnitsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Business_Units_ResponseType Get_Business_Units_Response;

		public Get_Business_UnitsOutput()
		{
		}

		public Get_Business_UnitsOutput(Get_Business_Units_ResponseType Get_Business_Units_Response)
		{
			this.Get_Business_Units_Response = Get_Business_Units_Response;
		}
	}
}
