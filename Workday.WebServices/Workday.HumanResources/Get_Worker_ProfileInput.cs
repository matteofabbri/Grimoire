using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Worker_ProfileInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Worker_Profile_GetType Worker_Profile_Get;

		public Get_Worker_ProfileInput()
		{
		}

		public Get_Worker_ProfileInput(Workday_Common_HeaderType Workday_Common_Header, Worker_Profile_GetType Worker_Profile_Get)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Worker_Profile_Get = Worker_Profile_Get;
		}
	}
}
