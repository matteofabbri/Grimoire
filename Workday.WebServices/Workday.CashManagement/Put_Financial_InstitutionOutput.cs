using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Financial_InstitutionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Financial_Institution_ResponseType Put_Financial_Institution_Response;

		public Put_Financial_InstitutionOutput()
		{
		}

		public Put_Financial_InstitutionOutput(Put_Financial_Institution_ResponseType Put_Financial_Institution_Response)
		{
			this.Put_Financial_Institution_Response = Put_Financial_Institution_Response;
		}
	}
}
