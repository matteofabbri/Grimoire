using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Quarterly_Worker_Tax_Filing_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private Kind_of_Employer_for_Payroll_Tax_FilingObjectType kind_of_Employer_ReferenceField;

		private bool third_Party_Provides_Sick_Pay_W2Field;

		private bool third_Party_Provides_Sick_Pay_W2FieldSpecified;

		private bool california_SDI_Enabled_for_CompanyField;

		private bool california_SDI_Enabled_for_CompanyFieldSpecified;

		private bool california_VDI_Enabled_for_CompanyField;

		private bool california_VDI_Enabled_for_CompanyFieldSpecified;

		private Calendar_QuarterObjectType calendar_Quarter_ReferenceField;

		private string quarter_NameField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private decimal quarter_NumberField;

		private bool quarter_NumberFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private decimal weeks_WorkedField;

		private bool weeks_WorkedFieldSpecified;

		private decimal hours_WorkedField;

		private bool hours_WorkedFieldSpecified;

		private bool seasonal_WorkerField;

		private bool seasonal_WorkerFieldSpecified;

		private bool medical_CoverageField;

		private bool medical_CoverageFieldSpecified;

		private bool outside_CoverageField;

		private bool outside_CoverageFieldSpecified;

		private bool corporate_OfficerField;

		private bool corporate_OfficerFieldSpecified;

		private Workers_Compensation_CodeObjectType wC_Code_ReferenceField;

		private decimal wC_RateField;

		private bool wC_RateFieldSpecified;

		private bool wC_ExemptField;

		private bool wC_ExemptFieldSpecified;

		private Payroll_Reporting_Code__All_ObjectType eE_Class_Code_Indicator_ReferenceField;

		private Payroll_Reporting_Code__All_ObjectType corporate_Officer_Type_ReferenceField;

		private string coverage_Type__Unemployment_Workers_Comp_Both_Field;

		private Worker_Payroll_Reporting_Code_DataType[] payroll_Reporting_Code_DataField;

		private Payroll_Tax_Authority_DataType[] payroll_Tax_Authority_DataField;

		private Document_Field_Result_DataType[] document_Field_Result_DataField;

		private Quarterly_Deduction_Tax_Filing_DataType[] quarterly_Deduction_Tax_DataField;

		private WA_IIF_Deduction_DataType[] wA_IIF_Deduction_DataField;

		private Quarterly_Tax_Filing_Category_DataType[][] quarterly_Tax_Configuration_Data_WrapperField;

		private Worker_Annual_Tax_DataType[] worker_Annual_Tax_Data_WrapperField;

		private Worker_Puerto_Rico_Annual_Tax_DataType[] worker_Puerto_Rico_Annual_Tax_Data_WrapperField;

		private bool company_Provides_Dependent_BenefitsField;

		private bool company_Provides_Dependent_BenefitsFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
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

		[XmlElement(Order = 2)]
		public Kind_of_Employer_for_Payroll_Tax_FilingObjectType Kind_of_Employer_Reference
		{
			get
			{
				return this.kind_of_Employer_ReferenceField;
			}
			set
			{
				this.kind_of_Employer_ReferenceField = value;
				this.RaisePropertyChanged("Kind_of_Employer_Reference");
			}
		}

		[XmlElement("Third_Party_Provides_Sick_Pay_W-2", Order = 3)]
		public bool Third_Party_Provides_Sick_Pay_W2
		{
			get
			{
				return this.third_Party_Provides_Sick_Pay_W2Field;
			}
			set
			{
				this.third_Party_Provides_Sick_Pay_W2Field = value;
				this.RaisePropertyChanged("Third_Party_Provides_Sick_Pay_W2");
			}
		}

		[XmlIgnore]
		public bool Third_Party_Provides_Sick_Pay_W2Specified
		{
			get
			{
				return this.third_Party_Provides_Sick_Pay_W2FieldSpecified;
			}
			set
			{
				this.third_Party_Provides_Sick_Pay_W2FieldSpecified = value;
				this.RaisePropertyChanged("Third_Party_Provides_Sick_Pay_W2Specified");
			}
		}

		[XmlElement(Order = 4)]
		public bool California_SDI_Enabled_for_Company
		{
			get
			{
				return this.california_SDI_Enabled_for_CompanyField;
			}
			set
			{
				this.california_SDI_Enabled_for_CompanyField = value;
				this.RaisePropertyChanged("California_SDI_Enabled_for_Company");
			}
		}

		[XmlIgnore]
		public bool California_SDI_Enabled_for_CompanySpecified
		{
			get
			{
				return this.california_SDI_Enabled_for_CompanyFieldSpecified;
			}
			set
			{
				this.california_SDI_Enabled_for_CompanyFieldSpecified = value;
				this.RaisePropertyChanged("California_SDI_Enabled_for_CompanySpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool California_VDI_Enabled_for_Company
		{
			get
			{
				return this.california_VDI_Enabled_for_CompanyField;
			}
			set
			{
				this.california_VDI_Enabled_for_CompanyField = value;
				this.RaisePropertyChanged("California_VDI_Enabled_for_Company");
			}
		}

		[XmlIgnore]
		public bool California_VDI_Enabled_for_CompanySpecified
		{
			get
			{
				return this.california_VDI_Enabled_for_CompanyFieldSpecified;
			}
			set
			{
				this.california_VDI_Enabled_for_CompanyFieldSpecified = value;
				this.RaisePropertyChanged("California_VDI_Enabled_for_CompanySpecified");
			}
		}

		[XmlElement(Order = 6)]
		public Calendar_QuarterObjectType Calendar_Quarter_Reference
		{
			get
			{
				return this.calendar_Quarter_ReferenceField;
			}
			set
			{
				this.calendar_Quarter_ReferenceField = value;
				this.RaisePropertyChanged("Calendar_Quarter_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public string Quarter_Name
		{
			get
			{
				return this.quarter_NameField;
			}
			set
			{
				this.quarter_NameField = value;
				this.RaisePropertyChanged("Quarter_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
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

		[XmlElement(DataType = "date", Order = 9)]
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

		[XmlElement(Order = 10)]
		public decimal Quarter_Number
		{
			get
			{
				return this.quarter_NumberField;
			}
			set
			{
				this.quarter_NumberField = value;
				this.RaisePropertyChanged("Quarter_Number");
			}
		}

		[XmlIgnore]
		public bool Quarter_NumberSpecified
		{
			get
			{
				return this.quarter_NumberFieldSpecified;
			}
			set
			{
				this.quarter_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Quarter_NumberSpecified");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
		public decimal Weeks_Worked
		{
			get
			{
				return this.weeks_WorkedField;
			}
			set
			{
				this.weeks_WorkedField = value;
				this.RaisePropertyChanged("Weeks_Worked");
			}
		}

		[XmlIgnore]
		public bool Weeks_WorkedSpecified
		{
			get
			{
				return this.weeks_WorkedFieldSpecified;
			}
			set
			{
				this.weeks_WorkedFieldSpecified = value;
				this.RaisePropertyChanged("Weeks_WorkedSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public decimal Hours_Worked
		{
			get
			{
				return this.hours_WorkedField;
			}
			set
			{
				this.hours_WorkedField = value;
				this.RaisePropertyChanged("Hours_Worked");
			}
		}

		[XmlIgnore]
		public bool Hours_WorkedSpecified
		{
			get
			{
				return this.hours_WorkedFieldSpecified;
			}
			set
			{
				this.hours_WorkedFieldSpecified = value;
				this.RaisePropertyChanged("Hours_WorkedSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public bool Seasonal_Worker
		{
			get
			{
				return this.seasonal_WorkerField;
			}
			set
			{
				this.seasonal_WorkerField = value;
				this.RaisePropertyChanged("Seasonal_Worker");
			}
		}

		[XmlIgnore]
		public bool Seasonal_WorkerSpecified
		{
			get
			{
				return this.seasonal_WorkerFieldSpecified;
			}
			set
			{
				this.seasonal_WorkerFieldSpecified = value;
				this.RaisePropertyChanged("Seasonal_WorkerSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public bool Medical_Coverage
		{
			get
			{
				return this.medical_CoverageField;
			}
			set
			{
				this.medical_CoverageField = value;
				this.RaisePropertyChanged("Medical_Coverage");
			}
		}

		[XmlIgnore]
		public bool Medical_CoverageSpecified
		{
			get
			{
				return this.medical_CoverageFieldSpecified;
			}
			set
			{
				this.medical_CoverageFieldSpecified = value;
				this.RaisePropertyChanged("Medical_CoverageSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public bool Outside_Coverage
		{
			get
			{
				return this.outside_CoverageField;
			}
			set
			{
				this.outside_CoverageField = value;
				this.RaisePropertyChanged("Outside_Coverage");
			}
		}

		[XmlIgnore]
		public bool Outside_CoverageSpecified
		{
			get
			{
				return this.outside_CoverageFieldSpecified;
			}
			set
			{
				this.outside_CoverageFieldSpecified = value;
				this.RaisePropertyChanged("Outside_CoverageSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public bool Corporate_Officer
		{
			get
			{
				return this.corporate_OfficerField;
			}
			set
			{
				this.corporate_OfficerField = value;
				this.RaisePropertyChanged("Corporate_Officer");
			}
		}

		[XmlIgnore]
		public bool Corporate_OfficerSpecified
		{
			get
			{
				return this.corporate_OfficerFieldSpecified;
			}
			set
			{
				this.corporate_OfficerFieldSpecified = value;
				this.RaisePropertyChanged("Corporate_OfficerSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public Workers_Compensation_CodeObjectType WC_Code_Reference
		{
			get
			{
				return this.wC_Code_ReferenceField;
			}
			set
			{
				this.wC_Code_ReferenceField = value;
				this.RaisePropertyChanged("WC_Code_Reference");
			}
		}

		[XmlElement(Order = 19)]
		public decimal WC_Rate
		{
			get
			{
				return this.wC_RateField;
			}
			set
			{
				this.wC_RateField = value;
				this.RaisePropertyChanged("WC_Rate");
			}
		}

		[XmlIgnore]
		public bool WC_RateSpecified
		{
			get
			{
				return this.wC_RateFieldSpecified;
			}
			set
			{
				this.wC_RateFieldSpecified = value;
				this.RaisePropertyChanged("WC_RateSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public bool WC_Exempt
		{
			get
			{
				return this.wC_ExemptField;
			}
			set
			{
				this.wC_ExemptField = value;
				this.RaisePropertyChanged("WC_Exempt");
			}
		}

		[XmlIgnore]
		public bool WC_ExemptSpecified
		{
			get
			{
				return this.wC_ExemptFieldSpecified;
			}
			set
			{
				this.wC_ExemptFieldSpecified = value;
				this.RaisePropertyChanged("WC_ExemptSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public Payroll_Reporting_Code__All_ObjectType EE_Class_Code_Indicator_Reference
		{
			get
			{
				return this.eE_Class_Code_Indicator_ReferenceField;
			}
			set
			{
				this.eE_Class_Code_Indicator_ReferenceField = value;
				this.RaisePropertyChanged("EE_Class_Code_Indicator_Reference");
			}
		}

		[XmlElement(Order = 22)]
		public Payroll_Reporting_Code__All_ObjectType Corporate_Officer_Type_Reference
		{
			get
			{
				return this.corporate_Officer_Type_ReferenceField;
			}
			set
			{
				this.corporate_Officer_Type_ReferenceField = value;
				this.RaisePropertyChanged("Corporate_Officer_Type_Reference");
			}
		}

		[XmlElement(Order = 23)]
		public string Coverage_Type__Unemployment_Workers_Comp_Both_
		{
			get
			{
				return this.coverage_Type__Unemployment_Workers_Comp_Both_Field;
			}
			set
			{
				this.coverage_Type__Unemployment_Workers_Comp_Both_Field = value;
				this.RaisePropertyChanged("Coverage_Type__Unemployment_Workers_Comp_Both_");
			}
		}

		[XmlElement("Payroll_Reporting_Code_Data", Order = 24)]
		public Worker_Payroll_Reporting_Code_DataType[] Payroll_Reporting_Code_Data
		{
			get
			{
				return this.payroll_Reporting_Code_DataField;
			}
			set
			{
				this.payroll_Reporting_Code_DataField = value;
				this.RaisePropertyChanged("Payroll_Reporting_Code_Data");
			}
		}

		[XmlElement("Payroll_Tax_Authority_Data", Order = 25)]
		public Payroll_Tax_Authority_DataType[] Payroll_Tax_Authority_Data
		{
			get
			{
				return this.payroll_Tax_Authority_DataField;
			}
			set
			{
				this.payroll_Tax_Authority_DataField = value;
				this.RaisePropertyChanged("Payroll_Tax_Authority_Data");
			}
		}

		[XmlElement("Document_Field_Result_Data", Order = 26)]
		public Document_Field_Result_DataType[] Document_Field_Result_Data
		{
			get
			{
				return this.document_Field_Result_DataField;
			}
			set
			{
				this.document_Field_Result_DataField = value;
				this.RaisePropertyChanged("Document_Field_Result_Data");
			}
		}

		[XmlElement("Quarterly_Deduction_Tax_Data", Order = 27)]
		public Quarterly_Deduction_Tax_Filing_DataType[] Quarterly_Deduction_Tax_Data
		{
			get
			{
				return this.quarterly_Deduction_Tax_DataField;
			}
			set
			{
				this.quarterly_Deduction_Tax_DataField = value;
				this.RaisePropertyChanged("Quarterly_Deduction_Tax_Data");
			}
		}

		[XmlElement("WA_IIF_Deduction_Data", Order = 28)]
		public WA_IIF_Deduction_DataType[] WA_IIF_Deduction_Data
		{
			get
			{
				return this.wA_IIF_Deduction_DataField;
			}
			set
			{
				this.wA_IIF_Deduction_DataField = value;
				this.RaisePropertyChanged("WA_IIF_Deduction_Data");
			}
		}

		[XmlArray(Order = 29), XmlArrayItem("Quarterly_Tax_Configuration_Data", typeof(Quarterly_Tax_Filing_Category_DataType[]), IsNullable = false), XmlArrayItem("Quarterly_Tax_Category_Data", typeof(Quarterly_Tax_Filing_Category_DataType), IsNullable = false, NestingLevel = 1)]
		public Quarterly_Tax_Filing_Category_DataType[][] Quarterly_Tax_Configuration_Data_Wrapper
		{
			get
			{
				return this.quarterly_Tax_Configuration_Data_WrapperField;
			}
			set
			{
				this.quarterly_Tax_Configuration_Data_WrapperField = value;
				this.RaisePropertyChanged("Quarterly_Tax_Configuration_Data_Wrapper");
			}
		}

		[XmlArray(Order = 30), XmlArrayItem("Worker_Annual_Tax_Data", typeof(Worker_Annual_Tax_DataType), IsNullable = false)]
		public Worker_Annual_Tax_DataType[] Worker_Annual_Tax_Data_Wrapper
		{
			get
			{
				return this.worker_Annual_Tax_Data_WrapperField;
			}
			set
			{
				this.worker_Annual_Tax_Data_WrapperField = value;
				this.RaisePropertyChanged("Worker_Annual_Tax_Data_Wrapper");
			}
		}

		[XmlArray(Order = 31), XmlArrayItem("Worker_Puerto_Rico_Annual_Tax_Data", typeof(Worker_Puerto_Rico_Annual_Tax_DataType), IsNullable = false)]
		public Worker_Puerto_Rico_Annual_Tax_DataType[] Worker_Puerto_Rico_Annual_Tax_Data_Wrapper
		{
			get
			{
				return this.worker_Puerto_Rico_Annual_Tax_Data_WrapperField;
			}
			set
			{
				this.worker_Puerto_Rico_Annual_Tax_Data_WrapperField = value;
				this.RaisePropertyChanged("Worker_Puerto_Rico_Annual_Tax_Data_Wrapper");
			}
		}

		[XmlElement(Order = 32)]
		public bool Company_Provides_Dependent_Benefits
		{
			get
			{
				return this.company_Provides_Dependent_BenefitsField;
			}
			set
			{
				this.company_Provides_Dependent_BenefitsField = value;
				this.RaisePropertyChanged("Company_Provides_Dependent_Benefits");
			}
		}

		[XmlIgnore]
		public bool Company_Provides_Dependent_BenefitsSpecified
		{
			get
			{
				return this.company_Provides_Dependent_BenefitsFieldSpecified;
			}
			set
			{
				this.company_Provides_Dependent_BenefitsFieldSpecified = value;
				this.RaisePropertyChanged("Company_Provides_Dependent_BenefitsSpecified");
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
