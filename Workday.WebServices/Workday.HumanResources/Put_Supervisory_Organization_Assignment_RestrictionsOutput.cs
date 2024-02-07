using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Supervisory_Organization_Assignment_RestrictionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Organization_Assignment_Restrictions_ResponseType Put_Organization_Assignment_Restrictions_Response;

		public Put_Supervisory_Organization_Assignment_RestrictionsOutput()
		{
		}

		public Put_Supervisory_Organization_Assignment_RestrictionsOutput(Put_Organization_Assignment_Restrictions_ResponseType Put_Organization_Assignment_Restrictions_Response)
		{
			this.Put_Organization_Assignment_Restrictions_Response = Put_Organization_Assignment_Restrictions_Response;
		}
	}
}
