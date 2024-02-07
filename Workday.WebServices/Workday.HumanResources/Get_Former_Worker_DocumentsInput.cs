using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Former_Worker_DocumentsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Former_Worker_Documents_RequestType Get_Former_Worker_Documents_Request;

		public Get_Former_Worker_DocumentsInput()
		{
		}

		public Get_Former_Worker_DocumentsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Former_Worker_Documents_RequestType Get_Former_Worker_Documents_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Former_Worker_Documents_Request = Get_Former_Worker_Documents_Request;
		}
	}
}
