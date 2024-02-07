using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Sexual_OrientationsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Sexual_Orientations_RequestType Get_Sexual_Orientations_Request;

		public Get_Sexual_OrientationsInput()
		{
		}

		public Get_Sexual_OrientationsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Sexual_Orientations_RequestType Get_Sexual_Orientations_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Sexual_Orientations_Request = Get_Sexual_Orientations_Request;
		}
	}
}
