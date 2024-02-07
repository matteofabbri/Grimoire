using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_OneTime_Payment_Plan_Configurable_CategoryInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Name = "Put_One-Time_Payment_Plan_Configurable_Category_Request", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Put_One-Time_Payment_Plan_Configurable_Category_Request")]
		public Put_OneTime_Payment_Plan_Configurable_Category_RequestType Put_OneTime_Payment_Plan_Configurable_Category_Request;

		public Put_OneTime_Payment_Plan_Configurable_CategoryInput()
		{
		}

		public Put_OneTime_Payment_Plan_Configurable_CategoryInput(Workday_Common_HeaderType Workday_Common_Header, Put_OneTime_Payment_Plan_Configurable_Category_RequestType Put_OneTime_Payment_Plan_Configurable_Category_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_OneTime_Payment_Plan_Configurable_Category_Request = Put_OneTime_Payment_Plan_Configurable_Category_Request;
		}
	}
}
