using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Employee_Defined_Contribution_ElectionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Employee_Defined_Contribution_Elections_ResponseType Get_Employee_Defined_Contribution_Elections_Response;

		public Get_Employee_Defined_Contribution_ElectionsOutput()
		{
		}

		public Get_Employee_Defined_Contribution_ElectionsOutput(Get_Employee_Defined_Contribution_Elections_ResponseType Get_Employee_Defined_Contribution_Elections_Response)
		{
			this.Get_Employee_Defined_Contribution_Elections_Response = Get_Employee_Defined_Contribution_Elections_Response;
		}
	}
}
