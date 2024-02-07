using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Customer_CategoryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Customer_Category_ResponseType Put_Customer_Category_Response;

		public Put_Customer_CategoryOutput()
		{
		}

		public Put_Customer_CategoryOutput(Put_Customer_Category_ResponseType Put_Customer_Category_Response)
		{
			this.Put_Customer_Category_Response = Put_Customer_Category_Response;
		}
	}
}
