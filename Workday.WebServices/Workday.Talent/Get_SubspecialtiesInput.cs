using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_SubspecialtiesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Subspecialties_RequestType Get_Subspecialties_Request;

		public Get_SubspecialtiesInput()
		{
		}

		public Get_SubspecialtiesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Subspecialties_RequestType Get_Subspecialties_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Subspecialties_Request = Get_Subspecialties_Request;
		}
	}
}
