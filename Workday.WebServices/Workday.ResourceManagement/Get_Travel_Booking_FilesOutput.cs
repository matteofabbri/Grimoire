using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Travel_Booking_FilesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Travel_Booking_Files_ResponseType Get_Travel_Booking_Files_Response;

		public Get_Travel_Booking_FilesOutput()
		{
		}

		public Get_Travel_Booking_FilesOutput(Get_Travel_Booking_Files_ResponseType Get_Travel_Booking_Files_Response)
		{
			this.Get_Travel_Booking_Files_Response = Get_Travel_Booking_Files_Response;
		}
	}
}
