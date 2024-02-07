using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Student_Personal_InformationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Import_Student_Personal_Information_RequestType Import_Student_Personal_Information_Request;

		public Import_Student_Personal_InformationInput()
		{
		}

		public Import_Student_Personal_InformationInput(Workday_Common_HeaderType Workday_Common_Header, Import_Student_Personal_Information_RequestType Import_Student_Personal_Information_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_Student_Personal_Information_Request = Import_Student_Personal_Information_Request;
		}
	}
}
