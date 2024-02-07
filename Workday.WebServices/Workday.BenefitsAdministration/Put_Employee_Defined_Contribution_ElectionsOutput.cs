using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Employee_Defined_Contribution_ElectionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Employee_Defined_Contribution_Elections_ResponseType Put_Employee_Defined_Contribution_Elections_Response;

		public Put_Employee_Defined_Contribution_ElectionsOutput()
		{
		}

		public Put_Employee_Defined_Contribution_ElectionsOutput(Put_Employee_Defined_Contribution_Elections_ResponseType Put_Employee_Defined_Contribution_Elections_Response)
		{
			this.Put_Employee_Defined_Contribution_Elections_Response = Put_Employee_Defined_Contribution_Elections_Response;
		}
	}
}
