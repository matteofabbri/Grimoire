using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Worker_Travel_Profile_Listing_FilesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Worker_Travel_Profile_Listing_Files_ResponseType Get_Worker_Travel_Profile_Listing_Files_Response;

		public Get_Worker_Travel_Profile_Listing_FilesOutput()
		{
		}

		public Get_Worker_Travel_Profile_Listing_FilesOutput(Get_Worker_Travel_Profile_Listing_Files_ResponseType Get_Worker_Travel_Profile_Listing_Files_Response)
		{
			this.Get_Worker_Travel_Profile_Listing_Files_Response = Get_Worker_Travel_Profile_Listing_Files_Response;
		}
	}
}
