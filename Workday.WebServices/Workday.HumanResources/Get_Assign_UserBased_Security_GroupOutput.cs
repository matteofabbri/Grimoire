using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Assign_UserBased_Security_GroupOutput
	{
		[MessageBodyMember(Name = "Get_Assign_User-Based_Security_Group_Response", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Get_Assign_User-Based_Security_Group_Response")]
		public Get_Assign_UserBased_Security_Group_ResponseType Get_Assign_UserBased_Security_Group_Response;

		public Get_Assign_UserBased_Security_GroupOutput()
		{
		}

		public Get_Assign_UserBased_Security_GroupOutput(Get_Assign_UserBased_Security_Group_ResponseType Get_Assign_UserBased_Security_Group_Response)
		{
			this.Get_Assign_UserBased_Security_Group_Response = Get_Assign_UserBased_Security_Group_Response;
		}
	}
}
