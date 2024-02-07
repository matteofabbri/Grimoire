using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Supplier_Contact_InformationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Supplier_Contact_Information_ResponseType Submit_Supplier_Contact_Information_Response;

		public Submit_Supplier_Contact_InformationOutput()
		{
		}

		public Submit_Supplier_Contact_InformationOutput(Submit_Supplier_Contact_Information_ResponseType Submit_Supplier_Contact_Information_Response)
		{
			this.Submit_Supplier_Contact_Information_Response = Submit_Supplier_Contact_Information_Response;
		}
	}
}
