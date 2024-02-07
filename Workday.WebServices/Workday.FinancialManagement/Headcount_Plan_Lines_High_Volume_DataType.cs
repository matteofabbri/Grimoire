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
	public class Headcount_Plan_Lines_High_Volume_DataType : INotifyPropertyChanged
	{
		private string line_OrderField;

		private decimal yearField;

		private bool yearFieldSpecified;

		private Fiscal_Time_IntervalObjectType fiscal_Time_Interval_ReferenceField;

		private decimal planned_Headcount_AmountField;

		private bool planned_Headcount_AmountFieldSpecified;

		private decimal planned_FTE_AmountField;

		private bool planned_FTE_AmountFieldSpecified;

		private string memoField;

		private Accounting_Worktag_and_Aggregation_DimensionObjectType[] worktag_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Line_Order
		{
			get
			{
				return this.line_OrderField;
			}
			set
			{
				this.line_OrderField = value;
				this.RaisePropertyChanged("Line_Order");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Year
		{
			get
			{
				return this.yearField;
			}
			set
			{
				this.yearField = value;
				this.RaisePropertyChanged("Year");
			}
		}

		[XmlIgnore]
		public bool YearSpecified
		{
			get
			{
				return this.yearFieldSpecified;
			}
			set
			{
				this.yearFieldSpecified = value;
				this.RaisePropertyChanged("YearSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Fiscal_Time_IntervalObjectType Fiscal_Time_Interval_Reference
		{
			get
			{
				return this.fiscal_Time_Interval_ReferenceField;
			}
			set
			{
				this.fiscal_Time_Interval_ReferenceField = value;
				this.RaisePropertyChanged("Fiscal_Time_Interval_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Planned_Headcount_Amount
		{
			get
			{
				return this.planned_Headcount_AmountField;
			}
			set
			{
				this.planned_Headcount_AmountField = value;
				this.RaisePropertyChanged("Planned_Headcount_Amount");
			}
		}

		[XmlIgnore]
		public bool Planned_Headcount_AmountSpecified
		{
			get
			{
				return this.planned_Headcount_AmountFieldSpecified;
			}
			set
			{
				this.planned_Headcount_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Planned_Headcount_AmountSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Planned_FTE_Amount
		{
			get
			{
				return this.planned_FTE_AmountField;
			}
			set
			{
				this.planned_FTE_AmountField = value;
				this.RaisePropertyChanged("Planned_FTE_Amount");
			}
		}

		[XmlIgnore]
		public bool Planned_FTE_AmountSpecified
		{
			get
			{
				return this.planned_FTE_AmountFieldSpecified;
			}
			set
			{
				this.planned_FTE_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Planned_FTE_AmountSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
			}
		}

		[XmlElement("Worktag_Reference", Order = 6)]
		public Accounting_Worktag_and_Aggregation_DimensionObjectType[] Worktag_Reference
		{
			get
			{
				return this.worktag_ReferenceField;
			}
			set
			{
				this.worktag_ReferenceField = value;
				this.RaisePropertyChanged("Worktag_Reference");
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
