using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Maintained_Academic_PeriodsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Maintained_Academic_Periods_ResponseType Get_Maintained_Academic_Periods_Response;

		public Get_Maintained_Academic_PeriodsOutput()
		{
		}

		public Get_Maintained_Academic_PeriodsOutput(Get_Maintained_Academic_Periods_ResponseType Get_Maintained_Academic_Periods_Response)
		{
			this.Get_Maintained_Academic_Periods_Response = Get_Maintained_Academic_Periods_Response;
		}
	}
}
