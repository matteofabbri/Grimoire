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
	public class Relative_Name_DataType : INotifyPropertyChanged
	{
		private Relative_Name_ReferenceObjectType relative_Name_Reference_ReferenceField;

		private Relative_TypeObjectType relative_Type_ReferenceField;

		private Person_Name_Detail_DataType name_Detail_DataField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Relative_Name_ReferenceObjectType Relative_Name_Reference_Reference
		{
			get
			{
				return this.relative_Name_Reference_ReferenceField;
			}
			set
			{
				this.relative_Name_Reference_ReferenceField = value;
				this.RaisePropertyChanged("Relative_Name_Reference_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Relative_TypeObjectType Relative_Type_Reference
		{
			get
			{
				return this.relative_Type_ReferenceField;
			}
			set
			{
				this.relative_Type_ReferenceField = value;
				this.RaisePropertyChanged("Relative_Type_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Person_Name_Detail_DataType Name_Detail_Data
		{
			get
			{
				return this.name_Detail_DataField;
			}
			set
			{
				this.name_Detail_DataField = value;
				this.RaisePropertyChanged("Name_Detail_Data");
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
