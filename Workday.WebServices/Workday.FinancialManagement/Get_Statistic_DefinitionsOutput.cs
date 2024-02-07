using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Statistic_DefinitionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Statistic_Definitions_ResponseType Get_Statistic_Definitions_Response;

		public Get_Statistic_DefinitionsOutput()
		{
		}

		public Get_Statistic_DefinitionsOutput(Get_Statistic_Definitions_ResponseType Get_Statistic_Definitions_Response)
		{
			this.Get_Statistic_Definitions_Response = Get_Statistic_Definitions_Response;
		}
	}
}
