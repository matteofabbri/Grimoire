using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Location_AttributesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Location_Attributes_RequestType Get_Location_Attributes_Request;

		public Get_Location_AttributesInput()
		{
		}

		public Get_Location_AttributesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Location_Attributes_RequestType Get_Location_Attributes_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Location_Attributes_Request = Get_Location_Attributes_Request;
		}
	}
}
