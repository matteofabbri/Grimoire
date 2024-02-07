using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Cost_CenterInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Cost_Center_RequestType Put_Cost_Center_Request;

		public Put_Cost_CenterInput()
		{
		}

		public Put_Cost_CenterInput(Workday_Common_HeaderType Workday_Common_Header, Put_Cost_Center_RequestType Put_Cost_Center_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Cost_Center_Request = Put_Cost_Center_Request;
		}
	}
}
