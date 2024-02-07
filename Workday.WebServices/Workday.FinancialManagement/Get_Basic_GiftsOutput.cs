using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Basic_GiftsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Basic_Gifts_ResponseType Get_Basic_Gifts_Response;

		public Get_Basic_GiftsOutput()
		{
		}

		public Get_Basic_GiftsOutput(Get_Basic_Gifts_ResponseType Get_Basic_Gifts_Response)
		{
			this.Get_Basic_Gifts_Response = Get_Basic_Gifts_Response;
		}
	}
}
