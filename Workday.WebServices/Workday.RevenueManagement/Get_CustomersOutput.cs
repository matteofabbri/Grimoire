using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_CustomersOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Customers_ResponseType Get_Customers_Response;

		public Get_CustomersOutput()
		{
		}

		public Get_CustomersOutput(Get_Customers_ResponseType Get_Customers_Response)
		{
			this.Get_Customers_Response = Get_Customers_Response;
		}
	}
}
