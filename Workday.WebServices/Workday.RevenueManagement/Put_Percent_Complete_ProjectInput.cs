using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Percent_Complete_ProjectInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Percent_Complete_Project_RequestType Put_Percent_Complete_Project_Request;

		public Put_Percent_Complete_ProjectInput()
		{
		}

		public Put_Percent_Complete_ProjectInput(Workday_Common_HeaderType Workday_Common_Header, Put_Percent_Complete_Project_RequestType Put_Percent_Complete_Project_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Percent_Complete_Project_Request = Put_Percent_Complete_Project_Request;
		}
	}
}
