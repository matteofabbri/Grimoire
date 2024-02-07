using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Prospective_StudentsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Prospective_Students_RequestType Get_Prospective_Students_Request;

		public Get_Prospective_StudentsInput()
		{
		}

		public Get_Prospective_StudentsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Prospective_Students_RequestType Get_Prospective_Students_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Prospective_Students_Request = Get_Prospective_Students_Request;
		}
	}
}
