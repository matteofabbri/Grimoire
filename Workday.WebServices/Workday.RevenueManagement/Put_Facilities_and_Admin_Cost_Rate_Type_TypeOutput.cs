using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Facilities_and_Admin_Cost_Rate_Type_TypeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Facilities_and_Admin_Cost_Rate_Type_Type_ResponseType Put_Facilities_and_Admin_Cost_Rate_Type_Type_Response;

		public Put_Facilities_and_Admin_Cost_Rate_Type_TypeOutput()
		{
		}

		public Put_Facilities_and_Admin_Cost_Rate_Type_TypeOutput(Put_Facilities_and_Admin_Cost_Rate_Type_Type_ResponseType Put_Facilities_and_Admin_Cost_Rate_Type_Type_Response)
		{
			this.Put_Facilities_and_Admin_Cost_Rate_Type_Type_Response = Put_Facilities_and_Admin_Cost_Rate_Type_Type_Response;
		}
	}
}
