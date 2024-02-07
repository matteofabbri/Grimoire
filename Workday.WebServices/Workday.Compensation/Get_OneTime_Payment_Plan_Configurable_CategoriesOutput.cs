using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_OneTime_Payment_Plan_Configurable_CategoriesOutput
	{
		[MessageBodyMember(Name = "Get_One-Time_Payment_Plan_Configurable_Categories_Response", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Get_One-Time_Payment_Plan_Configurable_Categories_Response")]
		public Get_OneTime_Payment_Plan_Configurable_Categories_ResponseType Get_OneTime_Payment_Plan_Configurable_Categories_Response;

		public Get_OneTime_Payment_Plan_Configurable_CategoriesOutput()
		{
		}

		public Get_OneTime_Payment_Plan_Configurable_CategoriesOutput(Get_OneTime_Payment_Plan_Configurable_Categories_ResponseType Get_OneTime_Payment_Plan_Configurable_Categories_Response)
		{
			this.Get_OneTime_Payment_Plan_Configurable_Categories_Response = Get_OneTime_Payment_Plan_Configurable_Categories_Response;
		}
	}
}
