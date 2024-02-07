using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Project_Worker_RoleOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Project_Worker_Role_ResponseType Put_Project_Worker_Role_Response;

		public Put_Project_Worker_RoleOutput()
		{
		}

		public Put_Project_Worker_RoleOutput(Put_Project_Worker_Role_ResponseType Put_Project_Worker_Role_Response)
		{
			this.Put_Project_Worker_Role_Response = Put_Project_Worker_Role_Response;
		}
	}
}
