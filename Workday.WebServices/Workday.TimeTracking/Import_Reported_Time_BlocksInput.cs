using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.TimeTrackingService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Reported_Time_BlocksInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Import_Reported_Time_Blocks_RequestType Import_Reported_Time_Blocks_Request;

		public Import_Reported_Time_BlocksInput()
		{
		}

		public Import_Reported_Time_BlocksInput(Workday_Common_HeaderType Workday_Common_Header, Import_Reported_Time_Blocks_RequestType Import_Reported_Time_Blocks_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_Reported_Time_Blocks_Request = Import_Reported_Time_Blocks_Request;
		}
	}
}
