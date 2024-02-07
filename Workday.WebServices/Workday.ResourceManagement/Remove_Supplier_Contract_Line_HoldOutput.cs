using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Remove_Supplier_Contract_Line_HoldOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Remove_Supplier_Contract_Line_Hold_ResponseType Remove_Supplier_Contract_Line_Hold_Response;

		public Remove_Supplier_Contract_Line_HoldOutput()
		{
		}

		public Remove_Supplier_Contract_Line_HoldOutput(Remove_Supplier_Contract_Line_Hold_ResponseType Remove_Supplier_Contract_Line_Hold_Response)
		{
			this.Remove_Supplier_Contract_Line_Hold_Response = Remove_Supplier_Contract_Line_Hold_Response;
		}
	}
}
