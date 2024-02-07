using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Recruiting_RegionsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Recruiting_Regions_RequestType Get_Recruiting_Regions_Request;

		public Get_Recruiting_RegionsInput()
		{
		}

		public Get_Recruiting_RegionsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Recruiting_Regions_RequestType Get_Recruiting_Regions_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Recruiting_Regions_Request = Get_Recruiting_Regions_Request;
		}
	}
}
