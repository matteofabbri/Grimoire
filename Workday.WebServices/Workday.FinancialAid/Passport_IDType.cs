using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Passport_IDType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType passport_ID_ReferenceField;

		private Passport_ID_DataType passport_ID_DataField;

		private Passport_Identifier_ReferenceObjectType passport_ID_Shared_ReferenceField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Passport_ID_Reference
		{
			get
			{
				return this.passport_ID_ReferenceField;
			}
			set
			{
				this.passport_ID_ReferenceField = value;
				this.RaisePropertyChanged("Passport_ID_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Passport_ID_DataType Passport_ID_Data
		{
			get
			{
				return this.passport_ID_DataField;
			}
			set
			{
				this.passport_ID_DataField = value;
				this.RaisePropertyChanged("Passport_ID_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Passport_Identifier_ReferenceObjectType Passport_ID_Shared_Reference
		{
			get
			{
				return this.passport_ID_Shared_ReferenceField;
			}
			set
			{
				this.passport_ID_Shared_ReferenceField = value;
				this.RaisePropertyChanged("Passport_ID_Shared_Reference");
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
