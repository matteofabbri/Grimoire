using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Worker_Event_HistoryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Worker_Event_HistoryType Worker_Event_History;

		public Get_Worker_Event_HistoryOutput()
		{
		}

		public Get_Worker_Event_HistoryOutput(Worker_Event_HistoryType Worker_Event_History)
		{
			this.Worker_Event_History = Worker_Event_History;
		}
	}
}
