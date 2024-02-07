using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Student_Aggregate_AwardsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Student_Aggregate_Awards_ResponseType Get_Student_Aggregate_Awards_Response;

		public Get_Student_Aggregate_AwardsOutput()
		{
		}

		public Get_Student_Aggregate_AwardsOutput(Get_Student_Aggregate_Awards_ResponseType Get_Student_Aggregate_Awards_Response)
		{
			this.Get_Student_Aggregate_Awards_Response = Get_Student_Aggregate_Awards_Response;
		}
	}
}
