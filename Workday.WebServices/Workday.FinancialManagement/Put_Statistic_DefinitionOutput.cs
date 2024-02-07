using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Statistic_DefinitionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Statistic_Definition_ResponseType Put_Statistic_Definition_Response;

		public Put_Statistic_DefinitionOutput()
		{
		}

		public Put_Statistic_DefinitionOutput(Put_Statistic_Definition_ResponseType Put_Statistic_Definition_Response)
		{
			this.Put_Statistic_Definition_Response = Put_Statistic_Definition_Response;
		}
	}
}
