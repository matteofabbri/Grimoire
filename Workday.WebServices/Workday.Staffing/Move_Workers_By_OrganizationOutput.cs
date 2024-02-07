using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Move_Workers_By_OrganizationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Move_Workers_By_Organization_ResponseType Move_Workers_By_Organization_Response;

		public Move_Workers_By_OrganizationOutput()
		{
		}

		public Move_Workers_By_OrganizationOutput(Move_Workers_By_Organization_ResponseType Move_Workers_By_Organization_Response)
		{
			this.Move_Workers_By_Organization_Response = Move_Workers_By_Organization_Response;
		}
	}
}
