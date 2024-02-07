using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Fund_TypeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Fund_Type_ResponseType Put_Fund_Type_Response;

		public Put_Fund_TypeOutput()
		{
		}

		public Put_Fund_TypeOutput(Put_Fund_Type_ResponseType Put_Fund_Type_Response)
		{
			this.Put_Fund_Type_Response = Put_Fund_Type_Response;
		}
	}
}
