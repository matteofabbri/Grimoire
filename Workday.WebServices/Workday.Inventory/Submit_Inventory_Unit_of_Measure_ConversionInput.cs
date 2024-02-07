using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Inventory_Unit_of_Measure_ConversionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Inventory_Unit_of_Measure_Conversion_RequestType Submit_Inventory_Unit_of_Measure_Conversion_Request;

		public Submit_Inventory_Unit_of_Measure_ConversionInput()
		{
		}

		public Submit_Inventory_Unit_of_Measure_ConversionInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Inventory_Unit_of_Measure_Conversion_RequestType Submit_Inventory_Unit_of_Measure_Conversion_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Inventory_Unit_of_Measure_Conversion_Request = Submit_Inventory_Unit_of_Measure_Conversion_Request;
		}
	}
}
