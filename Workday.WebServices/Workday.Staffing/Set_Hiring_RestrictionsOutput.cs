using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Set_Hiring_RestrictionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Set_Hiring_Restrictions_ResponseType Set_Hiring_Restrictions_Response;

		public Set_Hiring_RestrictionsOutput()
		{
		}

		public Set_Hiring_RestrictionsOutput(Set_Hiring_Restrictions_ResponseType Set_Hiring_Restrictions_Response)
		{
			this.Set_Hiring_Restrictions_Response = Set_Hiring_Restrictions_Response;
		}
	}
}
