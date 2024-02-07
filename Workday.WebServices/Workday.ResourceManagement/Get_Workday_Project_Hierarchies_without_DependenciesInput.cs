using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Workday_Project_Hierarchies_without_DependenciesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Workday_Project_Hierarchies_without_Dependencies_RequestType Get_Workday_Project_Hierarchies_without_Dependencies_Request;

		public Get_Workday_Project_Hierarchies_without_DependenciesInput()
		{
		}

		public Get_Workday_Project_Hierarchies_without_DependenciesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Workday_Project_Hierarchies_without_Dependencies_RequestType Get_Workday_Project_Hierarchies_without_Dependencies_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Workday_Project_Hierarchies_without_Dependencies_Request = Get_Workday_Project_Hierarchies_without_Dependencies_Request;
		}
	}
}
