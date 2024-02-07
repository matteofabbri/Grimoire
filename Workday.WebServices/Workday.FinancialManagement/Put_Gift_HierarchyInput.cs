using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Gift_HierarchyInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Gift_Hierarchy_RequestType Put_Gift_Hierarchy_Request;

		public Put_Gift_HierarchyInput()
		{
		}

		public Put_Gift_HierarchyInput(Workday_Common_HeaderType Workday_Common_Header, Put_Gift_Hierarchy_RequestType Put_Gift_Hierarchy_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Gift_Hierarchy_Request = Put_Gift_Hierarchy_Request;
		}
	}
}
