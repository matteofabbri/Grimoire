using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_OneTime_Payment_Plan_Configurable_CategoriesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Name = "Get_One-Time_Payment_Plan_Configurable_Categories_Request", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Get_One-Time_Payment_Plan_Configurable_Categories_Request")]
		public Get_OneTime_Payment_Plan_Configurable_Categories_RequestType Get_OneTime_Payment_Plan_Configurable_Categories_Request;

		public Get_OneTime_Payment_Plan_Configurable_CategoriesInput()
		{
		}

		public Get_OneTime_Payment_Plan_Configurable_CategoriesInput(Workday_Common_HeaderType Workday_Common_Header, Get_OneTime_Payment_Plan_Configurable_Categories_RequestType Get_OneTime_Payment_Plan_Configurable_Categories_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_OneTime_Payment_Plan_Configurable_Categories_Request = Get_OneTime_Payment_Plan_Configurable_Categories_Request;
		}
	}
}
