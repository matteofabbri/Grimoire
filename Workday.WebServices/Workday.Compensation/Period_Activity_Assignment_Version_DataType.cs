using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Period_Activity_Assignment_Version_DataType : INotifyPropertyChanged
	{
		private Period_Activity_AssignmentObjectType period_Activity_Pay_Assignment_ReferenceField;

		private Period_ActivityObjectType period_Activity_ReferenceField;

		private Period_Activity_TaskObjectType period_Activity_Task_ReferenceField;

		private DateTime period_Activity_Start_DateField;

		private bool period_Activity_Start_DateFieldSpecified;

		private DateTime period_Activity_End_DateField;

		private bool period_Activity_End_DateFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private decimal assigned_AmountField;

		private bool assigned_AmountFieldSpecified;

		private decimal assigned_QuantityField;

		private bool assigned_QuantityFieldSpecified;

		private decimal assigned_Unit_RateField;

		private bool assigned_Unit_RateFieldSpecified;

		private DateTime payment_Start_DateField;

		private bool payment_Start_DateFieldSpecified;

		private DateTime payment_End_DateField;

		private bool payment_End_DateFieldSpecified;

		private bool do_Not_PayField;

		private bool do_Not_PayFieldSpecified;

		private string commentField;

		private Allocation_Detail_for_Period_Pay_DataType[] period_Activity_Pay_CostingField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Period_Activity_AssignmentObjectType Period_Activity_Pay_Assignment_Reference
		{
			get
			{
				return this.period_Activity_Pay_Assignment_ReferenceField;
			}
			set
			{
				this.period_Activity_Pay_Assignment_ReferenceField = value;
				this.RaisePropertyChanged("Period_Activity_Pay_Assignment_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Period_ActivityObjectType Period_Activity_Reference
		{
			get
			{
				return this.period_Activity_ReferenceField;
			}
			set
			{
				this.period_Activity_ReferenceField = value;
				this.RaisePropertyChanged("Period_Activity_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Period_Activity_TaskObjectType Period_Activity_Task_Reference
		{
			get
			{
				return this.period_Activity_Task_ReferenceField;
			}
			set
			{
				this.period_Activity_Task_ReferenceField = value;
				this.RaisePropertyChanged("Period_Activity_Task_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Period_Activity_Start_Date
		{
			get
			{
				return this.period_Activity_Start_DateField;
			}
			set
			{
				this.period_Activity_Start_DateField = value;
				this.RaisePropertyChanged("Period_Activity_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Period_Activity_Start_DateSpecified
		{
			get
			{
				return this.period_Activity_Start_DateFieldSpecified;
			}
			set
			{
				this.period_Activity_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Period_Activity_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Period_Activity_End_Date
		{
			get
			{
				return this.period_Activity_End_DateField;
			}
			set
			{
				this.period_Activity_End_DateField = value;
				this.RaisePropertyChanged("Period_Activity_End_Date");
			}
		}

		[XmlIgnore]
		public bool Period_Activity_End_DateSpecified
		{
			get
			{
				return this.period_Activity_End_DateFieldSpecified;
			}
			set
			{
				this.period_Activity_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Period_Activity_End_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
		public decimal Assigned_Amount
		{
			get
			{
				return this.assigned_AmountField;
			}
			set
			{
				this.assigned_AmountField = value;
				this.RaisePropertyChanged("Assigned_Amount");
			}
		}

		[XmlIgnore]
		public bool Assigned_AmountSpecified
		{
			get
			{
				return this.assigned_AmountFieldSpecified;
			}
			set
			{
				this.assigned_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Assigned_AmountSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Assigned_Quantity
		{
			get
			{
				return this.assigned_QuantityField;
			}
			set
			{
				this.assigned_QuantityField = value;
				this.RaisePropertyChanged("Assigned_Quantity");
			}
		}

		[XmlIgnore]
		public bool Assigned_QuantitySpecified
		{
			get
			{
				return this.assigned_QuantityFieldSpecified;
			}
			set
			{
				this.assigned_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Assigned_QuantitySpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Assigned_Unit_Rate
		{
			get
			{
				return this.assigned_Unit_RateField;
			}
			set
			{
				this.assigned_Unit_RateField = value;
				this.RaisePropertyChanged("Assigned_Unit_Rate");
			}
		}

		[XmlIgnore]
		public bool Assigned_Unit_RateSpecified
		{
			get
			{
				return this.assigned_Unit_RateFieldSpecified;
			}
			set
			{
				this.assigned_Unit_RateFieldSpecified = value;
				this.RaisePropertyChanged("Assigned_Unit_RateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Payment_Start_Date
		{
			get
			{
				return this.payment_Start_DateField;
			}
			set
			{
				this.payment_Start_DateField = value;
				this.RaisePropertyChanged("Payment_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Payment_Start_DateSpecified
		{
			get
			{
				return this.payment_Start_DateFieldSpecified;
			}
			set
			{
				this.payment_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 10)]
		public DateTime Payment_End_Date
		{
			get
			{
				return this.payment_End_DateField;
			}
			set
			{
				this.payment_End_DateField = value;
				this.RaisePropertyChanged("Payment_End_Date");
			}
		}

		[XmlIgnore]
		public bool Payment_End_DateSpecified
		{
			get
			{
				return this.payment_End_DateFieldSpecified;
			}
			set
			{
				this.payment_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Payment_End_DateSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public bool Do_Not_Pay
		{
			get
			{
				return this.do_Not_PayField;
			}
			set
			{
				this.do_Not_PayField = value;
				this.RaisePropertyChanged("Do_Not_Pay");
			}
		}

		[XmlIgnore]
		public bool Do_Not_PaySpecified
		{
			get
			{
				return this.do_Not_PayFieldSpecified;
			}
			set
			{
				this.do_Not_PayFieldSpecified = value;
				this.RaisePropertyChanged("Do_Not_PaySpecified");
			}
		}

		[XmlElement(Order = 12)]
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

		[XmlArray(Order = 13), XmlArrayItem("Allocation_Detail_for_Period_Pay", IsNullable = false)]
		public Allocation_Detail_for_Period_Pay_DataType[] Period_Activity_Pay_Costing
		{
			get
			{
				return this.period_Activity_Pay_CostingField;
			}
			set
			{
				this.period_Activity_Pay_CostingField = value;
				this.RaisePropertyChanged("Period_Activity_Pay_Costing");
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
