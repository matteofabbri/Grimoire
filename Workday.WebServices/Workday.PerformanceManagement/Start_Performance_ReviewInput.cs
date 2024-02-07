using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Start_Performance_ReviewInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Start_Performance_Review_RequestType Start_Performance_Review_Request;

		public Start_Performance_ReviewInput()
		{
		}

		public Start_Performance_ReviewInput(Workday_Common_HeaderType Workday_Common_Header, Start_Performance_Review_RequestType Start_Performance_Review_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Start_Performance_Review_Request = Start_Performance_Review_Request;
		}
	}
}
