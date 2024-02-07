using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Supervisory_Organization_Assignment_RestrictionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Organization_Assignment_Restrictions_ResponseType Get_Organization_Assignment_Restrictions_Response;

		public Get_Supervisory_Organization_Assignment_RestrictionsOutput()
		{
		}

		public Get_Supervisory_Organization_Assignment_RestrictionsOutput(Get_Organization_Assignment_Restrictions_ResponseType Get_Organization_Assignment_Restrictions_Response)
		{
			this.Get_Organization_Assignment_Restrictions_Response = Get_Organization_Assignment_Restrictions_Response;
		}
	}
}
