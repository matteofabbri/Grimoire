using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_StatisticsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Statistics_ResponseType Get_Statistics_Response;

		public Get_StatisticsOutput()
		{
		}

		public Get_StatisticsOutput(Get_Statistics_ResponseType Get_Statistics_Response)
		{
			this.Get_Statistics_Response = Get_Statistics_Response;
		}
	}
}
