using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Citizenship_StatusInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Citizenship_Status_RequestType Put_Citizenship_Status_Request;

		public Put_Citizenship_StatusInput()
		{
		}

		public Put_Citizenship_StatusInput(Workday_Common_HeaderType Workday_Common_Header, Put_Citizenship_Status_RequestType Put_Citizenship_Status_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Citizenship_Status_Request = Put_Citizenship_Status_Request;
		}
	}
}
