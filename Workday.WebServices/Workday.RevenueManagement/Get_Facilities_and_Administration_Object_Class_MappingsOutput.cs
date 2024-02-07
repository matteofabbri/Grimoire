using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Facilities_and_Administration_Object_Class_MappingsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Facilities_and_Admin_Object_Class_Mappings_ResponseType Get_Facilities_and_Admin_Object_Class_Mappings_Response;

		public Get_Facilities_and_Administration_Object_Class_MappingsOutput()
		{
		}

		public Get_Facilities_and_Administration_Object_Class_MappingsOutput(Get_Facilities_and_Admin_Object_Class_Mappings_ResponseType Get_Facilities_and_Admin_Object_Class_Mappings_Response)
		{
			this.Get_Facilities_and_Admin_Object_Class_Mappings_Response = Get_Facilities_and_Admin_Object_Class_Mappings_Response;
		}
	}
}
