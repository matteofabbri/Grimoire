using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Workday_Project_HierarchyInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Workday_Project_Hierarchy_RequestType Submit_Workday_Project_Hierarchy_Request;

		public Submit_Workday_Project_HierarchyInput()
		{
		}

		public Submit_Workday_Project_HierarchyInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Workday_Project_Hierarchy_RequestType Submit_Workday_Project_Hierarchy_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Workday_Project_Hierarchy_Request = Submit_Workday_Project_Hierarchy_Request;
		}
	}
}
