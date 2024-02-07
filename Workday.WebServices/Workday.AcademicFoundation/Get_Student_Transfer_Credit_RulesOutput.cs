using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Student_Transfer_Credit_RulesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Student_Transfer_Credit_Rules_ResponseType Get_Student_Transfer_Credit_Rules_Response;

		public Get_Student_Transfer_Credit_RulesOutput()
		{
		}

		public Get_Student_Transfer_Credit_RulesOutput(Get_Student_Transfer_Credit_Rules_ResponseType Get_Student_Transfer_Credit_Rules_Response)
		{
			this.Get_Student_Transfer_Credit_Rules_Response = Get_Student_Transfer_Credit_Rules_Response;
		}
	}
}
