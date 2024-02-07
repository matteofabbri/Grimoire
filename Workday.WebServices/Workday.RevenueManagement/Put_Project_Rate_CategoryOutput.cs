using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Project_Rate_CategoryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Project_Rate_Category_ResponseType Put_Project_Rate_Category_Response;

		public Put_Project_Rate_CategoryOutput()
		{
		}

		public Put_Project_Rate_CategoryOutput(Put_Project_Rate_Category_ResponseType Put_Project_Rate_Category_Response)
		{
			this.Put_Project_Rate_Category_Response = Put_Project_Rate_Category_Response;
		}
	}
}
