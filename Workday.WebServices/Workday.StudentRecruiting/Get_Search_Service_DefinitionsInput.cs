using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Search_Service_DefinitionsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Search_Service_Definitions_RequestType Get_Search_Service_Definitions_Request;

		public Get_Search_Service_DefinitionsInput()
		{
		}

		public Get_Search_Service_DefinitionsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Search_Service_Definitions_RequestType Get_Search_Service_Definitions_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Search_Service_Definitions_Request = Get_Search_Service_Definitions_Request;
		}
	}
}
