using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Move_Workers_By_OrganizationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Move_Workers_By_Organization_RequestType Move_Workers_By_Organization_Request;

		public Move_Workers_By_OrganizationInput()
		{
		}

		public Move_Workers_By_OrganizationInput(Workday_Common_HeaderType Workday_Common_Header, Move_Workers_By_Organization_RequestType Move_Workers_By_Organization_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Move_Workers_By_Organization_Request = Move_Workers_By_Organization_Request;
		}
	}
}
