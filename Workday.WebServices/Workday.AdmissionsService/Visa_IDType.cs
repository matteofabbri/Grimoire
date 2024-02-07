using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Admissions
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Visa_IDType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType visa_ID_ReferenceField;

		private Visa_ID_DataType visa_ID_DataField;

		private Visa_Identifier_ReferenceObjectType visa_ID_Shared_ReferenceField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Visa_ID_Reference
		{
			get
			{
				return this.visa_ID_ReferenceField;
			}
			set
			{
				this.visa_ID_ReferenceField = value;
				this.RaisePropertyChanged("Visa_ID_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Visa_ID_DataType Visa_ID_Data
		{
			get
			{
				return this.visa_ID_DataField;
			}
			set
			{
				this.visa_ID_DataField = value;
				this.RaisePropertyChanged("Visa_ID_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Visa_Identifier_ReferenceObjectType Visa_ID_Shared_Reference
		{
			get
			{
				return this.visa_ID_Shared_ReferenceField;
			}
			set
			{
				this.visa_ID_Shared_ReferenceField = value;
				this.RaisePropertyChanged("Visa_ID_Shared_Reference");
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
