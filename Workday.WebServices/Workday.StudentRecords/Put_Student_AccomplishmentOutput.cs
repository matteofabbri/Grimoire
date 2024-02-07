using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Student_AccomplishmentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Student_Accomplishment_ResponseType Put_Student_Accomplishment_Response;

		public Put_Student_AccomplishmentOutput()
		{
		}

		public Put_Student_AccomplishmentOutput(Put_Student_Accomplishment_ResponseType Put_Student_Accomplishment_Response)
		{
			this.Put_Student_Accomplishment_Response = Put_Student_Accomplishment_Response;
		}
	}
}
