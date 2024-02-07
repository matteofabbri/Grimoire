using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Person_DataType : INotifyPropertyChanged
	{
		private Name_DataType[] name_DataField;

		private Contact_DataType contact_DataField;

		private Demographic_DataType demographic_DataField;

		private Biographic_DataType biographic_DataField;

		private Visa_Identifier_DataType[] visa_ID_DataField;

		private Custom_Identifier_DataType[] custom_ID_DataField;

		private Government_Identifier_DataType[] government_ID_DataField;

		private License_Identifier_DataType[] license_ID_DataField;

		private Passport_Identifier_DataType[] passport_ID_DataField;

		private Personal_Preferences_DataType personal_Preferences_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Name_Data", Order = 0)]
		public Name_DataType[] Name_Data
		{
			get
			{
				return this.name_DataField;
			}
			set
			{
				this.name_DataField = value;
				this.RaisePropertyChanged("Name_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Contact_DataType Contact_Data
		{
			get
			{
				return this.contact_DataField;
			}
			set
			{
				this.contact_DataField = value;
				this.RaisePropertyChanged("Contact_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Demographic_DataType Demographic_Data
		{
			get
			{
				return this.demographic_DataField;
			}
			set
			{
				this.demographic_DataField = value;
				this.RaisePropertyChanged("Demographic_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Biographic_DataType Biographic_Data
		{
			get
			{
				return this.biographic_DataField;
			}
			set
			{
				this.biographic_DataField = value;
				this.RaisePropertyChanged("Biographic_Data");
			}
		}

		[XmlElement("Visa_ID_Data", Order = 4)]
		public Visa_Identifier_DataType[] Visa_ID_Data
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

		[XmlElement("Custom_ID_Data", Order = 5)]
		public Custom_Identifier_DataType[] Custom_ID_Data
		{
			get
			{
				return this.custom_ID_DataField;
			}
			set
			{
				this.custom_ID_DataField = value;
				this.RaisePropertyChanged("Custom_ID_Data");
			}
		}

		[XmlElement("Government_ID_Data", Order = 6)]
		public Government_Identifier_DataType[] Government_ID_Data
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

		[XmlElement("License_ID_Data", Order = 7)]
		public License_Identifier_DataType[] License_ID_Data
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

		[XmlElement("Passport_ID_Data", Order = 8)]
		public Passport_Identifier_DataType[] Passport_ID_Data
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

		[XmlElement(Order = 9)]
		public Personal_Preferences_DataType Personal_Preferences_Data
		{
			get
			{
				return this.personal_Preferences_DataField;
			}
			set
			{
				this.personal_Preferences_DataField = value;
				this.RaisePropertyChanged("Personal_Preferences_Data");
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
