using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Professional_Affiliation_Type_RequestType : INotifyPropertyChanged
	{
		private bool deleteField;

		private bool deleteFieldSpecified;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private Professional_Affiliation_TypeObjectType professional_Affiliation_Type_ReferenceField;

		private Professional_Affiliation_Type_DataType professional_Affiliation_Type_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Professional_Affiliation_TypeObjectType Professional_Affiliation_Type_Reference
		{
			get
			{
				return this.professional_Affiliation_Type_ReferenceField;
			}
			set
			{
				this.professional_Affiliation_Type_ReferenceField = value;
				this.RaisePropertyChanged("Professional_Affiliation_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Professional_Affiliation_Type_DataType Professional_Affiliation_Type_Data
		{
			get
			{
				return this.professional_Affiliation_Type_DataField;
			}
			set
			{
				this.professional_Affiliation_Type_DataField = value;
				this.RaisePropertyChanged("Professional_Affiliation_Type_Data");
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
