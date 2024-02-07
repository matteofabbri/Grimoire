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
	public class Pay_Group_Period_Pay_Calculation_Status_As_Of_NowType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType pay_Cycle_Type_ReferenceField;

		private string action_ReasonField;

		private decimal in_ProgressField;

		private bool in_ProgressFieldSpecified;

		private decimal requires_RecalculationField;

		private bool requires_RecalculationFieldSpecified;

		private decimal pending_CompletionField;

		private bool pending_CompletionFieldSpecified;

		private decimal in_ErrorField;

		private bool in_ErrorFieldSpecified;

		private decimal on_HoldField;

		private bool on_HoldFieldSpecified;

		private decimal completedField;

		private bool completedFieldSpecified;

		private decimal totalField;

		private bool totalFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Pay_Cycle_Type_Reference
		{
			get
			{
				return this.pay_Cycle_Type_ReferenceField;
			}
			set
			{
				this.pay_Cycle_Type_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Cycle_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Action_Reason
		{
			get
			{
				return this.action_ReasonField;
			}
			set
			{
				this.action_ReasonField = value;
				this.RaisePropertyChanged("Action_Reason");
			}
		}

		[XmlElement(Order = 2)]
		public decimal In_Progress
		{
			get
			{
				return this.in_ProgressField;
			}
			set
			{
				this.in_ProgressField = value;
				this.RaisePropertyChanged("In_Progress");
			}
		}

		[XmlIgnore]
		public bool In_ProgressSpecified
		{
			get
			{
				return this.in_ProgressFieldSpecified;
			}
			set
			{
				this.in_ProgressFieldSpecified = value;
				this.RaisePropertyChanged("In_ProgressSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Requires_Recalculation
		{
			get
			{
				return this.requires_RecalculationField;
			}
			set
			{
				this.requires_RecalculationField = value;
				this.RaisePropertyChanged("Requires_Recalculation");
			}
		}

		[XmlIgnore]
		public bool Requires_RecalculationSpecified
		{
			get
			{
				return this.requires_RecalculationFieldSpecified;
			}
			set
			{
				this.requires_RecalculationFieldSpecified = value;
				this.RaisePropertyChanged("Requires_RecalculationSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Pending_Completion
		{
			get
			{
				return this.pending_CompletionField;
			}
			set
			{
				this.pending_CompletionField = value;
				this.RaisePropertyChanged("Pending_Completion");
			}
		}

		[XmlIgnore]
		public bool Pending_CompletionSpecified
		{
			get
			{
				return this.pending_CompletionFieldSpecified;
			}
			set
			{
				this.pending_CompletionFieldSpecified = value;
				this.RaisePropertyChanged("Pending_CompletionSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal In_Error
		{
			get
			{
				return this.in_ErrorField;
			}
			set
			{
				this.in_ErrorField = value;
				this.RaisePropertyChanged("In_Error");
			}
		}

		[XmlIgnore]
		public bool In_ErrorSpecified
		{
			get
			{
				return this.in_ErrorFieldSpecified;
			}
			set
			{
				this.in_ErrorFieldSpecified = value;
				this.RaisePropertyChanged("In_ErrorSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal On_Hold
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
		public decimal Completed
		{
			get
			{
				return this.completedField;
			}
			set
			{
				this.completedField = value;
				this.RaisePropertyChanged("Completed");
			}
		}

		[XmlIgnore]
		public bool CompletedSpecified
		{
			get
			{
				return this.completedFieldSpecified;
			}
			set
			{
				this.completedFieldSpecified = value;
				this.RaisePropertyChanged("CompletedSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Total
		{
			get
			{
				return this.totalField;
			}
			set
			{
				this.totalField = value;
				this.RaisePropertyChanged("Total");
			}
		}

		[XmlIgnore]
		public bool TotalSpecified
		{
			get
			{
				return this.totalFieldSpecified;
			}
			set
			{
				this.totalFieldSpecified = value;
				this.RaisePropertyChanged("TotalSpecified");
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
