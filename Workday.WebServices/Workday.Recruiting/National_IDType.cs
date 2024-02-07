using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class National_IDType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType national_ID_ReferenceField;

		private National_ID_DataType national_ID_DataField;

		private National_Identifier_ReferenceObjectType national_ID_Shared_ReferenceField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType National_ID_Reference
		{
			get
			{
				return this.national_ID_ReferenceField;
			}
			set
			{
				this.national_ID_ReferenceField = value;
				this.RaisePropertyChanged("National_ID_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public National_ID_DataType National_ID_Data
		{
			get
			{
				return this.national_ID_DataField;
			}
			set
			{
				this.national_ID_DataField = value;
				this.RaisePropertyChanged("National_ID_Data");
			}
		}

		[XmlElement(Order = 2)]
		public National_Identifier_ReferenceObjectType National_ID_Shared_Reference
		{
			get
			{
				return this.national_ID_Shared_ReferenceField;
			}
			set
			{
				this.national_ID_Shared_ReferenceField = value;
				this.RaisePropertyChanged("National_ID_Shared_Reference");
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
