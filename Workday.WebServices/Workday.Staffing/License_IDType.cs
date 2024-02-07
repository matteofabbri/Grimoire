using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class License_IDType : INotifyPropertyChanged
	{
		private License_IdentifierObjectType license_ID_ReferenceField;

		private License_ID_DataType license_ID_DataField;

		private License_Identifier_ReferenceObjectType license_ID_Shared_ReferenceField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public License_IdentifierObjectType License_ID_Reference
		{
			get
			{
				return this.license_ID_ReferenceField;
			}
			set
			{
				this.license_ID_ReferenceField = value;
				this.RaisePropertyChanged("License_ID_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public License_ID_DataType License_ID_Data
		{
			get
			{
				return this.license_ID_DataField;
			}
			set
			{
				this.license_ID_DataField = value;
				this.RaisePropertyChanged("License_ID_Data");
			}
		}

		[XmlElement(Order = 2)]
		public License_Identifier_ReferenceObjectType License_ID_Shared_Reference
		{
			get
			{
				return this.license_ID_Shared_ReferenceField;
			}
			set
			{
				this.license_ID_Shared_ReferenceField = value;
				this.RaisePropertyChanged("License_ID_Shared_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
				this.RaisePropertyChanged("Delete");
			}
		}

		[XmlIgnore]
		public bool DeleteSpecified
		{
			get
			{
				return this.deleteFieldSpecified;
			}
			set
			{
				this.deleteFieldSpecified = value;
				this.RaisePropertyChanged("DeleteSpecified");
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
