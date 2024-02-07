using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Worker_Event_HistoryInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Worker_Event_History_GetType Worker_Event_History_Get;

		public Get_Worker_Event_HistoryInput()
		{
		}

		public Get_Worker_Event_HistoryInput(Workday_Common_HeaderType Workday_Common_Header, Worker_Event_History_GetType Worker_Event_History_Get)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Worker_Event_History_Get = Worker_Event_History_Get;
		}
	}
}
