using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Server_TimestampOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Server_TimestampType Server_Timestamp;

		public Get_Server_TimestampOutput()
		{
		}

		public Get_Server_TimestampOutput(Server_TimestampType Server_Timestamp)
		{
			this.Server_Timestamp = Server_Timestamp;
		}
	}
}
