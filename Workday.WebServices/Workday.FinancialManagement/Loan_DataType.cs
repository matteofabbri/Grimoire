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
	public class Loan_DataType : INotifyPropertyChanged
	{
		private string loan_NumberField;

		private CustomerObjectType customer_ReferenceField;

		private DateTime vintage_DateField;

		private bool vintage_DateFieldSpecified;

		private DateTime first_Referral_DateField;

		private bool first_Referral_DateFieldSpecified;

		private string property_IDField;

		private Loan_Referral_TypeObjectType referral_Type_ReferenceField;

		private Loan_Investor_TypeObjectType investor_Type_ReferenceField;

		private CountryObjectType country_ReferenceField;

		private Country_RegionObjectType country_Region_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private string idField;

		private Related_Worktags_by_Worktag_Type_DataType[] related_Worktags_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Loan_Number
		{
			get
			{
				return this.loan_NumberField;
			}
			set
			{
				this.loan_NumberField = value;
				this.RaisePropertyChanged("Loan_Number");
			}
		}

		[XmlElement(Order = 1)]
		public CustomerObjectType Customer_Reference
		{
			get
			{
				return this.customer_ReferenceField;
			}
			set
			{
				this.customer_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Vintage_Date
		{
			get
			{
				return this.vintage_DateField;
			}
			set
			{
				this.vintage_DateField = value;
				this.RaisePropertyChanged("Vintage_Date");
			}
		}

		[XmlIgnore]
		public bool Vintage_DateSpecified
		{
			get
			{
				return this.vintage_DateFieldSpecified;
			}
			set
			{
				this.vintage_DateFieldSpecified = value;
				this.RaisePropertyChanged("Vintage_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime First_Referral_Date
		{
			get
			{
				return this.first_Referral_DateField;
			}
			set
			{
				this.first_Referral_DateField = value;
				this.RaisePropertyChanged("First_Referral_Date");
			}
		}

		[XmlIgnore]
		public bool First_Referral_DateSpecified
		{
			get
			{
				return this.first_Referral_DateFieldSpecified;
			}
			set
			{
				this.first_Referral_DateFieldSpecified = value;
				this.RaisePropertyChanged("First_Referral_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public string Property_ID
		{
			get
			{
				return this.property_IDField;
			}
			set
			{
				this.property_IDField = value;
				this.RaisePropertyChanged("Property_ID");
			}
		}

		[XmlElement(Order = 5)]
		public Loan_Referral_TypeObjectType Referral_Type_Reference
		{
			get
			{
				return this.referral_Type_ReferenceField;
			}
			set
			{
				this.referral_Type_ReferenceField = value;
				this.RaisePropertyChanged("Referral_Type_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Loan_Investor_TypeObjectType Investor_Type_Reference
		{
			get
			{
				return this.investor_Type_ReferenceField;
			}
			set
			{
				this.investor_Type_ReferenceField = value;
				this.RaisePropertyChanged("Investor_Type_Reference");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
		public Country_RegionObjectType Country_Region_Reference
		{
			get
			{
				return this.country_Region_ReferenceField;
			}
			set
			{
				this.country_Region_ReferenceField = value;
				this.RaisePropertyChanged("Country_Region_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlArray(Order = 11), XmlArrayItem("Related_Worktags_by_Type_Data", IsNullable = false)]
		public Related_Worktags_by_Worktag_Type_DataType[] Related_Worktags_Data
		{
			get
			{
				return this.related_Worktags_DataField;
			}
			set
			{
				this.related_Worktags_DataField = value;
				this.RaisePropertyChanged("Related_Worktags_Data");
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
