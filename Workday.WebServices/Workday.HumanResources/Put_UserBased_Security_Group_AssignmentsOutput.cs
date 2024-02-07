using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_UserBased_Security_Group_AssignmentsOutput
	{
		[MessageBodyMember(Name = "Put_Assign_User-Based_Security_Groups_Response", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Put_Assign_User-Based_Security_Groups_Response")]
		public Put_Assign_UserBased_Security_Groups_ResponseType Put_Assign_UserBased_Security_Groups_Response;

		public Put_UserBased_Security_Group_AssignmentsOutput()
		{
		}

		public Put_UserBased_Security_Group_AssignmentsOutput(Put_Assign_UserBased_Security_Groups_ResponseType Put_Assign_UserBased_Security_Groups_Response)
		{
			this.Put_Assign_UserBased_Security_Groups_Response = Put_Assign_UserBased_Security_Groups_Response;
		}
	}
}
