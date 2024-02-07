using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Former_Worker_Document_RequestType : INotifyPropertyChanged
	{
		private Former_Worker_AttachmentObjectType former_Worker_Document_ReferenceField;

		private Former_Worker_Attachment_DataType former_Worker_Document_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Former_Worker_AttachmentObjectType Former_Worker_Document_Reference
		{
			get
			{
				return this.former_Worker_Document_ReferenceField;
			}
			set
			{
				this.former_Worker_Document_ReferenceField = value;
				this.RaisePropertyChanged("Former_Worker_Document_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Former_Worker_Attachment_DataType Former_Worker_Document_Data
		{
			get
			{
				return this.former_Worker_Document_DataField;
			}
			set
			{
				this.former_Worker_Document_DataField = value;
				this.RaisePropertyChanged("Former_Worker_Document_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
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
