using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Affordable_Care_Act_Worker_Hours_And_Wages_DataType : INotifyPropertyChanged
	{
		private bool delete_InstanceField;

		private bool delete_InstanceFieldSpecified;

		private WorkerObjectType worker_ReferenceField;

		private decimal taxable_Wages_for_PeriodField;

		private bool taxable_Wages_for_PeriodFieldSpecified;

		private DateTime pay_End_DateField;

		private DateTime paycheck_DateField;

		private string paycheck_NumberField;

		private decimal paid_Hours_WorkedField;

		private bool paid_Hours_WorkedFieldSpecified;

		private decimal paid_Hours_Not_WorkedField;

		private bool paid_Hours_Not_WorkedFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Delete_Instance
		{
			get
			{
				return this.delete_InstanceField;
			}
			set
			{
				this.delete_InstanceField = value;
				this.RaisePropertyChanged("Delete_Instance");
			}
		}

		[XmlIgnore]
		public bool Delete_InstanceSpecified
		{
			get
			{
				return this.delete_InstanceFieldSpecified;
			}
			set
			{
				this.delete_InstanceFieldSpecified = value;
				this.RaisePropertyChanged("Delete_InstanceSpecified");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public decimal Taxable_Wages_for_Period
		{
			get
			{
				return this.taxable_Wages_for_PeriodField;
			}
			set
			{
				this.taxable_Wages_for_PeriodField = value;
				this.RaisePropertyChanged("Taxable_Wages_for_Period");
			}
		}

		[XmlIgnore]
		public bool Taxable_Wages_for_PeriodSpecified
		{
			get
			{
				return this.taxable_Wages_for_PeriodFieldSpecified;
			}
			set
			{
				this.taxable_Wages_for_PeriodFieldSpecified = value;
				this.RaisePropertyChanged("Taxable_Wages_for_PeriodSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Pay_End_Date
		{
			get
			{
				return this.pay_End_DateField;
			}
			set
			{
				this.pay_End_DateField = value;
				this.RaisePropertyChanged("Pay_End_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Paycheck_Date
		{
			get
			{
				return this.paycheck_DateField;
			}
			set
			{
				this.paycheck_DateField = value;
				this.RaisePropertyChanged("Paycheck_Date");
			}
		}

		[XmlElement(Order = 5)]
		public string Paycheck_Number
		{
			get
			{
				return this.paycheck_NumberField;
			}
			set
			{
				this.paycheck_NumberField = value;
				this.RaisePropertyChanged("Paycheck_Number");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Paid_Hours_Worked
		{
			get
			{
				return this.paid_Hours_WorkedField;
			}
			set
			{
				this.paid_Hours_WorkedField = value;
				this.RaisePropertyChanged("Paid_Hours_Worked");
			}
		}

		[XmlIgnore]
		public bool Paid_Hours_WorkedSpecified
		{
			get
			{
				return this.paid_Hours_WorkedFieldSpecified;
			}
			set
			{
				this.paid_Hours_WorkedFieldSpecified = value;
				this.RaisePropertyChanged("Paid_Hours_WorkedSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Paid_Hours_Not_Worked
		{
			get
			{
				return this.paid_Hours_Not_WorkedField;
			}
			set
			{
				this.paid_Hours_Not_WorkedField = value;
				this.RaisePropertyChanged("Paid_Hours_Not_Worked");
			}
		}

		[XmlIgnore]
		public bool Paid_Hours_Not_WorkedSpecified
		{
			get
			{
				return this.paid_Hours_Not_WorkedFieldSpecified;
			}
			set
			{
				this.paid_Hours_Not_WorkedFieldSpecified = value;
				this.RaisePropertyChanged("Paid_Hours_Not_WorkedSpecified");
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
