using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Employee_Information_DataType : INotifyPropertyChanged
	{
		private string employee_First_NameField;

		private string employee_Middle_NameField;

		private string employee_Last_NameField;

		private string employee_Suffix_NameField;

		private string social_Security_NumberField;

		private string street_AddressField;

		private string city_or_TownField;

		private string two_Letter_State_Code_or_Foreign_ProvinceField;

		private string two_Letter_ISO_Country_CodeField;

		private string zIP_Code_or_Foreign_Postal_CodeField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Employee_First_Name
		{
			get
			{
				return this.employee_First_NameField;
			}
			set
			{
				this.employee_First_NameField = value;
				this.RaisePropertyChanged("Employee_First_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Employee_Middle_Name
		{
			get
			{
				return this.employee_Middle_NameField;
			}
			set
			{
				this.employee_Middle_NameField = value;
				this.RaisePropertyChanged("Employee_Middle_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Employee_Last_Name
		{
			get
			{
				return this.employee_Last_NameField;
			}
			set
			{
				this.employee_Last_NameField = value;
				this.RaisePropertyChanged("Employee_Last_Name");
			}
		}

		[XmlElement(Order = 3)]
		public string Employee_Suffix_Name
		{
			get
			{
				return this.employee_Suffix_NameField;
			}
			set
			{
				this.employee_Suffix_NameField = value;
				this.RaisePropertyChanged("Employee_Suffix_Name");
			}
		}

		[XmlElement(Order = 4)]
		public string Social_Security_Number
		{
			get
			{
				return this.social_Security_NumberField;
			}
			set
			{
				this.social_Security_NumberField = value;
				this.RaisePropertyChanged("Social_Security_Number");
			}
		}

		[XmlElement(Order = 5)]
		public string Street_Address
		{
			get
			{
				return this.street_AddressField;
			}
			set
			{
				this.street_AddressField = value;
				this.RaisePropertyChanged("Street_Address");
			}
		}

		[XmlElement(Order = 6)]
		public string City_or_Town
		{
			get
			{
				return this.city_or_TownField;
			}
			set
			{
				this.city_or_TownField = value;
				this.RaisePropertyChanged("City_or_Town");
			}
		}

		[XmlElement(Order = 7)]
		public string Two_Letter_State_Code_or_Foreign_Province
		{
			get
			{
				return this.two_Letter_State_Code_or_Foreign_ProvinceField;
			}
			set
			{
				this.two_Letter_State_Code_or_Foreign_ProvinceField = value;
				this.RaisePropertyChanged("Two_Letter_State_Code_or_Foreign_Province");
			}
		}

		[XmlElement(Order = 8)]
		public string Two_Letter_ISO_Country_Code
		{
			get
			{
				return this.two_Letter_ISO_Country_CodeField;
			}
			set
			{
				this.two_Letter_ISO_Country_CodeField = value;
				this.RaisePropertyChanged("Two_Letter_ISO_Country_Code");
			}
		}

		[XmlElement(Order = 9)]
		public string ZIP_Code_or_Foreign_Postal_Code
		{
			get
			{
				return this.zIP_Code_or_Foreign_Postal_CodeField;
			}
			set
			{
				this.zIP_Code_or_Foreign_Postal_CodeField = value;
				this.RaisePropertyChanged("ZIP_Code_or_Foreign_Postal_Code");
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
