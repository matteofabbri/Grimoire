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
	public class Withholding_Tax_Rate_DataType : INotifyPropertyChanged
	{
		private string tax_Rate_IDField;

		private string tax_Rate_NameField;

		private CountryObjectType country_ReferenceField;

		private decimal tax_RateField;

		private bool tax_RateFieldSpecified;

		private Tax_AuthorityObjectType tax_Authority_ReferenceField;

		private Tax_CategoryObjectType tax_Category_ReferenceField;

		private Realization_PointObjectType realization_Point_ReferenceField;

		private Tax_Base__TypeObjectType tax_Base_Type_ReferenceField;

		private decimal tax_Base_PercentageField;

		private bool tax_Base_PercentageFieldSpecified;

		private Threshold_TypeObjectType threshold_Type_ReferenceField;

		private Withholding_Tax_Rate_Threshold_Rule_DataType withholding_Tax_Rate_Threshold_Rule_DataField;

		private Withholding_Tax_Progressive_Rate_Tier_Rule_DataType[] withholding_Tax_Progressive_Rate_Tier_Rule_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Tax_Rate_ID
		{
			get
			{
				return this.tax_Rate_IDField;
			}
			set
			{
				this.tax_Rate_IDField = value;
				this.RaisePropertyChanged("Tax_Rate_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Tax_Rate_Name
		{
			get
			{
				return this.tax_Rate_NameField;
			}
			set
			{
				this.tax_Rate_NameField = value;
				this.RaisePropertyChanged("Tax_Rate_Name");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public decimal Tax_Rate
		{
			get
			{
				return this.tax_RateField;
			}
			set
			{
				this.tax_RateField = value;
				this.RaisePropertyChanged("Tax_Rate");
			}
		}

		[XmlIgnore]
		public bool Tax_RateSpecified
		{
			get
			{
				return this.tax_RateFieldSpecified;
			}
			set
			{
				this.tax_RateFieldSpecified = value;
				this.RaisePropertyChanged("Tax_RateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Tax_AuthorityObjectType Tax_Authority_Reference
		{
			get
			{
				return this.tax_Authority_ReferenceField;
			}
			set
			{
				this.tax_Authority_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Authority_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Tax_CategoryObjectType Tax_Category_Reference
		{
			get
			{
				return this.tax_Category_ReferenceField;
			}
			set
			{
				this.tax_Category_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Category_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Realization_PointObjectType Realization_Point_Reference
		{
			get
			{
				return this.realization_Point_ReferenceField;
			}
			set
			{
				this.realization_Point_ReferenceField = value;
				this.RaisePropertyChanged("Realization_Point_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Tax_Base__TypeObjectType Tax_Base_Type_Reference
		{
			get
			{
				return this.tax_Base_Type_ReferenceField;
			}
			set
			{
				this.tax_Base_Type_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Base_Type_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Tax_Base_Percentage
		{
			get
			{
				return this.tax_Base_PercentageField;
			}
			set
			{
				this.tax_Base_PercentageField = value;
				this.RaisePropertyChanged("Tax_Base_Percentage");
			}
		}

		[XmlIgnore]
		public bool Tax_Base_PercentageSpecified
		{
			get
			{
				return this.tax_Base_PercentageFieldSpecified;
			}
			set
			{
				this.tax_Base_PercentageFieldSpecified = value;
				this.RaisePropertyChanged("Tax_Base_PercentageSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public Threshold_TypeObjectType Threshold_Type_Reference
		{
			get
			{
				return this.threshold_Type_ReferenceField;
			}
			set
			{
				this.threshold_Type_ReferenceField = value;
				this.RaisePropertyChanged("Threshold_Type_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public Withholding_Tax_Rate_Threshold_Rule_DataType Withholding_Tax_Rate_Threshold_Rule_Data
		{
			get
			{
				return this.withholding_Tax_Rate_Threshold_Rule_DataField;
			}
			set
			{
				this.withholding_Tax_Rate_Threshold_Rule_DataField = value;
				this.RaisePropertyChanged("Withholding_Tax_Rate_Threshold_Rule_Data");
			}
		}

		[XmlElement("Withholding_Tax_Progressive_Rate_Tier_Rule_Data", Order = 11)]
		public Withholding_Tax_Progressive_Rate_Tier_Rule_DataType[] Withholding_Tax_Progressive_Rate_Tier_Rule_Data
		{
			get
			{
				return this.withholding_Tax_Progressive_Rate_Tier_Rule_DataField;
			}
			set
			{
				this.withholding_Tax_Progressive_Rate_Tier_Rule_DataField = value;
				this.RaisePropertyChanged("Withholding_Tax_Progressive_Rate_Tier_Rule_Data");
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
