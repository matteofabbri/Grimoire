using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Company_as_Business_EntityInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Company_as_Business_Entity_RequestType Put_Company_as_Business_Entity_Request;

		public Put_Company_as_Business_EntityInput()
		{
		}

		public Put_Company_as_Business_EntityInput(Workday_Common_HeaderType Workday_Common_Header, Put_Company_as_Business_Entity_RequestType Put_Company_as_Business_Entity_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Company_as_Business_Entity_Request = Put_Company_as_Business_Entity_Request;
		}
	}
}
