using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Server_TimestampInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Server_Timestamp_GetType Server_Timestamp_Get;

		public Get_Server_TimestampInput()
		{
		}

		public Get_Server_TimestampInput(Workday_Common_HeaderType Workday_Common_Header, Server_Timestamp_GetType Server_Timestamp_Get)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Server_Timestamp_Get = Server_Timestamp_Get;
		}
	}
}
