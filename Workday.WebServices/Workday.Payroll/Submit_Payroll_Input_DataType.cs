using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Submit_Payroll_Input_DataType : INotifyPropertyChanged
	{
		private string payroll_Input_IDField;

		private string batch_IDField;

		private Integration_System__Audited_ObjectType source_ReferenceField;

		private bool ongoing_InputField;

		private bool ongoing_InputFieldSpecified;

		private DateTime start_DateField;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private Run_CategoryObjectType[] run_Category_ReferenceField;

		private WorkerObjectType worker_ReferenceField;

		private Position_ElementObjectType position_ReferenceField;

		private object itemField;

		private decimal amountField;

		private bool amountFieldSpecified;

		private decimal hoursField;

		private bool hoursFieldSpecified;

		private decimal rateField;

		private bool rateFieldSpecified;

		private bool adjustmentField;

		private bool adjustmentFieldSpecified;

		private Payroll_Input_Worktags_DataType worktag_DataField;

		private Additional_Input_DetailsType[] additional_Input_Details_DataField;

		private string commentField;

		private CurrencyObjectType currency_ReferenceField;

		private bool match_Existing_InputField;

		private bool match_Existing_InputFieldSpecified;

		private CompanyObjectType company_ReferenceField;

		private DateTime coverage_Start_DateField;

		private bool coverage_Start_DateFieldSpecified;

		private DateTime coverage_End_DateField;

		private bool coverage_End_DateFieldSpecified;

		private DateTime last_Period_End_DateField;

		private bool last_Period_End_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Payroll_Input_ID
		{
			get
			{
				return this.payroll_Input_IDField;
			}
			set
			{
				this.payroll_Input_IDField = value;
				this.RaisePropertyChanged("Payroll_Input_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Batch_ID
		{
			get
			{
				return this.batch_IDField;
			}
			set
			{
				this.batch_IDField = value;
				this.RaisePropertyChanged("Batch_ID");
			}
		}

		[XmlElement(Order = 2)]
		public Integration_System__Audited_ObjectType Source_Reference
		{
			get
			{
				return this.source_ReferenceField;
			}
			set
			{
				this.source_ReferenceField = value;
				this.RaisePropertyChanged("Source_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool Ongoing_Input
		{
			get
			{
				return this.ongoing_InputField;
			}
			set
			{
				this.ongoing_InputField = value;
				this.RaisePropertyChanged("Ongoing_Input");
			}
		}

		[XmlIgnore]
		public bool Ongoing_InputSpecified
		{
			get
			{
				return this.ongoing_InputFieldSpecified;
			}
			set
			{
				this.ongoing_InputFieldSpecified = value;
				this.RaisePropertyChanged("Ongoing_InputSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
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

		[XmlElement(DataType = "date", Order = 5)]
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

		[XmlElement("Run_Category_Reference", Order = 6)]
		public Run_CategoryObjectType[] Run_Category_Reference
		{
			get
			{
				return this.run_Category_ReferenceField;
			}
			set
			{
				this.run_Category_ReferenceField = value;
				this.RaisePropertyChanged("Run_Category_Reference");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement("Deduction_Reference", typeof(Deduction__All_ObjectType), Order = 9), XmlElement("Earning_Reference", typeof(Earning__All_ObjectType), Order = 9)]
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

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
		public Payroll_Input_Worktags_DataType Worktag_Data
		{
			get
			{
				return this.worktag_DataField;
			}
			set
			{
				this.worktag_DataField = value;
				this.RaisePropertyChanged("Worktag_Data");
			}
		}

		[XmlElement("Additional_Input_Details_Data", Order = 15)]
		public Additional_Input_DetailsType[] Additional_Input_Details_Data
		{
			get
			{
				return this.additional_Input_Details_DataField;
			}
			set
			{
				this.additional_Input_Details_DataField = value;
				this.RaisePropertyChanged("Additional_Input_Details_Data");
			}
		}

		[XmlElement(Order = 16)]
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

		[XmlElement(Order = 17)]
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

		[XmlElement(Order = 18)]
		public bool Match_Existing_Input
		{
			get
			{
				return this.match_Existing_InputField;
			}
			set
			{
				this.match_Existing_InputField = value;
				this.RaisePropertyChanged("Match_Existing_Input");
			}
		}

		[XmlIgnore]
		public bool Match_Existing_InputSpecified
		{
			get
			{
				return this.match_Existing_InputFieldSpecified;
			}
			set
			{
				this.match_Existing_InputFieldSpecified = value;
				this.RaisePropertyChanged("Match_Existing_InputSpecified");
			}
		}

		[XmlElement(Order = 19)]
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

		[XmlElement(DataType = "date", Order = 20)]
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

		[XmlElement(DataType = "date", Order = 21)]
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

		[XmlAttribute(Form = XmlSchemaForm.Qualified, DataType = "date")]
		public DateTime Last_Period_End_Date
		{
			get
			{
				return this.last_Period_End_DateField;
			}
			set
			{
				this.last_Period_End_DateField = value;
				this.RaisePropertyChanged("Last_Period_End_Date");
			}
		}

		[XmlIgnore]
		public bool Last_Period_End_DateSpecified
		{
			get
			{
				return this.last_Period_End_DateFieldSpecified;
			}
			set
			{
				this.last_Period_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Last_Period_End_DateSpecified");
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
