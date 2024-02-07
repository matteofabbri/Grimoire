using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Workers_Compensation_CodesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Workers_Compensation_Codes_RequestType Get_Workers_Compensation_Codes_Request;

		public Get_Workers_Compensation_CodesInput()
		{
		}

		public Get_Workers_Compensation_CodesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Workers_Compensation_Codes_RequestType Get_Workers_Compensation_Codes_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Workers_Compensation_Codes_Request = Get_Workers_Compensation_Codes_Request;
		}
	}
}
