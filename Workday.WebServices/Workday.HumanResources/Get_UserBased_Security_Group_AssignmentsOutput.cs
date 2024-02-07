using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_UserBased_Security_Group_AssignmentsOutput
	{
		[MessageBodyMember(Name = "Get_Assign_User-Based_Security_Groups_Response", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Get_Assign_User-Based_Security_Groups_Response")]
		public Get_Assign_UserBased_Security_Groups_ResponseType Get_Assign_UserBased_Security_Groups_Response;

		public Get_UserBased_Security_Group_AssignmentsOutput()
		{
		}

		public Get_UserBased_Security_Group_AssignmentsOutput(Get_Assign_UserBased_Security_Groups_ResponseType Get_Assign_UserBased_Security_Groups_Response)
		{
			this.Get_Assign_UserBased_Security_Groups_Response = Get_Assign_UserBased_Security_Groups_Response;
		}
	}
}
