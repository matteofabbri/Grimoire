using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_BatchesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Batches_RequestType Get_Batches_Request;

		public Get_BatchesInput()
		{
		}

		public Get_BatchesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Batches_RequestType Get_Batches_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Batches_Request = Get_Batches_Request;
		}
	}
}
