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
	public class Quarterly_Deduction_Tax_Filing_DataType : INotifyPropertyChanged
	{
		private bool third_Party_Sick_PayField;

		private bool third_Party_Sick_PayFieldSpecified;

		private bool employer_PaidField;

		private bool employer_PaidFieldSpecified;

		private Payroll_CalculationObjectType deduction_ReferenceField;

		private Metadata_Payroll_WorktagObjectType[] payroll_Tax_Authority_ReferenceField;

		private string work_PSD_CodeField;

		private string resident_PSD_CodeField;

		private string tax_Filing_CodeField;

		private decimal sUI_RateField;

		private bool sUI_RateFieldSpecified;

		private bool active_for_Month_1Field;

		private bool active_for_Month_1FieldSpecified;

		private bool active_for_12th_Day_Month_1Field;

		private bool active_for_12th_Day_Month_1FieldSpecified;

		private bool active_for_Month_2Field;

		private bool active_for_Month_2FieldSpecified;

		private bool active_for_12th_Day_Month_2Field;

		private bool active_for_12th_Day_Month_2FieldSpecified;

		private bool active_for_Month_3Field;

		private bool active_for_Month_3FieldSpecified;

		private bool active_for_12th_Day_Month_3Field;

		private bool active_for_12th_Day_Month_3FieldSpecified;

		private Worker_Tax_ElectionsType[] employee_Tax_Election_DataField;

		private QTD_Tax_Filing_Data_for_Quarterly_WorkerType qTD_DataField;

		private YTD_Tax_Filing_Data_for_Quarterly_WorkerType yTD_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Third_Party_Sick_Pay
		{
			get
			{
				return this.third_Party_Sick_PayField;
			}
			set
			{
				this.third_Party_Sick_PayField = value;
				this.RaisePropertyChanged("Third_Party_Sick_Pay");
			}
		}

		[XmlIgnore]
		public bool Third_Party_Sick_PaySpecified
		{
			get
			{
				return this.third_Party_Sick_PayFieldSpecified;
			}
			set
			{
				this.third_Party_Sick_PayFieldSpecified = value;
				this.RaisePropertyChanged("Third_Party_Sick_PaySpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Employer_Paid
		{
			get
			{
				return this.employer_PaidField;
			}
			set
			{
				this.employer_PaidField = value;
				this.RaisePropertyChanged("Employer_Paid");
			}
		}

		[XmlIgnore]
		public bool Employer_PaidSpecified
		{
			get
			{
				return this.employer_PaidFieldSpecified;
			}
			set
			{
				this.employer_PaidFieldSpecified = value;
				this.RaisePropertyChanged("Employer_PaidSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Payroll_CalculationObjectType Deduction_Reference
		{
			get
			{
				return this.deduction_ReferenceField;
			}
			set
			{
				this.deduction_ReferenceField = value;
				this.RaisePropertyChanged("Deduction_Reference");
			}
		}

		[XmlElement("Payroll_Tax_Authority_Reference", Order = 3)]
		public Metadata_Payroll_WorktagObjectType[] Payroll_Tax_Authority_Reference
		{
			get
			{
				return this.payroll_Tax_Authority_ReferenceField;
			}
			set
			{
				this.payroll_Tax_Authority_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Tax_Authority_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public string Work_PSD_Code
		{
			get
			{
				return this.work_PSD_CodeField;
			}
			set
			{
				this.work_PSD_CodeField = value;
				this.RaisePropertyChanged("Work_PSD_Code");
			}
		}

		[XmlElement(Order = 5)]
		public string Resident_PSD_Code
		{
			get
			{
				return this.resident_PSD_CodeField;
			}
			set
			{
				this.resident_PSD_CodeField = value;
				this.RaisePropertyChanged("Resident_PSD_Code");
			}
		}

		[XmlElement(Order = 6)]
		public string Tax_Filing_Code
		{
			get
			{
				return this.tax_Filing_CodeField;
			}
			set
			{
				this.tax_Filing_CodeField = value;
				this.RaisePropertyChanged("Tax_Filing_Code");
			}
		}

		[XmlElement(Order = 7)]
		public decimal SUI_Rate
		{
			get
			{
				return this.sUI_RateField;
			}
			set
			{
				this.sUI_RateField = value;
				this.RaisePropertyChanged("SUI_Rate");
			}
		}

		[XmlIgnore]
		public bool SUI_RateSpecified
		{
			get
			{
				return this.sUI_RateFieldSpecified;
			}
			set
			{
				this.sUI_RateFieldSpecified = value;
				this.RaisePropertyChanged("SUI_RateSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Active_for_Month_1
		{
			get
			{
				return this.active_for_Month_1Field;
			}
			set
			{
				this.active_for_Month_1Field = value;
				this.RaisePropertyChanged("Active_for_Month_1");
			}
		}

		[XmlIgnore]
		public bool Active_for_Month_1Specified
		{
			get
			{
				return this.active_for_Month_1FieldSpecified;
			}
			set
			{
				this.active_for_Month_1FieldSpecified = value;
				this.RaisePropertyChanged("Active_for_Month_1Specified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Active_for_12th_Day_Month_1
		{
			get
			{
				return this.active_for_12th_Day_Month_1Field;
			}
			set
			{
				this.active_for_12th_Day_Month_1Field = value;
				this.RaisePropertyChanged("Active_for_12th_Day_Month_1");
			}
		}

		[XmlIgnore]
		public bool Active_for_12th_Day_Month_1Specified
		{
			get
			{
				return this.active_for_12th_Day_Month_1FieldSpecified;
			}
			set
			{
				this.active_for_12th_Day_Month_1FieldSpecified = value;
				this.RaisePropertyChanged("Active_for_12th_Day_Month_1Specified");
			}
		}

		[XmlElement(Order = 10)]
		public bool Active_for_Month_2
		{
			get
			{
				return this.active_for_Month_2Field;
			}
			set
			{
				this.active_for_Month_2Field = value;
				this.RaisePropertyChanged("Active_for_Month_2");
			}
		}

		[XmlIgnore]
		public bool Active_for_Month_2Specified
		{
			get
			{
				return this.active_for_Month_2FieldSpecified;
			}
			set
			{
				this.active_for_Month_2FieldSpecified = value;
				this.RaisePropertyChanged("Active_for_Month_2Specified");
			}
		}

		[XmlElement(Order = 11)]
		public bool Active_for_12th_Day_Month_2
		{
			get
			{
				return this.active_for_12th_Day_Month_2Field;
			}
			set
			{
				this.active_for_12th_Day_Month_2Field = value;
				this.RaisePropertyChanged("Active_for_12th_Day_Month_2");
			}
		}

		[XmlIgnore]
		public bool Active_for_12th_Day_Month_2Specified
		{
			get
			{
				return this.active_for_12th_Day_Month_2FieldSpecified;
			}
			set
			{
				this.active_for_12th_Day_Month_2FieldSpecified = value;
				this.RaisePropertyChanged("Active_for_12th_Day_Month_2Specified");
			}
		}

		[XmlElement(Order = 12)]
		public bool Active_for_Month_3
		{
			get
			{
				return this.active_for_Month_3Field;
			}
			set
			{
				this.active_for_Month_3Field = value;
				this.RaisePropertyChanged("Active_for_Month_3");
			}
		}

		[XmlIgnore]
		public bool Active_for_Month_3Specified
		{
			get
			{
				return this.active_for_Month_3FieldSpecified;
			}
			set
			{
				this.active_for_Month_3FieldSpecified = value;
				this.RaisePropertyChanged("Active_for_Month_3Specified");
			}
		}

		[XmlElement(Order = 13)]
		public bool Active_for_12th_Day_Month_3
		{
			get
			{
				return this.active_for_12th_Day_Month_3Field;
			}
			set
			{
				this.active_for_12th_Day_Month_3Field = value;
				this.RaisePropertyChanged("Active_for_12th_Day_Month_3");
			}
		}

		[XmlIgnore]
		public bool Active_for_12th_Day_Month_3Specified
		{
			get
			{
				return this.active_for_12th_Day_Month_3FieldSpecified;
			}
			set
			{
				this.active_for_12th_Day_Month_3FieldSpecified = value;
				this.RaisePropertyChanged("Active_for_12th_Day_Month_3Specified");
			}
		}

		[XmlElement("Employee_Tax_Election_Data", Order = 14)]
		public Worker_Tax_ElectionsType[] Employee_Tax_Election_Data
		{
			get
			{
				return this.employee_Tax_Election_DataField;
			}
			set
			{
				this.employee_Tax_Election_DataField = value;
				this.RaisePropertyChanged("Employee_Tax_Election_Data");
			}
		}

		[XmlElement(Order = 15)]
		public QTD_Tax_Filing_Data_for_Quarterly_WorkerType QTD_Data
		{
			get
			{
				return this.qTD_DataField;
			}
			set
			{
				this.qTD_DataField = value;
				this.RaisePropertyChanged("QTD_Data");
			}
		}

		[XmlElement(Order = 16)]
		public YTD_Tax_Filing_Data_for_Quarterly_WorkerType YTD_Data
		{
			get
			{
				return this.yTD_DataField;
			}
			set
			{
				this.yTD_DataField = value;
				this.RaisePropertyChanged("YTD_Data");
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
