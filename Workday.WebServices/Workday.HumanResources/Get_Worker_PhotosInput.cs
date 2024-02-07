using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Worker_PhotosInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Worker_Photos_RequestType Get_Worker_Photos_Request;

		public Get_Worker_PhotosInput()
		{
		}

		public Get_Worker_PhotosInput(Workday_Common_HeaderType Workday_Common_Header, Get_Worker_Photos_RequestType Get_Worker_Photos_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Worker_Photos_Request = Get_Worker_Photos_Request;
		}
	}
}
