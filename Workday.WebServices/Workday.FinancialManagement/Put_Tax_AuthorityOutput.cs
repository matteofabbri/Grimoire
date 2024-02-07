using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Tax_AuthorityOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Tax_Authority_ResponseType Put_Tax_Authority_Response;

		public Put_Tax_AuthorityOutput()
		{
		}

		public Put_Tax_AuthorityOutput(Put_Tax_Authority_ResponseType Put_Tax_Authority_Response)
		{
			this.Put_Tax_Authority_Response = Put_Tax_Authority_Response;
		}
	}
}
