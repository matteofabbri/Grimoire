using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Supplier_Contact_InformationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Supplier_Contact_Information_RequestType Get_Supplier_Contact_Information_Request;

		public Get_Supplier_Contact_InformationInput()
		{
		}

		public Get_Supplier_Contact_InformationInput(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Contact_Information_RequestType Get_Supplier_Contact_Information_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Supplier_Contact_Information_Request = Get_Supplier_Contact_Information_Request;
		}
	}
}
