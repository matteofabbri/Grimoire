using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Expense_Credit_Card_Transaction_FileOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Credit_Card_Transaction_File_ResponseType Put_Credit_Card_Transaction_File_Response;

		public Put_Expense_Credit_Card_Transaction_FileOutput()
		{
		}

		public Put_Expense_Credit_Card_Transaction_FileOutput(Put_Credit_Card_Transaction_File_ResponseType Put_Credit_Card_Transaction_File_Response)
		{
			this.Put_Credit_Card_Transaction_File_Response = Put_Credit_Card_Transaction_File_Response;
		}
	}
}
