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
	public class Run_Pay_Calculation_Request_CriteriaType : INotifyPropertyChanged
	{
		private PeriodObjectType period_ReferenceField;

		private Pay_Group_Pay_Run_Group_SelectionObjectType[] pay_Groups_or_Pay_Run_Groups_Selection_ReferenceField;

		private Run_CategoryObjectType run_Category_ReferenceField;

		private bool include_Requires_RecalculationField;

		private bool include_Requires_RecalculationFieldSpecified;

		private bool include_ErrorField;

		private bool include_ErrorFieldSpecified;

		private bool include_Not_Yet_StartedField;

		private bool include_Not_Yet_StartedFieldSpecified;

		private bool include_In_ProgressField;

		private bool include_In_ProgressFieldSpecified;

		private bool accounting_Only_for_Calculation_CriteriaField;

		private bool accounting_Only_for_Calculation_CriteriaFieldSpecified;

		private bool include_Queued_ProessesField;

		private bool include_Queued_ProessesFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public PeriodObjectType Period_Reference
		{
			get
			{
				return this.period_ReferenceField;
			}
			set
			{
				this.period_ReferenceField = value;
				this.RaisePropertyChanged("Period_Reference");
			}
		}

		[XmlElement("Pay_Groups_or_Pay_Run_Groups_Selection_Reference", Order = 1)]
		public Pay_Group_Pay_Run_Group_SelectionObjectType[] Pay_Groups_or_Pay_Run_Groups_Selection_Reference
		{
			get
			{
				return this.pay_Groups_or_Pay_Run_Groups_Selection_ReferenceField;
			}
			set
			{
				this.pay_Groups_or_Pay_Run_Groups_Selection_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Groups_or_Pay_Run_Groups_Selection_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Run_CategoryObjectType Run_Category_Reference
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

		[XmlElement(Order = 3)]
		public bool Include_Requires_Recalculation
		{
			get
			{
				return this.include_Requires_RecalculationField;
			}
			set
			{
				this.include_Requires_RecalculationField = value;
				this.RaisePropertyChanged("Include_Requires_Recalculation");
			}
		}

		[XmlIgnore]
		public bool Include_Requires_RecalculationSpecified
		{
			get
			{
				return this.include_Requires_RecalculationFieldSpecified;
			}
			set
			{
				this.include_Requires_RecalculationFieldSpecified = value;
				this.RaisePropertyChanged("Include_Requires_RecalculationSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Include_Error
		{
			get
			{
				return this.include_ErrorField;
			}
			set
			{
				this.include_ErrorField = value;
				this.RaisePropertyChanged("Include_Error");
			}
		}

		[XmlIgnore]
		public bool Include_ErrorSpecified
		{
			get
			{
				return this.include_ErrorFieldSpecified;
			}
			set
			{
				this.include_ErrorFieldSpecified = value;
				this.RaisePropertyChanged("Include_ErrorSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Include_Not_Yet_Started
		{
			get
			{
				return this.include_Not_Yet_StartedField;
			}
			set
			{
				this.include_Not_Yet_StartedField = value;
				this.RaisePropertyChanged("Include_Not_Yet_Started");
			}
		}

		[XmlIgnore]
		public bool Include_Not_Yet_StartedSpecified
		{
			get
			{
				return this.include_Not_Yet_StartedFieldSpecified;
			}
			set
			{
				this.include_Not_Yet_StartedFieldSpecified = value;
				this.RaisePropertyChanged("Include_Not_Yet_StartedSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Include_In_Progress
		{
			get
			{
				return this.include_In_ProgressField;
			}
			set
			{
				this.include_In_ProgressField = value;
				this.RaisePropertyChanged("Include_In_Progress");
			}
		}

		[XmlIgnore]
		public bool Include_In_ProgressSpecified
		{
			get
			{
				return this.include_In_ProgressFieldSpecified;
			}
			set
			{
				this.include_In_ProgressFieldSpecified = value;
				this.RaisePropertyChanged("Include_In_ProgressSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Accounting_Only_for_Calculation_Criteria
		{
			get
			{
				return this.accounting_Only_for_Calculation_CriteriaField;
			}
			set
			{
				this.accounting_Only_for_Calculation_CriteriaField = value;
				this.RaisePropertyChanged("Accounting_Only_for_Calculation_Criteria");
			}
		}

		[XmlIgnore]
		public bool Accounting_Only_for_Calculation_CriteriaSpecified
		{
			get
			{
				return this.accounting_Only_for_Calculation_CriteriaFieldSpecified;
			}
			set
			{
				this.accounting_Only_for_Calculation_CriteriaFieldSpecified = value;
				this.RaisePropertyChanged("Accounting_Only_for_Calculation_CriteriaSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Include_Queued_Proesses
		{
			get
			{
				return this.include_Queued_ProessesField;
			}
			set
			{
				this.include_Queued_ProessesField = value;
				this.RaisePropertyChanged("Include_Queued_Proesses");
			}
		}

		[XmlIgnore]
		public bool Include_Queued_ProessesSpecified
		{
			get
			{
				return this.include_Queued_ProessesFieldSpecified;
			}
			set
			{
				this.include_Queued_ProessesFieldSpecified = value;
				this.RaisePropertyChanged("Include_Queued_ProessesSpecified");
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
