using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Bank_Statement_FileOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Bank_Statement_File_ResponseType Put_Bank_Statement_File_Response;

		public Put_Bank_Statement_FileOutput()
		{
		}

		public Put_Bank_Statement_FileOutput(Put_Bank_Statement_File_ResponseType Put_Bank_Statement_File_Response)
		{
			this.Put_Bank_Statement_File_Response = Put_Bank_Statement_File_Response;
		}
	}
}
