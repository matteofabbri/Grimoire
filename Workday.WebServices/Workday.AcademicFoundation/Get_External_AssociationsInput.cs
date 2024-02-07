using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_External_AssociationsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_External_Associations_RequestType Get_External_Associations_Request;

		public Get_External_AssociationsInput()
		{
		}

		public Get_External_AssociationsInput(Workday_Common_HeaderType Workday_Common_Header, Get_External_Associations_RequestType Get_External_Associations_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_External_Associations_Request = Get_External_Associations_Request;
		}
	}
}
