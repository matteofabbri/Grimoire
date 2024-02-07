using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Create_Reference_Letter_for_WorkerInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Create_Reference_Letter_for_Worker_RequestType Create_Reference_Letter_for_Worker_Request;

		public Create_Reference_Letter_for_WorkerInput()
		{
		}

		public Create_Reference_Letter_for_WorkerInput(Workday_Common_HeaderType Workday_Common_Header, Create_Reference_Letter_for_Worker_RequestType Create_Reference_Letter_for_Worker_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Create_Reference_Letter_for_Worker_Request = Create_Reference_Letter_for_Worker_Request;
		}
	}
}
