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
	public class XMLNAME_1099_Company_DataType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private string organization_NameField;

		private string tax_IDField;

		private string tCC_IDField;

		private bool foreign_Entity_IndicatorField;

		private bool foreign_Entity_IndicatorFieldSpecified;

		private string primary_Fully_Composed_Address_without_CountryField;

		private Address_Information_DataType[] address_DataField;

		private string phone_NumberField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Organization_Name
		{
			get
			{
				return this.organization_NameField;
			}
			set
			{
				this.organization_NameField = value;
				this.RaisePropertyChanged("Organization_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Tax_ID
		{
			get
			{
				return this.tax_IDField;
			}
			set
			{
				this.tax_IDField = value;
				this.RaisePropertyChanged("Tax_ID");
			}
		}

		[XmlElement(Order = 3)]
		public string TCC_ID
		{
			get
			{
				return this.tCC_IDField;
			}
			set
			{
				this.tCC_IDField = value;
				this.RaisePropertyChanged("TCC_ID");
			}
		}

		[XmlElement(Order = 4)]
		public bool Foreign_Entity_Indicator
		{
			get
			{
				return this.foreign_Entity_IndicatorField;
			}
			set
			{
				this.foreign_Entity_IndicatorField = value;
				this.RaisePropertyChanged("Foreign_Entity_Indicator");
			}
		}

		[XmlIgnore]
		public bool Foreign_Entity_IndicatorSpecified
		{
			get
			{
				return this.foreign_Entity_IndicatorFieldSpecified;
			}
			set
			{
				this.foreign_Entity_IndicatorFieldSpecified = value;
				this.RaisePropertyChanged("Foreign_Entity_IndicatorSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public string Primary_Fully_Composed_Address_without_Country
		{
			get
			{
				return this.primary_Fully_Composed_Address_without_CountryField;
			}
			set
			{
				this.primary_Fully_Composed_Address_without_CountryField = value;
				this.RaisePropertyChanged("Primary_Fully_Composed_Address_without_Country");
			}
		}

		[XmlElement("Address_Data", Order = 6)]
		public Address_Information_DataType[] Address_Data
		{
			get
			{
				return this.address_DataField;
			}
			set
			{
				this.address_DataField = value;
				this.RaisePropertyChanged("Address_Data");
			}
		}

		[XmlElement(Order = 7)]
		public string Phone_Number
		{
			get
			{
				return this.phone_NumberField;
			}
			set
			{
				this.phone_NumberField = value;
				this.RaisePropertyChanged("Phone_Number");
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
