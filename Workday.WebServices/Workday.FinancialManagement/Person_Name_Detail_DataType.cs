using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Person_Name_Detail_DataType : INotifyPropertyChanged
	{
		private CountryObjectType country_ReferenceField;

		private Person_Name_Prefix_DataType prefix_DataField;

		private string first_NameField;

		private string middle_NameField;

		private string last_NameField;

		private string secondary_Last_NameField;

		private Local_Person_Name_Detail_DataType local_Name_Detail_DataField;

		private Person_Name_Suffix_DataType suffix_DataField;

		private string full_Name_for_Singapore_and_MalaysiaField;

		private string formatted_NameField;

		private string reporting_NameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CountryObjectType Country_Reference
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
		public Person_Name_Prefix_DataType Prefix_Data
		{
			get
			{
				return this.prefix_DataField;
			}
			set
			{
				this.prefix_DataField = value;
				this.RaisePropertyChanged("Prefix_Data");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public string Last_Name
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

		[XmlElement(Order = 5)]
		public string Secondary_Last_Name
		{
			get
			{
				return this.secondary_Last_NameField;
			}
			set
			{
				this.secondary_Last_NameField = value;
				this.RaisePropertyChanged("Secondary_Last_Name");
			}
		}

		[XmlElement(Order = 6)]
		public Local_Person_Name_Detail_DataType Local_Name_Detail_Data
		{
			get
			{
				return this.local_Name_Detail_DataField;
			}
			set
			{
				this.local_Name_Detail_DataField = value;
				this.RaisePropertyChanged("Local_Name_Detail_Data");
			}
		}

		[XmlElement(Order = 7)]
		public Person_Name_Suffix_DataType Suffix_Data
		{
			get
			{
				return this.suffix_DataField;
			}
			set
			{
				this.suffix_DataField = value;
				this.RaisePropertyChanged("Suffix_Data");
			}
		}

		[XmlElement(Order = 8)]
		public string Full_Name_for_Singapore_and_Malaysia
		{
			get
			{
				return this.full_Name_for_Singapore_and_MalaysiaField;
			}
			set
			{
				this.full_Name_for_Singapore_and_MalaysiaField = value;
				this.RaisePropertyChanged("Full_Name_for_Singapore_and_Malaysia");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Formatted_Name
		{
			get
			{
				return this.formatted_NameField;
			}
			set
			{
				this.formatted_NameField = value;
				this.RaisePropertyChanged("Formatted_Name");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Reporting_Name
		{
			get
			{
				return this.reporting_NameField;
			}
			set
			{
				this.reporting_NameField = value;
				this.RaisePropertyChanged("Reporting_Name");
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
