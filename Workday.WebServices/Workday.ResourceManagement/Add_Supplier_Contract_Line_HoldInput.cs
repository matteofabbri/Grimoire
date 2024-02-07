using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Add_Supplier_Contract_Line_HoldInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Add_Supplier_Contract_Line_Hold_RequestType Add_Supplier_Contract_Line_Hold_Request;

		public Add_Supplier_Contract_Line_HoldInput()
		{
		}

		public Add_Supplier_Contract_Line_HoldInput(Workday_Common_HeaderType Workday_Common_Header, Add_Supplier_Contract_Line_Hold_RequestType Add_Supplier_Contract_Line_Hold_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Add_Supplier_Contract_Line_Hold_Request = Add_Supplier_Contract_Line_Hold_Request;
		}
	}
}
