using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Maintained_Academic_PeriodOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Maintained_Academic_Period_ResponseType Put_Maintained_Academic_Period_Response;

		public Put_Maintained_Academic_PeriodOutput()
		{
		}

		public Put_Maintained_Academic_PeriodOutput(Put_Maintained_Academic_Period_ResponseType Put_Maintained_Academic_Period_Response)
		{
			this.Put_Maintained_Academic_Period_Response = Put_Maintained_Academic_Period_Response;
		}
	}
}
