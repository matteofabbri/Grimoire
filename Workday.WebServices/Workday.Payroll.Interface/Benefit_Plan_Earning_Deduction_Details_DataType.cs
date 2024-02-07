using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Benefit_Plan_Earning_Deduction_Details_DataType : INotifyPropertyChanged
	{
		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private DateTime original_Coverage_Begin_DateField;

		private bool original_Coverage_Begin_DateFieldSpecified;

		private decimal eE_Cost_Pre_TaxField;

		private bool eE_Cost_Pre_TaxFieldSpecified;

		private decimal eE_Cost_Post_TaxField;

		private bool eE_Cost_Post_TaxFieldSpecified;

		private decimal eE_Cost_PercentField;

		private bool eE_Cost_PercentFieldSpecified;

		private decimal eR_Cost_Non_TaxableField;

		private bool eR_Cost_Non_TaxableFieldSpecified;

		private decimal eR_Cost_TaxableField;

		private bool eR_Cost_TaxableFieldSpecified;

		private decimal eR_Cost_PercentField;

		private bool eR_Cost_PercentFieldSpecified;

		private decimal dependent_Fair_Market_ValueField;

		private bool dependent_Fair_Market_ValueFieldSpecified;

		private Benefit_Election_Covered_Person_DataType[] covered_Persons_Birth_Dates_DataField;

		private decimal coverage_AmountField;

		private bool coverage_AmountFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Benefit_Plan_Earning_Deduction_Currency_Conversion_Details_DataType currency_Conversion_Details_DataField;

		private Health_Savings_Account_Election_Info_DataType[] health_Savings_Acount_Election_Info_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlIgnore]
		public bool Start_DateSpecified
		{
			get
			{
				return this.start_DateFieldSpecified;
			}
			set
			{
				this.start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Original_Coverage_Begin_Date
		{
			get
			{
				return this.original_Coverage_Begin_DateField;
			}
			set
			{
				this.original_Coverage_Begin_DateField = value;
				this.RaisePropertyChanged("Original_Coverage_Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Original_Coverage_Begin_DateSpecified
		{
			get
			{
				return this.original_Coverage_Begin_DateFieldSpecified;
			}
			set
			{
				this.original_Coverage_Begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Original_Coverage_Begin_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal EE_Cost_Pre_Tax
		{
			get
			{
				return this.eE_Cost_Pre_TaxField;
			}
			set
			{
				this.eE_Cost_Pre_TaxField = value;
				this.RaisePropertyChanged("EE_Cost_Pre_Tax");
			}
		}

		[XmlIgnore]
		public bool EE_Cost_Pre_TaxSpecified
		{
			get
			{
				return this.eE_Cost_Pre_TaxFieldSpecified;
			}
			set
			{
				this.eE_Cost_Pre_TaxFieldSpecified = value;
				this.RaisePropertyChanged("EE_Cost_Pre_TaxSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal EE_Cost_Post_Tax
		{
			get
			{
				return this.eE_Cost_Post_TaxField;
			}
			set
			{
				this.eE_Cost_Post_TaxField = value;
				this.RaisePropertyChanged("EE_Cost_Post_Tax");
			}
		}

		[XmlIgnore]
		public bool EE_Cost_Post_TaxSpecified
		{
			get
			{
				return this.eE_Cost_Post_TaxFieldSpecified;
			}
			set
			{
				this.eE_Cost_Post_TaxFieldSpecified = value;
				this.RaisePropertyChanged("EE_Cost_Post_TaxSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal EE_Cost_Percent
		{
			get
			{
				return this.eE_Cost_PercentField;
			}
			set
			{
				this.eE_Cost_PercentField = value;
				this.RaisePropertyChanged("EE_Cost_Percent");
			}
		}

		[XmlIgnore]
		public bool EE_Cost_PercentSpecified
		{
			get
			{
				return this.eE_Cost_PercentFieldSpecified;
			}
			set
			{
				this.eE_Cost_PercentFieldSpecified = value;
				this.RaisePropertyChanged("EE_Cost_PercentSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal ER_Cost_Non_Taxable
		{
			get
			{
				return this.eR_Cost_Non_TaxableField;
			}
			set
			{
				this.eR_Cost_Non_TaxableField = value;
				this.RaisePropertyChanged("ER_Cost_Non_Taxable");
			}
		}

		[XmlIgnore]
		public bool ER_Cost_Non_TaxableSpecified
		{
			get
			{
				return this.eR_Cost_Non_TaxableFieldSpecified;
			}
			set
			{
				this.eR_Cost_Non_TaxableFieldSpecified = value;
				this.RaisePropertyChanged("ER_Cost_Non_TaxableSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal ER_Cost_Taxable
		{
			get
			{
				return this.eR_Cost_TaxableField;
			}
			set
			{
				this.eR_Cost_TaxableField = value;
				this.RaisePropertyChanged("ER_Cost_Taxable");
			}
		}

		[XmlIgnore]
		public bool ER_Cost_TaxableSpecified
		{
			get
			{
				return this.eR_Cost_TaxableFieldSpecified;
			}
			set
			{
				this.eR_Cost_TaxableFieldSpecified = value;
				this.RaisePropertyChanged("ER_Cost_TaxableSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal ER_Cost_Percent
		{
			get
			{
				return this.eR_Cost_PercentField;
			}
			set
			{
				this.eR_Cost_PercentField = value;
				this.RaisePropertyChanged("ER_Cost_Percent");
			}
		}

		[XmlIgnore]
		public bool ER_Cost_PercentSpecified
		{
			get
			{
				return this.eR_Cost_PercentFieldSpecified;
			}
			set
			{
				this.eR_Cost_PercentFieldSpecified = value;
				this.RaisePropertyChanged("ER_Cost_PercentSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Dependent_Fair_Market_Value
		{
			get
			{
				return this.dependent_Fair_Market_ValueField;
			}
			set
			{
				this.dependent_Fair_Market_ValueField = value;
				this.RaisePropertyChanged("Dependent_Fair_Market_Value");
			}
		}

		[XmlIgnore]
		public bool Dependent_Fair_Market_ValueSpecified
		{
			get
			{
				return this.dependent_Fair_Market_ValueFieldSpecified;
			}
			set
			{
				this.dependent_Fair_Market_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Dependent_Fair_Market_ValueSpecified");
			}
		}

		[XmlElement("Covered_Persons_Birth_Dates_Data", Order = 10)]
		public Benefit_Election_Covered_Person_DataType[] Covered_Persons_Birth_Dates_Data
		{
			get
			{
				return this.covered_Persons_Birth_Dates_DataField;
			}
			set
			{
				this.covered_Persons_Birth_Dates_DataField = value;
				this.RaisePropertyChanged("Covered_Persons_Birth_Dates_Data");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Coverage_Amount
		{
			get
			{
				return this.coverage_AmountField;
			}
			set
			{
				this.coverage_AmountField = value;
				this.RaisePropertyChanged("Coverage_Amount");
			}
		}

		[XmlIgnore]
		public bool Coverage_AmountSpecified
		{
			get
			{
				return this.coverage_AmountFieldSpecified;
			}
			set
			{
				this.coverage_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Coverage_AmountSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public Benefit_Plan_Earning_Deduction_Currency_Conversion_Details_DataType Currency_Conversion_Details_Data
		{
			get
			{
				return this.currency_Conversion_Details_DataField;
			}
			set
			{
				this.currency_Conversion_Details_DataField = value;
				this.RaisePropertyChanged("Currency_Conversion_Details_Data");
			}
		}

		[XmlElement("Health_Savings_Acount_Election_Info_Data", Order = 14)]
		public Health_Savings_Account_Election_Info_DataType[] Health_Savings_Acount_Election_Info_Data
		{
			get
			{
				return this.health_Savings_Acount_Election_Info_DataField;
			}
			set
			{
				this.health_Savings_Acount_Election_Info_DataField = value;
				this.RaisePropertyChanged("Health_Savings_Acount_Election_Info_Data");
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
