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
	public class Funding_Source_DataType : INotifyPropertyChanged
	{
		private string funding_Source_NameField;

		private CompanyObjectType company_ReferenceField;

		private OrganizationObjectType[] additional_Company_or_Company_Hierarchy_ReferenceField;

		private string funding_Source_DescriptionField;

		private DateTime funding_Source_Begin_DateField;

		private DateTime funding_Source_End_DateField;

		private bool funding_Source_End_DateFieldSpecified;

		private bool on_HoldField;

		private bool on_HoldFieldSpecified;

		private decimal funding_Source_Funding_AmountField;

		private decimal funding_Source_Estimate_Facilities_and_Administration_RateField;

		private bool funding_Source_Estimate_Facilities_and_Administration_RateFieldSpecified;

		private Spend_RestrictionObjectType[] spend_Restriction_ReferenceField;

		private decimal funding_Source_Cost_Share_PercentageField;

		private bool funding_Source_Cost_Share_PercentageFieldSpecified;

		private decimal maximum_ContributionField;

		private bool maximum_ContributionFieldSpecified;

		private Funding_Source_Taggable_DataType[] funding_Source_Taggable_DataField;

		private decimal funding_Amount_for_Direct_CostsField;

		private bool funding_Amount_for_Direct_CostsFieldSpecified;

		private decimal allocated_to_Direct_CostsField;

		private bool allocated_to_Direct_CostsFieldSpecified;

		private decimal available_Balance_for_Direct_CostsField;

		private bool available_Balance_for_Direct_CostsFieldSpecified;

		private decimal allocated_to_Indirect_CostsField;

		private bool allocated_to_Indirect_CostsFieldSpecified;

		private decimal actual_Facilities_and_Administration_RateField;

		private bool actual_Facilities_and_Administration_RateFieldSpecified;

		private decimal total_Allocated_AmountField;

		private bool total_Allocated_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Funding_Source_Name
		{
			get
			{
				return this.funding_Source_NameField;
			}
			set
			{
				this.funding_Source_NameField = value;
				this.RaisePropertyChanged("Funding_Source_Name");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement("Additional_Company_or_Company_Hierarchy_Reference", Order = 2)]
		public OrganizationObjectType[] Additional_Company_or_Company_Hierarchy_Reference
		{
			get
			{
				return this.additional_Company_or_Company_Hierarchy_ReferenceField;
			}
			set
			{
				this.additional_Company_or_Company_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Additional_Company_or_Company_Hierarchy_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Funding_Source_Description
		{
			get
			{
				return this.funding_Source_DescriptionField;
			}
			set
			{
				this.funding_Source_DescriptionField = value;
				this.RaisePropertyChanged("Funding_Source_Description");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Funding_Source_Begin_Date
		{
			get
			{
				return this.funding_Source_Begin_DateField;
			}
			set
			{
				this.funding_Source_Begin_DateField = value;
				this.RaisePropertyChanged("Funding_Source_Begin_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Funding_Source_End_Date
		{
			get
			{
				return this.funding_Source_End_DateField;
			}
			set
			{
				this.funding_Source_End_DateField = value;
				this.RaisePropertyChanged("Funding_Source_End_Date");
			}
		}

		[XmlIgnore]
		public bool Funding_Source_End_DateSpecified
		{
			get
			{
				return this.funding_Source_End_DateFieldSpecified;
			}
			set
			{
				this.funding_Source_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Funding_Source_End_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool On_Hold
		{
			get
			{
				return this.on_HoldField;
			}
			set
			{
				this.on_HoldField = value;
				this.RaisePropertyChanged("On_Hold");
			}
		}

		[XmlIgnore]
		public bool On_HoldSpecified
		{
			get
			{
				return this.on_HoldFieldSpecified;
			}
			set
			{
				this.on_HoldFieldSpecified = value;
				this.RaisePropertyChanged("On_HoldSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Funding_Source_Funding_Amount
		{
			get
			{
				return this.funding_Source_Funding_AmountField;
			}
			set
			{
				this.funding_Source_Funding_AmountField = value;
				this.RaisePropertyChanged("Funding_Source_Funding_Amount");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Funding_Source_Estimate_Facilities_and_Administration_Rate
		{
			get
			{
				return this.funding_Source_Estimate_Facilities_and_Administration_RateField;
			}
			set
			{
				this.funding_Source_Estimate_Facilities_and_Administration_RateField = value;
				this.RaisePropertyChanged("Funding_Source_Estimate_Facilities_and_Administration_Rate");
			}
		}

		[XmlIgnore]
		public bool Funding_Source_Estimate_Facilities_and_Administration_RateSpecified
		{
			get
			{
				return this.funding_Source_Estimate_Facilities_and_Administration_RateFieldSpecified;
			}
			set
			{
				this.funding_Source_Estimate_Facilities_and_Administration_RateFieldSpecified = value;
				this.RaisePropertyChanged("Funding_Source_Estimate_Facilities_and_Administration_RateSpecified");
			}
		}

		[XmlElement("Spend_Restriction_Reference", Order = 9)]
		public Spend_RestrictionObjectType[] Spend_Restriction_Reference
		{
			get
			{
				return this.spend_Restriction_ReferenceField;
			}
			set
			{
				this.spend_Restriction_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Restriction_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Funding_Source_Cost_Share_Percentage
		{
			get
			{
				return this.funding_Source_Cost_Share_PercentageField;
			}
			set
			{
				this.funding_Source_Cost_Share_PercentageField = value;
				this.RaisePropertyChanged("Funding_Source_Cost_Share_Percentage");
			}
		}

		[XmlIgnore]
		public bool Funding_Source_Cost_Share_PercentageSpecified
		{
			get
			{
				return this.funding_Source_Cost_Share_PercentageFieldSpecified;
			}
			set
			{
				this.funding_Source_Cost_Share_PercentageFieldSpecified = value;
				this.RaisePropertyChanged("Funding_Source_Cost_Share_PercentageSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Maximum_Contribution
		{
			get
			{
				return this.maximum_ContributionField;
			}
			set
			{
				this.maximum_ContributionField = value;
				this.RaisePropertyChanged("Maximum_Contribution");
			}
		}

		[XmlIgnore]
		public bool Maximum_ContributionSpecified
		{
			get
			{
				return this.maximum_ContributionFieldSpecified;
			}
			set
			{
				this.maximum_ContributionFieldSpecified = value;
				this.RaisePropertyChanged("Maximum_ContributionSpecified");
			}
		}

		[XmlElement("Funding_Source_Taggable_Data", Order = 12)]
		public Funding_Source_Taggable_DataType[] Funding_Source_Taggable_Data
		{
			get
			{
				return this.funding_Source_Taggable_DataField;
			}
			set
			{
				this.funding_Source_Taggable_DataField = value;
				this.RaisePropertyChanged("Funding_Source_Taggable_Data");
			}
		}

		[XmlElement(Order = 13)]
		public decimal Funding_Amount_for_Direct_Costs
		{
			get
			{
				return this.funding_Amount_for_Direct_CostsField;
			}
			set
			{
				this.funding_Amount_for_Direct_CostsField = value;
				this.RaisePropertyChanged("Funding_Amount_for_Direct_Costs");
			}
		}

		[XmlIgnore]
		public bool Funding_Amount_for_Direct_CostsSpecified
		{
			get
			{
				return this.funding_Amount_for_Direct_CostsFieldSpecified;
			}
			set
			{
				this.funding_Amount_for_Direct_CostsFieldSpecified = value;
				this.RaisePropertyChanged("Funding_Amount_for_Direct_CostsSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Allocated_to_Direct_Costs
		{
			get
			{
				return this.allocated_to_Direct_CostsField;
			}
			set
			{
				this.allocated_to_Direct_CostsField = value;
				this.RaisePropertyChanged("Allocated_to_Direct_Costs");
			}
		}

		[XmlIgnore]
		public bool Allocated_to_Direct_CostsSpecified
		{
			get
			{
				return this.allocated_to_Direct_CostsFieldSpecified;
			}
			set
			{
				this.allocated_to_Direct_CostsFieldSpecified = value;
				this.RaisePropertyChanged("Allocated_to_Direct_CostsSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public decimal Available_Balance_for_Direct_Costs
		{
			get
			{
				return this.available_Balance_for_Direct_CostsField;
			}
			set
			{
				this.available_Balance_for_Direct_CostsField = value;
				this.RaisePropertyChanged("Available_Balance_for_Direct_Costs");
			}
		}

		[XmlIgnore]
		public bool Available_Balance_for_Direct_CostsSpecified
		{
			get
			{
				return this.available_Balance_for_Direct_CostsFieldSpecified;
			}
			set
			{
				this.available_Balance_for_Direct_CostsFieldSpecified = value;
				this.RaisePropertyChanged("Available_Balance_for_Direct_CostsSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public decimal Allocated_to_Indirect_Costs
		{
			get
			{
				return this.allocated_to_Indirect_CostsField;
			}
			set
			{
				this.allocated_to_Indirect_CostsField = value;
				this.RaisePropertyChanged("Allocated_to_Indirect_Costs");
			}
		}

		[XmlIgnore]
		public bool Allocated_to_Indirect_CostsSpecified
		{
			get
			{
				return this.allocated_to_Indirect_CostsFieldSpecified;
			}
			set
			{
				this.allocated_to_Indirect_CostsFieldSpecified = value;
				this.RaisePropertyChanged("Allocated_to_Indirect_CostsSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public decimal Actual_Facilities_and_Administration_Rate
		{
			get
			{
				return this.actual_Facilities_and_Administration_RateField;
			}
			set
			{
				this.actual_Facilities_and_Administration_RateField = value;
				this.RaisePropertyChanged("Actual_Facilities_and_Administration_Rate");
			}
		}

		[XmlIgnore]
		public bool Actual_Facilities_and_Administration_RateSpecified
		{
			get
			{
				return this.actual_Facilities_and_Administration_RateFieldSpecified;
			}
			set
			{
				this.actual_Facilities_and_Administration_RateFieldSpecified = value;
				this.RaisePropertyChanged("Actual_Facilities_and_Administration_RateSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public decimal Total_Allocated_Amount
		{
			get
			{
				return this.total_Allocated_AmountField;
			}
			set
			{
				this.total_Allocated_AmountField = value;
				this.RaisePropertyChanged("Total_Allocated_Amount");
			}
		}

		[XmlIgnore]
		public bool Total_Allocated_AmountSpecified
		{
			get
			{
				return this.total_Allocated_AmountFieldSpecified;
			}
			set
			{
				this.total_Allocated_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Total_Allocated_AmountSpecified");
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
