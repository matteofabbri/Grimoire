using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Add_DependentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Add_Dependent_RequestType Add_Dependent_Request;

		public Add_DependentInput()
		{
		}

		public Add_DependentInput(Workday_Common_HeaderType Workday_Common_Header, Add_Dependent_RequestType Add_Dependent_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Add_Dependent_Request = Add_Dependent_Request;
		}
	}
}
