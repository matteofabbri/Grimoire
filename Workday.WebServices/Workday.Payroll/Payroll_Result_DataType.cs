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
	public class Payroll_Result_DataType : INotifyPropertyChanged
	{
		private DateTime payment_DateField;

		private bool payment_DateFieldSpecified;

		private DateTime result_Start_DateField;

		private bool result_Start_DateFieldSpecified;

		private DateTime result_End_DateField;

		private bool result_End_DateFieldSpecified;

		private DateTime result_Calculation_MomentField;

		private bool result_Calculation_MomentFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Pay_GroupObjectType pay_Group_ReferenceField;

		private PeriodObjectType period_ReferenceField;

		private DateTime period_Start_DateField;

		private bool period_Start_DateFieldSpecified;

		private DateTime period_End_DateField;

		private bool period_End_DateFieldSpecified;

		private bool third_Party_Sick_PayField;

		private bool third_Party_Sick_PayFieldSpecified;

		private Payroll_Result_Detail_DataType[] payroll_Result_Detail_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Payment_Date
		{
			get
			{
				return this.payment_DateField;
			}
			set
			{
				this.payment_DateField = value;
				this.RaisePropertyChanged("Payment_Date");
			}
		}

		[XmlIgnore]
		public bool Payment_DateSpecified
		{
			get
			{
				return this.payment_DateFieldSpecified;
			}
			set
			{
				this.payment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Payment_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Result_Start_Date
		{
			get
			{
				return this.result_Start_DateField;
			}
			set
			{
				this.result_Start_DateField = value;
				this.RaisePropertyChanged("Result_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Result_Start_DateSpecified
		{
			get
			{
				return this.result_Start_DateFieldSpecified;
			}
			set
			{
				this.result_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Result_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Result_End_Date
		{
			get
			{
				return this.result_End_DateField;
			}
			set
			{
				this.result_End_DateField = value;
				this.RaisePropertyChanged("Result_End_Date");
			}
		}

		[XmlIgnore]
		public bool Result_End_DateSpecified
		{
			get
			{
				return this.result_End_DateFieldSpecified;
			}
			set
			{
				this.result_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Result_End_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public DateTime Result_Calculation_Moment
		{
			get
			{
				return this.result_Calculation_MomentField;
			}
			set
			{
				this.result_Calculation_MomentField = value;
				this.RaisePropertyChanged("Result_Calculation_Moment");
			}
		}

		[XmlIgnore]
		public bool Result_Calculation_MomentSpecified
		{
			get
			{
				return this.result_Calculation_MomentFieldSpecified;
			}
			set
			{
				this.result_Calculation_MomentFieldSpecified = value;
				this.RaisePropertyChanged("Result_Calculation_MomentSpecified");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public Pay_GroupObjectType Pay_Group_Reference
		{
			get
			{
				return this.pay_Group_ReferenceField;
			}
			set
			{
				this.pay_Group_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Group_Reference");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Period_Start_Date
		{
			get
			{
				return this.period_Start_DateField;
			}
			set
			{
				this.period_Start_DateField = value;
				this.RaisePropertyChanged("Period_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Period_Start_DateSpecified
		{
			get
			{
				return this.period_Start_DateFieldSpecified;
			}
			set
			{
				this.period_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Period_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Period_End_Date
		{
			get
			{
				return this.period_End_DateField;
			}
			set
			{
				this.period_End_DateField = value;
				this.RaisePropertyChanged("Period_End_Date");
			}
		}

		[XmlIgnore]
		public bool Period_End_DateSpecified
		{
			get
			{
				return this.period_End_DateFieldSpecified;
			}
			set
			{
				this.period_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Period_End_DateSpecified");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement("Payroll_Result_Detail_Data", Order = 10)]
		public Payroll_Result_Detail_DataType[] Payroll_Result_Detail_Data
		{
			get
			{
				return this.payroll_Result_Detail_DataField;
			}
			set
			{
				this.payroll_Result_Detail_DataField = value;
				this.RaisePropertyChanged("Payroll_Result_Detail_Data");
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
