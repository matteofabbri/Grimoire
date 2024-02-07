using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Student_Friends_and_FamilyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Student_Friends_and_Family_ResponseType Put_Student_Friends_and_Family_Response;

		public Put_Student_Friends_and_FamilyOutput()
		{
		}

		public Put_Student_Friends_and_FamilyOutput(Put_Student_Friends_and_Family_ResponseType Put_Student_Friends_and_Family_Response)
		{
			this.Put_Student_Friends_and_Family_Response = Put_Student_Friends_and_Family_Response;
		}
	}
}
