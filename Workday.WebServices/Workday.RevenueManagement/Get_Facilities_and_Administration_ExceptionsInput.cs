using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Facilities_and_Administration_ExceptionsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Facilities_and_Administration_Exceptions_RequestType Get_Facilities_and_Administration_Exceptions_Request;

		public Get_Facilities_and_Administration_ExceptionsInput()
		{
		}

		public Get_Facilities_and_Administration_ExceptionsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Facilities_and_Administration_Exceptions_RequestType Get_Facilities_and_Administration_Exceptions_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Facilities_and_Administration_Exceptions_Request = Get_Facilities_and_Administration_Exceptions_Request;
		}
	}
}
