using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_Hiring_RestrictionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Edit_Hiring_Restrictions_ResponseType Edit_Hiring_Restrictions_Response;

		public Edit_Hiring_RestrictionsOutput()
		{
		}

		public Edit_Hiring_RestrictionsOutput(Edit_Hiring_Restrictions_ResponseType Edit_Hiring_Restrictions_Response)
		{
			this.Edit_Hiring_Restrictions_Response = Edit_Hiring_Restrictions_Response;
		}
	}
}
