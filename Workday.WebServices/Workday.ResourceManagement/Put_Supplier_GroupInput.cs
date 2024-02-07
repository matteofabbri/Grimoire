using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Supplier_GroupInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Supplier_Group_RequestType Put_Supplier_Group_Request;

		public Put_Supplier_GroupInput()
		{
		}

		public Put_Supplier_GroupInput(Workday_Common_HeaderType Workday_Common_Header, Put_Supplier_Group_RequestType Put_Supplier_Group_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Supplier_Group_Request = Put_Supplier_Group_Request;
		}
	}
}
