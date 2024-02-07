using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_1095C_Form_Recipients_DataInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Name = "Import_ACA_1095-C_Forms_Data_Request", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Import_ACA_1095-C_Forms_Data_Request")]
		public Import_ACA_1095C_Forms_Data_RequestType Import_ACA_1095C_Forms_Data_Request;

		public Import_1095C_Form_Recipients_DataInput()
		{
		}

		public Import_1095C_Form_Recipients_DataInput(Workday_Common_HeaderType Workday_Common_Header, Import_ACA_1095C_Forms_Data_RequestType Import_ACA_1095C_Forms_Data_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_ACA_1095C_Forms_Data_Request = Import_ACA_1095C_Forms_Data_Request;
		}
	}
}
