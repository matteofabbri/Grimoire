using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Resource_ForecastsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Resource_Forecasts_ResponseType Get_Resource_Forecasts_Response;

		public Get_Resource_ForecastsOutput()
		{
		}

		public Get_Resource_ForecastsOutput(Get_Resource_Forecasts_ResponseType Get_Resource_Forecasts_Response)
		{
			this.Get_Resource_Forecasts_Response = Get_Resource_Forecasts_Response;
		}
	}
}
