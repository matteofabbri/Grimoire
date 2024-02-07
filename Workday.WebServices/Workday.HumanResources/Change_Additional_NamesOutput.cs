using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_Additional_NamesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Additional_Names_ResponseType Change_Additional_Names_Response;

		public Change_Additional_NamesOutput()
		{
		}

		public Change_Additional_NamesOutput(Change_Additional_Names_ResponseType Change_Additional_Names_Response)
		{
			this.Change_Additional_Names_Response = Change_Additional_Names_Response;
		}
	}
}
