using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Off-cycle_Input_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Offcycle_Input_DataType : INotifyPropertyChanged
	{
		private object itemField;

		private Position_ElementObjectType position_ReferenceField;

		private decimal amountField;

		private bool amountFieldSpecified;

		private decimal hoursField;

		private bool hoursFieldSpecified;

		private decimal rateField;

		private bool rateFieldSpecified;

		private bool adjustmentField;

		private bool adjustmentFieldSpecified;

		private DateTime reference_DateField;

		private bool reference_DateFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private DateTime coverage_Start_DateField;

		private bool coverage_Start_DateFieldSpecified;

		private DateTime coverage_End_DateField;

		private bool coverage_End_DateFieldSpecified;

		private Payroll_Input_Worktags_DataType payroll_Worktags_DataField;

		private Offcycle_Input_Line_DataType[] input_Line_DataField;

		private CompanyObjectType company_ReferenceField;

		private string commentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Deduction_Reference", typeof(Deduction__All_ObjectType), Order = 0), XmlElement("Earning_Reference", typeof(Earning__All_ObjectType), Order = 0)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 1)]
		public Position_ElementObjectType Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
				this.RaisePropertyChanged("Amount");
			}
		}

		[XmlIgnore]
		public bool AmountSpecified
		{
			get
			{
				return this.amountFieldSpecified;
			}
			set
			{
				this.amountFieldSpecified = value;
				this.RaisePropertyChanged("AmountSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Hours
		{
			get
			{
				return this.hoursField;
			}
			set
			{
				this.hoursField = value;
				this.RaisePropertyChanged("Hours");
			}
		}

		[XmlIgnore]
		public bool HoursSpecified
		{
			get
			{
				return this.hoursFieldSpecified;
			}
			set
			{
				this.hoursFieldSpecified = value;
				this.RaisePropertyChanged("HoursSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Rate
		{
			get
			{
				return this.rateField;
			}
			set
			{
				this.rateField = value;
				this.RaisePropertyChanged("Rate");
			}
		}

		[XmlIgnore]
		public bool RateSpecified
		{
			get
			{
				return this.rateFieldSpecified;
			}
			set
			{
				this.rateFieldSpecified = value;
				this.RaisePropertyChanged("RateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Adjustment
		{
			get
			{
				return this.adjustmentField;
			}
			set
			{
				this.adjustmentField = value;
				this.RaisePropertyChanged("Adjustment");
			}
		}

		[XmlIgnore]
		public bool AdjustmentSpecified
		{
			get
			{
				return this.adjustmentFieldSpecified;
			}
			set
			{
				this.adjustmentFieldSpecified = value;
				this.RaisePropertyChanged("AdjustmentSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Reference_Date
		{
			get
			{
				return this.reference_DateField;
			}
			set
			{
				this.reference_DateField = value;
				this.RaisePropertyChanged("Reference_Date");
			}
		}

		[XmlIgnore]
		public bool Reference_DateSpecified
		{
			get
			{
				return this.reference_DateFieldSpecified;
			}
			set
			{
				this.reference_DateFieldSpecified = value;
				this.RaisePropertyChanged("Reference_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Coverage_Start_Date
		{
			get
			{
				return this.coverage_Start_DateField;
			}
			set
			{
				this.coverage_Start_DateField = value;
				this.RaisePropertyChanged("Coverage_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Coverage_Start_DateSpecified
		{
			get
			{
				return this.coverage_Start_DateFieldSpecified;
			}
			set
			{
				this.coverage_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Coverage_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Coverage_End_Date
		{
			get
			{
				return this.coverage_End_DateField;
			}
			set
			{
				this.coverage_End_DateField = value;
				this.RaisePropertyChanged("Coverage_End_Date");
			}
		}

		[XmlIgnore]
		public bool Coverage_End_DateSpecified
		{
			get
			{
				return this.coverage_End_DateFieldSpecified;
			}
			set
			{
				this.coverage_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Coverage_End_DateSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public Payroll_Input_Worktags_DataType Payroll_Worktags_Data
		{
			get
			{
				return this.payroll_Worktags_DataField;
			}
			set
			{
				this.payroll_Worktags_DataField = value;
				this.RaisePropertyChanged("Payroll_Worktags_Data");
			}
		}

		[XmlElement("Input_Line_Data", Order = 11)]
		public Offcycle_Input_Line_DataType[] Input_Line_Data
		{
			get
			{
				return this.input_Line_DataField;
			}
			set
			{
				this.input_Line_DataField = value;
				this.RaisePropertyChanged("Input_Line_Data");
			}
		}

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
				this.RaisePropertyChanged("Comment");
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
