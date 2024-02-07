using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_DependentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Edit_Dependent_RequestType Edit_Dependent_Request;

		public Edit_DependentInput()
		{
		}

		public Edit_DependentInput(Workday_Common_HeaderType Workday_Common_Header, Edit_Dependent_RequestType Edit_Dependent_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Edit_Dependent_Request = Edit_Dependent_Request;
		}
	}
}
