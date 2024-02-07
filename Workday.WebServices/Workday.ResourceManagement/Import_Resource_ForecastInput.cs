using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Resource_ForecastInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Import_Resource_Forecast_RequestType Import_Resource_Forecast_Request;

		public Import_Resource_ForecastInput()
		{
		}

		public Import_Resource_ForecastInput(Workday_Common_HeaderType Workday_Common_Header, Import_Resource_Forecast_RequestType Import_Resource_Forecast_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_Resource_Forecast_Request = Import_Resource_Forecast_Request;
		}
	}
}
