using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Add_Supplier_Contract_Line_HoldOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Add_Supplier_Contract_Line_Hold_ResponseType Add_Supplier_Contract_Line_Hold_Response;

		public Add_Supplier_Contract_Line_HoldOutput()
		{
		}

		public Add_Supplier_Contract_Line_HoldOutput(Add_Supplier_Contract_Line_Hold_ResponseType Add_Supplier_Contract_Line_Hold_Response)
		{
			this.Add_Supplier_Contract_Line_Hold_Response = Add_Supplier_Contract_Line_Hold_Response;
		}
	}
}
