using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Object_Class_SetsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Object_Class_Sets_ResponseType Get_Object_Class_Sets_Response;

		public Get_Object_Class_SetsOutput()
		{
		}

		public Get_Object_Class_SetsOutput(Get_Object_Class_Sets_ResponseType Get_Object_Class_Sets_Response)
		{
			this.Get_Object_Class_Sets_Response = Get_Object_Class_Sets_Response;
		}
	}
}
