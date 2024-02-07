using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Procurement_Document_Attachment_RequestType : INotifyPropertyChanged
	{
		private Business_DocumentObjectType document_ReferenceField;

		private Business_Document_Attachment_with_External_Option_DataType document_Attachment_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Business_DocumentObjectType Document_Reference
		{
			get
			{
				return this.document_ReferenceField;
			}
			set
			{
				this.document_ReferenceField = value;
				this.RaisePropertyChanged("Document_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Business_Document_Attachment_with_External_Option_DataType Document_Attachment_Data
		{
			get
			{
				return this.document_Attachment_DataField;
			}
			set
			{
				this.document_Attachment_DataField = value;
				this.RaisePropertyChanged("Document_Attachment_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
