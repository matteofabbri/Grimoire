using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Student_Friends_and_FamilyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Student_Friends_and_Family_ResponseType Get_Student_Friends_and_Family_Response;

		public Get_Student_Friends_and_FamilyOutput()
		{
		}

		public Get_Student_Friends_and_FamilyOutput(Get_Student_Friends_and_Family_ResponseType Get_Student_Friends_and_Family_Response)
		{
			this.Get_Student_Friends_and_Family_Response = Get_Student_Friends_and_Family_Response;
		}
	}
}
