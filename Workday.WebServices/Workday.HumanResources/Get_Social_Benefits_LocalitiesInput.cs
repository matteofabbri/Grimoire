using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Social_Benefits_LocalitiesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Social_Benefits_Localities_RequestType Get_Social_Benefits_Localities_Request;

		public Get_Social_Benefits_LocalitiesInput()
		{
		}

		public Get_Social_Benefits_LocalitiesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Social_Benefits_Localities_RequestType Get_Social_Benefits_Localities_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Social_Benefits_Localities_Request = Get_Social_Benefits_Localities_Request;
		}
	}
}
