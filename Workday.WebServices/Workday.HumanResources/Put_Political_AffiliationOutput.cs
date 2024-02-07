using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Political_AffiliationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Political_Affiliation_ResponseType Put_Political_Affiliation_Response;

		public Put_Political_AffiliationOutput()
		{
		}

		public Put_Political_AffiliationOutput(Put_Political_Affiliation_ResponseType Put_Political_Affiliation_Response)
		{
			this.Put_Political_Affiliation_Response = Put_Political_Affiliation_Response;
		}
	}
}
