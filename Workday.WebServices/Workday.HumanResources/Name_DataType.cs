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
	public class Name_DataType : INotifyPropertyChanged
	{
		private Country_ReferenceType country_ReferenceField;

		private string additional_Name_TypeField;

		private Prefix_Name_DataType[] prefixField;

		private string first_NameField;

		private string middle_NameField;

		private Last_Name_DataType[] last_NameField;

		private Local_Name_DataType local_Name_DataField;

		private Suffix_Name_DataType[] suffixField;

		private bool is_LegalField;

		private bool is_LegalFieldSpecified;

		private bool is_PreferredField;

		private bool is_PreferredFieldSpecified;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private DateTime last_ModifiedField;

		private bool last_ModifiedFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Country_ReferenceType Country_Reference
		{
			get
			{
				return this.country_ReferenceField;
			}
			set
			{
				this.country_ReferenceField = value;
				this.RaisePropertyChanged("Country_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Additional_Name_Type
		{
			get
			{
				return this.additional_Name_TypeField;
			}
			set
			{
				this.additional_Name_TypeField = value;
				this.RaisePropertyChanged("Additional_Name_Type");
			}
		}

		[XmlElement("Prefix", Order = 2)]
		public Prefix_Name_DataType[] Prefix
		{
			get
			{
				return this.prefixField;
			}
			set
			{
				this.prefixField = value;
				this.RaisePropertyChanged("Prefix");
			}
		}

		[XmlElement(Order = 3)]
		public string First_Name
		{
			get
			{
				return this.first_NameField;
			}
			set
			{
				this.first_NameField = value;
				this.RaisePropertyChanged("First_Name");
			}
		}

		[XmlElement(Order = 4)]
		public string Middle_Name
		{
			get
			{
				return this.middle_NameField;
			}
			set
			{
				this.middle_NameField = value;
				this.RaisePropertyChanged("Middle_Name");
			}
		}

		[XmlElement("Last_Name", Order = 5)]
		public Last_Name_DataType[] Last_Name
		{
			get
			{
				return this.last_NameField;
			}
			set
			{
				this.last_NameField = value;
				this.RaisePropertyChanged("Last_Name");
			}
		}

		[XmlElement(Order = 6)]
		public Local_Name_DataType Local_Name_Data
		{
			get
			{
				return this.local_Name_DataField;
			}
			set
			{
				this.local_Name_DataField = value;
				this.RaisePropertyChanged("Local_Name_Data");
			}
		}

		[XmlElement("Suffix", Order = 7)]
		public Suffix_Name_DataType[] Suffix
		{
			get
			{
				return this.suffixField;
			}
			set
			{
				this.suffixField = value;
				this.RaisePropertyChanged("Suffix");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Is_Legal
		{
			get
			{
				return this.is_LegalField;
			}
			set
			{
				this.is_LegalField = value;
				this.RaisePropertyChanged("Is_Legal");
			}
		}

		[XmlIgnore]
		public bool Is_LegalSpecified
		{
			get
			{
				return this.is_LegalFieldSpecified;
			}
			set
			{
				this.is_LegalFieldSpecified = value;
				this.RaisePropertyChanged("Is_LegalSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Is_Preferred
		{
			get
			{
				return this.is_PreferredField;
			}
			set
			{
				this.is_PreferredField = value;
				this.RaisePropertyChanged("Is_Preferred");
			}
		}

		[XmlIgnore]
		public bool Is_PreferredSpecified
		{
			get
			{
				return this.is_PreferredFieldSpecified;
			}
			set
			{
				this.is_PreferredFieldSpecified = value;
				this.RaisePropertyChanged("Is_PreferredSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified, DataType = "date")]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public DateTime Last_Modified
		{
			get
			{
				return this.last_ModifiedField;
			}
			set
			{
				this.last_ModifiedField = value;
				this.RaisePropertyChanged("Last_Modified");
			}
		}

		[XmlIgnore]
		public bool Last_ModifiedSpecified
		{
			get
			{
				return this.last_ModifiedFieldSpecified;
			}
			set
			{
				this.last_ModifiedFieldSpecified = value;
				this.RaisePropertyChanged("Last_ModifiedSpecified");
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
