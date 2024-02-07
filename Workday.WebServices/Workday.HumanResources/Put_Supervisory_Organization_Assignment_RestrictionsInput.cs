using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Supervisory_Organization_Assignment_RestrictionsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Organization_Assignment_Restrictions_RequestType Put_Organization_Assignment_Restrictions_Request;

		public Put_Supervisory_Organization_Assignment_RestrictionsInput()
		{
		}

		public Put_Supervisory_Organization_Assignment_RestrictionsInput(Workday_Common_HeaderType Workday_Common_Header, Put_Organization_Assignment_Restrictions_RequestType Put_Organization_Assignment_Restrictions_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Organization_Assignment_Restrictions_Request = Put_Organization_Assignment_Restrictions_Request;
		}
	}
}
