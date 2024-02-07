using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_LicensesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Licenses_ResponseType Change_Licenses_Response;

		public Change_LicensesOutput()
		{
		}

		public Change_LicensesOutput(Change_Licenses_ResponseType Change_Licenses_Response)
		{
			this.Change_Licenses_Response = Change_Licenses_Response;
		}
	}
}
