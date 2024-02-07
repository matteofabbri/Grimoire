using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Competency_ClassesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Competency_Classes_RequestType Get_Competency_Classes_Request;

		public Get_Competency_ClassesInput()
		{
		}

		public Get_Competency_ClassesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Competency_Classes_RequestType Get_Competency_Classes_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Competency_Classes_Request = Get_Competency_Classes_Request;
		}
	}
}
