using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Catalog_of_Federal_Domestic_Assistance_RequestType : INotifyPropertyChanged
	{
		private Catalog_of_Federal_Domestic_AssistanceObjectType catalog_of_Federal_Domestic_Assistance_ReferenceField;

		private Catalog_of_Federal_Domestic_Assistance_DataType catalog_of_Federal_Domestic_Assistance_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private bool deleteField;

		private bool deleteFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Catalog_of_Federal_Domestic_AssistanceObjectType Catalog_of_Federal_Domestic_Assistance_Reference
		{
			get
			{
				return this.catalog_of_Federal_Domestic_Assistance_ReferenceField;
			}
			set
			{
				this.catalog_of_Federal_Domestic_Assistance_ReferenceField = value;
				this.RaisePropertyChanged("Catalog_of_Federal_Domestic_Assistance_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Catalog_of_Federal_Domestic_Assistance_DataType Catalog_of_Federal_Domestic_Assistance_Data
		{
			get
			{
				return this.catalog_of_Federal_Domestic_Assistance_DataField;
			}
			set
			{
				this.catalog_of_Federal_Domestic_Assistance_DataField = value;
				this.RaisePropertyChanged("Catalog_of_Federal_Domestic_Assistance_Data");
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
