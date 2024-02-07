using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Extracurricular_ActivitiesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Extracurricular_Activities_ResponseType Get_Extracurricular_Activities_Response;

		public Get_Extracurricular_ActivitiesOutput()
		{
		}

		public Get_Extracurricular_ActivitiesOutput(Get_Extracurricular_Activities_ResponseType Get_Extracurricular_Activities_Response)
		{
			this.Get_Extracurricular_Activities_Response = Get_Extracurricular_Activities_Response;
		}
	}
}
