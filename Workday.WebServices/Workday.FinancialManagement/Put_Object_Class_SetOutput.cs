using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Object_Class_SetOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Object_Class_Set_ResponseType Put_Object_Class_Set_Response;

		public Put_Object_Class_SetOutput()
		{
		}

		public Put_Object_Class_SetOutput(Put_Object_Class_Set_ResponseType Put_Object_Class_Set_Response)
		{
			this.Put_Object_Class_Set_Response = Put_Object_Class_Set_Response;
		}
	}
}
