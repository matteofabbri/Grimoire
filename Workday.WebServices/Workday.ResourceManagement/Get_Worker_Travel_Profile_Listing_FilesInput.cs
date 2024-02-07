using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Worker_Travel_Profile_Listing_FilesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Worker_Travel_Profile_Listing_Files_RequestType Get_Worker_Travel_Profile_Listing_Files_Request;

		public Get_Worker_Travel_Profile_Listing_FilesInput()
		{
		}

		public Get_Worker_Travel_Profile_Listing_FilesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Worker_Travel_Profile_Listing_Files_RequestType Get_Worker_Travel_Profile_Listing_Files_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Worker_Travel_Profile_Listing_Files_Request = Get_Worker_Travel_Profile_Listing_Files_Request;
		}
	}
}
