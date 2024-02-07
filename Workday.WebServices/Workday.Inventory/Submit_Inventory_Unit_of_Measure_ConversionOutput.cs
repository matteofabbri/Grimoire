using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Inventory_Unit_of_Measure_ConversionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Inventory_Unit_of_Measure_Conversion_ResponseType Submit_Inventory_Unit_of_Measure_Conversion_Response;

		public Submit_Inventory_Unit_of_Measure_ConversionOutput()
		{
		}

		public Submit_Inventory_Unit_of_Measure_ConversionOutput(Submit_Inventory_Unit_of_Measure_Conversion_ResponseType Submit_Inventory_Unit_of_Measure_Conversion_Response)
		{
			this.Submit_Inventory_Unit_of_Measure_Conversion_Response = Submit_Inventory_Unit_of_Measure_Conversion_Response;
		}
	}
}
