using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_OneTime_Payment_Plan_Configurable_CategoryOutput
	{
		[MessageBodyMember(Name = "Put_One-Time_Payment_Plan_Configurable_Category_Response", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Put_One-Time_Payment_Plan_Configurable_Category_Response")]
		public Put_OneTime_Payment_Plan_Configurable_Category_ResponseType Put_OneTime_Payment_Plan_Configurable_Category_Response;

		public Put_OneTime_Payment_Plan_Configurable_CategoryOutput()
		{
		}

		public Put_OneTime_Payment_Plan_Configurable_CategoryOutput(Put_OneTime_Payment_Plan_Configurable_Category_ResponseType Put_OneTime_Payment_Plan_Configurable_Category_Response)
		{
			this.Put_OneTime_Payment_Plan_Configurable_Category_Response = Put_OneTime_Payment_Plan_Configurable_Category_Response;
		}
	}
}
