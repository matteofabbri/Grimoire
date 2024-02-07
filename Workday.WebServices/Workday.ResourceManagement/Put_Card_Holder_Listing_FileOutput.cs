using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Card_Holder_Listing_FileOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Card_Holder_Listing_File_ResponseType Put_Card_Holder_Listing_File_Response;

		public Put_Card_Holder_Listing_FileOutput()
		{
		}

		public Put_Card_Holder_Listing_FileOutput(Put_Card_Holder_Listing_File_ResponseType Put_Card_Holder_Listing_File_Response)
		{
			this.Put_Card_Holder_Listing_File_Response = Put_Card_Holder_Listing_File_Response;
		}
	}
}
