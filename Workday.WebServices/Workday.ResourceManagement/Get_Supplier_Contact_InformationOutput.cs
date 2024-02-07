using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Supplier_Contact_InformationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Supplier_Contact_Information_ResponseType Get_Supplier_Contact_Information_Response;

		public Get_Supplier_Contact_InformationOutput()
		{
		}

		public Get_Supplier_Contact_InformationOutput(Get_Supplier_Contact_Information_ResponseType Get_Supplier_Contact_Information_Response)
		{
			this.Get_Supplier_Contact_Information_Response = Get_Supplier_Contact_Information_Response;
		}
	}
}
