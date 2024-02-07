using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_Position_RestrictionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Edit_Positon_Restriction_ResponseType Edit_Positon_Restriction_Response;

		public Edit_Position_RestrictionsOutput()
		{
		}

		public Edit_Position_RestrictionsOutput(Edit_Positon_Restriction_ResponseType Edit_Positon_Restriction_Response)
		{
			this.Edit_Positon_Restriction_Response = Edit_Positon_Restriction_Response;
		}
	}
}
