using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Internal_CatalogInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Internal_Catalog_RequestType Put_Internal_Catalog_Request;

		public Put_Internal_CatalogInput()
		{
		}

		public Put_Internal_CatalogInput(Workday_Common_HeaderType Workday_Common_Header, Put_Internal_Catalog_RequestType Put_Internal_Catalog_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Internal_Catalog_Request = Put_Internal_Catalog_Request;
		}
	}
}
