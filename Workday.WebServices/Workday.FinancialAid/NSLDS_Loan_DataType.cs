using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class NSLDS_Loan_DataType : INotifyPropertyChanged
	{
		private decimal sequence_NumberField;

		private bool sequence_NumberFieldSpecified;

		private bool loan_Change_FlagField;

		private bool loan_Change_FlagFieldSpecified;

		private NSLDS_Loan_Program_CodeObjectType loan_Program_Code_ReferenceField;

		private decimal loan_Net_AmountField;

		private bool loan_Net_AmountFieldSpecified;

		private NSLDS_Loan_Current_Status_CodeObjectType loan_Current_Status_Code_ReferenceField;

		private DateTime loan_Current_Status_DateField;

		private bool loan_Current_Status_DateFieldSpecified;

		private DateTime begin_DateField;

		private bool begin_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private DateTime academic_Year_Begin_DateField;

		private bool academic_Year_Begin_DateFieldSpecified;

		private DateTime academic_Year_End_DateField;

		private bool academic_Year_End_DateFieldSpecified;

		private string loan_OPEIDField;

		private NSLDS_Loan_Academic_LevelObjectType loan_Academic_Level_ReferenceField;

		private NSLDS_Unsubsidized_Loan_FlagObjectType unsubsidized_Loan_Flag_ReferenceField;

		private bool capitalized_Interest_FlagField;

		private bool capitalized_Interest_FlagFieldSpecified;

		private decimal loan_Disbursement_AmountField;

		private bool loan_Disbursement_AmountFieldSpecified;

		private DateTime loan_Disbursement_DateField;

		private bool loan_Disbursement_DateFieldSpecified;

		private NSLDS_Subsidy_StatusObjectType subsidy_Status_ReferenceField;

		private DateTime subsidy_Status_DateField;

		private bool subsidy_Status_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Sequence_Number
		{
			get
			{
				return this.sequence_NumberField;
			}
			set
			{
				this.sequence_NumberField = value;
				this.RaisePropertyChanged("Sequence_Number");
			}
		}

		[XmlIgnore]
		public bool Sequence_NumberSpecified
		{
			get
			{
				return this.sequence_NumberFieldSpecified;
			}
			set
			{
				this.sequence_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Sequence_NumberSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Loan_Change_Flag
		{
			get
			{
				return this.loan_Change_FlagField;
			}
			set
			{
				this.loan_Change_FlagField = value;
				this.RaisePropertyChanged("Loan_Change_Flag");
			}
		}

		[XmlIgnore]
		public bool Loan_Change_FlagSpecified
		{
			get
			{
				return this.loan_Change_FlagFieldSpecified;
			}
			set
			{
				this.loan_Change_FlagFieldSpecified = value;
				this.RaisePropertyChanged("Loan_Change_FlagSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public NSLDS_Loan_Program_CodeObjectType Loan_Program_Code_Reference
		{
			get
			{
				return this.loan_Program_Code_ReferenceField;
			}
			set
			{
				this.loan_Program_Code_ReferenceField = value;
				this.RaisePropertyChanged("Loan_Program_Code_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Loan_Net_Amount
		{
			get
			{
				return this.loan_Net_AmountField;
			}
			set
			{
				this.loan_Net_AmountField = value;
				this.RaisePropertyChanged("Loan_Net_Amount");
			}
		}

		[XmlIgnore]
		public bool Loan_Net_AmountSpecified
		{
			get
			{
				return this.loan_Net_AmountFieldSpecified;
			}
			set
			{
				this.loan_Net_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Loan_Net_AmountSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public NSLDS_Loan_Current_Status_CodeObjectType Loan_Current_Status_Code_Reference
		{
			get
			{
				return this.loan_Current_Status_Code_ReferenceField;
			}
			set
			{
				this.loan_Current_Status_Code_ReferenceField = value;
				this.RaisePropertyChanged("Loan_Current_Status_Code_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Loan_Current_Status_Date
		{
			get
			{
				return this.loan_Current_Status_DateField;
			}
			set
			{
				this.loan_Current_Status_DateField = value;
				this.RaisePropertyChanged("Loan_Current_Status_Date");
			}
		}

		[XmlIgnore]
		public bool Loan_Current_Status_DateSpecified
		{
			get
			{
				return this.loan_Current_Status_DateFieldSpecified;
			}
			set
			{
				this.loan_Current_Status_DateFieldSpecified = value;
				this.RaisePropertyChanged("Loan_Current_Status_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Begin_Date
		{
			get
			{
				return this.begin_DateField;
			}
			set
			{
				this.begin_DateField = value;
				this.RaisePropertyChanged("Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Begin_DateSpecified
		{
			get
			{
				return this.begin_DateFieldSpecified;
			}
			set
			{
				this.begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Begin_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
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

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Academic_Year_Begin_Date
		{
			get
			{
				return this.academic_Year_Begin_DateField;
			}
			set
			{
				this.academic_Year_Begin_DateField = value;
				this.RaisePropertyChanged("Academic_Year_Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Academic_Year_Begin_DateSpecified
		{
			get
			{
				return this.academic_Year_Begin_DateFieldSpecified;
			}
			set
			{
				this.academic_Year_Begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Academic_Year_Begin_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Academic_Year_End_Date
		{
			get
			{
				return this.academic_Year_End_DateField;
			}
			set
			{
				this.academic_Year_End_DateField = value;
				this.RaisePropertyChanged("Academic_Year_End_Date");
			}
		}

		[XmlIgnore]
		public bool Academic_Year_End_DateSpecified
		{
			get
			{
				return this.academic_Year_End_DateFieldSpecified;
			}
			set
			{
				this.academic_Year_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Academic_Year_End_DateSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public string Loan_OPEID
		{
			get
			{
				return this.loan_OPEIDField;
			}
			set
			{
				this.loan_OPEIDField = value;
				this.RaisePropertyChanged("Loan_OPEID");
			}
		}

		[XmlElement(Order = 11)]
		public NSLDS_Loan_Academic_LevelObjectType Loan_Academic_Level_Reference
		{
			get
			{
				return this.loan_Academic_Level_ReferenceField;
			}
			set
			{
				this.loan_Academic_Level_ReferenceField = value;
				this.RaisePropertyChanged("Loan_Academic_Level_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public NSLDS_Unsubsidized_Loan_FlagObjectType Unsubsidized_Loan_Flag_Reference
		{
			get
			{
				return this.unsubsidized_Loan_Flag_ReferenceField;
			}
			set
			{
				this.unsubsidized_Loan_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Unsubsidized_Loan_Flag_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public bool Capitalized_Interest_Flag
		{
			get
			{
				return this.capitalized_Interest_FlagField;
			}
			set
			{
				this.capitalized_Interest_FlagField = value;
				this.RaisePropertyChanged("Capitalized_Interest_Flag");
			}
		}

		[XmlIgnore]
		public bool Capitalized_Interest_FlagSpecified
		{
			get
			{
				return this.capitalized_Interest_FlagFieldSpecified;
			}
			set
			{
				this.capitalized_Interest_FlagFieldSpecified = value;
				this.RaisePropertyChanged("Capitalized_Interest_FlagSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Loan_Disbursement_Amount
		{
			get
			{
				return this.loan_Disbursement_AmountField;
			}
			set
			{
				this.loan_Disbursement_AmountField = value;
				this.RaisePropertyChanged("Loan_Disbursement_Amount");
			}
		}

		[XmlIgnore]
		public bool Loan_Disbursement_AmountSpecified
		{
			get
			{
				return this.loan_Disbursement_AmountFieldSpecified;
			}
			set
			{
				this.loan_Disbursement_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Loan_Disbursement_AmountSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 15)]
		public DateTime Loan_Disbursement_Date
		{
			get
			{
				return this.loan_Disbursement_DateField;
			}
			set
			{
				this.loan_Disbursement_DateField = value;
				this.RaisePropertyChanged("Loan_Disbursement_Date");
			}
		}

		[XmlIgnore]
		public bool Loan_Disbursement_DateSpecified
		{
			get
			{
				return this.loan_Disbursement_DateFieldSpecified;
			}
			set
			{
				this.loan_Disbursement_DateFieldSpecified = value;
				this.RaisePropertyChanged("Loan_Disbursement_DateSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public NSLDS_Subsidy_StatusObjectType Subsidy_Status_Reference
		{
			get
			{
				return this.subsidy_Status_ReferenceField;
			}
			set
			{
				this.subsidy_Status_ReferenceField = value;
				this.RaisePropertyChanged("Subsidy_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 17)]
		public DateTime Subsidy_Status_Date
		{
			get
			{
				return this.subsidy_Status_DateField;
			}
			set
			{
				this.subsidy_Status_DateField = value;
				this.RaisePropertyChanged("Subsidy_Status_Date");
			}
		}

		[XmlIgnore]
		public bool Subsidy_Status_DateSpecified
		{
			get
			{
				return this.subsidy_Status_DateFieldSpecified;
			}
			set
			{
				this.subsidy_Status_DateFieldSpecified = value;
				this.RaisePropertyChanged("Subsidy_Status_DateSpecified");
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
