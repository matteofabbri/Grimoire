using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Expense_Credit_Card_Transaction_FilesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Credit_Card_Transaction_Files_ResponseType Get_Credit_Card_Transaction_Files_Response;

		public Get_Expense_Credit_Card_Transaction_FilesOutput()
		{
		}

		public Get_Expense_Credit_Card_Transaction_FilesOutput(Get_Credit_Card_Transaction_Files_ResponseType Get_Credit_Card_Transaction_Files_Response)
		{
			this.Get_Credit_Card_Transaction_Files_Response = Get_Credit_Card_Transaction_Files_Response;
		}
	}
}
