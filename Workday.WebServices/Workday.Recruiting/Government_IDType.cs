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
	public class Government_IDType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType government_ID_ReferenceField;

		private Government_ID_DataType government_ID_DataField;

		private Government_Identifier_ReferenceObjectType government_ID_Shared_ReferenceField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Government_ID_Reference
		{
			get
			{
				return this.government_ID_ReferenceField;
			}
			set
			{
				this.government_ID_ReferenceField = value;
				this.RaisePropertyChanged("Government_ID_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Government_ID_DataType Government_ID_Data
		{
			get
			{
				return this.government_ID_DataField;
			}
			set
			{
				this.government_ID_DataField = value;
				this.RaisePropertyChanged("Government_ID_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Government_Identifier_ReferenceObjectType Government_ID_Shared_Reference
		{
			get
			{
				return this.government_ID_Shared_ReferenceField;
			}
			set
			{
				this.government_ID_Shared_ReferenceField = value;
				this.RaisePropertyChanged("Government_ID_Shared_Reference");
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
