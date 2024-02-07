using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_StatisticOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Statistic_ResponseType Put_Statistic_Response;

		public Put_StatisticOutput()
		{
		}

		public Put_StatisticOutput(Put_Statistic_ResponseType Put_Statistic_Response)
		{
			this.Put_Statistic_Response = Put_Statistic_Response;
		}
	}
}
