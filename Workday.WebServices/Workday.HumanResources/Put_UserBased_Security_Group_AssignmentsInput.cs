using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_UserBased_Security_Group_AssignmentsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Name = "Put_Assign_User-Based_Security_Groups_Request", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Put_Assign_User-Based_Security_Groups_Request")]
		public Put_Assign_UserBased_Security_Groups_RequestType Put_Assign_UserBased_Security_Groups_Request;

		public Put_UserBased_Security_Group_AssignmentsInput()
		{
		}

		public Put_UserBased_Security_Group_AssignmentsInput(Workday_Common_HeaderType Workday_Common_Header, Put_Assign_UserBased_Security_Groups_RequestType Put_Assign_UserBased_Security_Groups_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Assign_UserBased_Security_Groups_Request = Put_Assign_UserBased_Security_Groups_Request;
		}
	}
}
