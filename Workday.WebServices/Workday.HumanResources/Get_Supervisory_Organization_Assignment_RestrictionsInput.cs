using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Supervisory_Organization_Assignment_RestrictionsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Organization_Assignment_Restrictions_RequestType Get_Organization_Assignment_Restrictions_Request;

		public Get_Supervisory_Organization_Assignment_RestrictionsInput()
		{
		}

		public Get_Supervisory_Organization_Assignment_RestrictionsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Organization_Assignment_Restrictions_RequestType Get_Organization_Assignment_Restrictions_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Organization_Assignment_Restrictions_Request = Get_Organization_Assignment_Restrictions_Request;
		}
	}
}
