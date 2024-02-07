using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Beginning_Balance_Translation_AmountsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Beginning_Balance_Translation_Amounts_ResponseType Put_Beginning_Balance_Translation_Amounts_Response;

		public Put_Beginning_Balance_Translation_AmountsOutput()
		{
		}

		public Put_Beginning_Balance_Translation_AmountsOutput(Put_Beginning_Balance_Translation_Amounts_ResponseType Put_Beginning_Balance_Translation_Amounts_Response)
		{
			this.Put_Beginning_Balance_Translation_Amounts_Response = Put_Beginning_Balance_Translation_Amounts_Response;
		}
	}
}
