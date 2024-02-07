using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Student_Transfer_Credit_RuleOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Student_Transfer_Credit_Rule_ResponseType Put_Student_Transfer_Credit_Rule_Response;

		public Put_Student_Transfer_Credit_RuleOutput()
		{
		}

		public Put_Student_Transfer_Credit_RuleOutput(Put_Student_Transfer_Credit_Rule_ResponseType Put_Student_Transfer_Credit_Rule_Response)
		{
			this.Put_Student_Transfer_Credit_Rule_Response = Put_Student_Transfer_Credit_Rule_Response;
		}
	}
}
