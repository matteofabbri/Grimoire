using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Leave_Status_DataType : INotifyPropertyChanged
	{
		private bool on_LeaveField;

		private bool on_LeaveFieldSpecified;

		private DateTime leave_Start_DateField;

		private bool leave_Start_DateFieldSpecified;

		private DateTime estimated_Leave_End_DateField;

		private bool estimated_Leave_End_DateFieldSpecified;

		private DateTime leave_End_DateField;

		private bool leave_End_DateFieldSpecified;

		private DateTime first_Day_Of_WorkField;

		private bool first_Day_Of_WorkFieldSpecified;

		private Leave_of_Absence_Type_ReferenceType[] leave_of_Absence_Type_ReferenceField;

		private bool benefits_EffectField;

		private bool benefits_EffectFieldSpecified;

		private bool payroll_EffectField;

		private bool payroll_EffectFieldSpecified;

		private bool paid_Time_Off_Accrual_EffectField;

		private bool paid_Time_Off_Accrual_EffectFieldSpecified;

		private bool continuous_Service_Accrual_EffectField;

		private bool continuous_Service_Accrual_EffectFieldSpecified;

		private bool stock_Vesting_EffectField;

		private bool stock_Vesting_EffectFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool On_Leave
		{
			get
			{
				return this.on_LeaveField;
			}
			set
			{
				this.on_LeaveField = value;
				this.RaisePropertyChanged("On_Leave");
			}
		}

		[XmlIgnore]
		public bool On_LeaveSpecified
		{
			get
			{
				return this.on_LeaveFieldSpecified;
			}
			set
			{
				this.on_LeaveFieldSpecified = value;
				this.RaisePropertyChanged("On_LeaveSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Leave_Start_Date
		{
			get
			{
				return this.leave_Start_DateField;
			}
			set
			{
				this.leave_Start_DateField = value;
				this.RaisePropertyChanged("Leave_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Leave_Start_DateSpecified
		{
			get
			{
				return this.leave_Start_DateFieldSpecified;
			}
			set
			{
				this.leave_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Leave_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Estimated_Leave_End_Date
		{
			get
			{
				return this.estimated_Leave_End_DateField;
			}
			set
			{
				this.estimated_Leave_End_DateField = value;
				this.RaisePropertyChanged("Estimated_Leave_End_Date");
			}
		}

		[XmlIgnore]
		public bool Estimated_Leave_End_DateSpecified
		{
			get
			{
				return this.estimated_Leave_End_DateFieldSpecified;
			}
			set
			{
				this.estimated_Leave_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Estimated_Leave_End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Leave_End_Date
		{
			get
			{
				return this.leave_End_DateField;
			}
			set
			{
				this.leave_End_DateField = value;
				this.RaisePropertyChanged("Leave_End_Date");
			}
		}

		[XmlIgnore]
		public bool Leave_End_DateSpecified
		{
			get
			{
				return this.leave_End_DateFieldSpecified;
			}
			set
			{
				this.leave_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Leave_End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime First_Day_Of_Work
		{
			get
			{
				return this.first_Day_Of_WorkField;
			}
			set
			{
				this.first_Day_Of_WorkField = value;
				this.RaisePropertyChanged("First_Day_Of_Work");
			}
		}

		[XmlIgnore]
		public bool First_Day_Of_WorkSpecified
		{
			get
			{
				return this.first_Day_Of_WorkFieldSpecified;
			}
			set
			{
				this.first_Day_Of_WorkFieldSpecified = value;
				this.RaisePropertyChanged("First_Day_Of_WorkSpecified");
			}
		}

		[XmlElement("Leave_of_Absence_Type_Reference", Order = 5)]
		public Leave_of_Absence_Type_ReferenceType[] Leave_of_Absence_Type_Reference
		{
			get
			{
				return this.leave_of_Absence_Type_ReferenceField;
			}
			set
			{
				this.leave_of_Absence_Type_ReferenceField = value;
				this.RaisePropertyChanged("Leave_of_Absence_Type_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public bool Benefits_Effect
		{
			get
			{
				return this.benefits_EffectField;
			}
			set
			{
				this.benefits_EffectField = value;
				this.RaisePropertyChanged("Benefits_Effect");
			}
		}

		[XmlIgnore]
		public bool Benefits_EffectSpecified
		{
			get
			{
				return this.benefits_EffectFieldSpecified;
			}
			set
			{
				this.benefits_EffectFieldSpecified = value;
				this.RaisePropertyChanged("Benefits_EffectSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Payroll_Effect
		{
			get
			{
				return this.payroll_EffectField;
			}
			set
			{
				this.payroll_EffectField = value;
				this.RaisePropertyChanged("Payroll_Effect");
			}
		}

		[XmlIgnore]
		public bool Payroll_EffectSpecified
		{
			get
			{
				return this.payroll_EffectFieldSpecified;
			}
			set
			{
				this.payroll_EffectFieldSpecified = value;
				this.RaisePropertyChanged("Payroll_EffectSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Paid_Time_Off_Accrual_Effect
		{
			get
			{
				return this.paid_Time_Off_Accrual_EffectField;
			}
			set
			{
				this.paid_Time_Off_Accrual_EffectField = value;
				this.RaisePropertyChanged("Paid_Time_Off_Accrual_Effect");
			}
		}

		[XmlIgnore]
		public bool Paid_Time_Off_Accrual_EffectSpecified
		{
			get
			{
				return this.paid_Time_Off_Accrual_EffectFieldSpecified;
			}
			set
			{
				this.paid_Time_Off_Accrual_EffectFieldSpecified = value;
				this.RaisePropertyChanged("Paid_Time_Off_Accrual_EffectSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Continuous_Service_Accrual_Effect
		{
			get
			{
				return this.continuous_Service_Accrual_EffectField;
			}
			set
			{
				this.continuous_Service_Accrual_EffectField = value;
				this.RaisePropertyChanged("Continuous_Service_Accrual_Effect");
			}
		}

		[XmlIgnore]
		public bool Continuous_Service_Accrual_EffectSpecified
		{
			get
			{
				return this.continuous_Service_Accrual_EffectFieldSpecified;
			}
			set
			{
				this.continuous_Service_Accrual_EffectFieldSpecified = value;
				this.RaisePropertyChanged("Continuous_Service_Accrual_EffectSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public bool Stock_Vesting_Effect
		{
			get
			{
				return this.stock_Vesting_EffectField;
			}
			set
			{
				this.stock_Vesting_EffectField = value;
				this.RaisePropertyChanged("Stock_Vesting_Effect");
			}
		}

		[XmlIgnore]
		public bool Stock_Vesting_EffectSpecified
		{
			get
			{
				return this.stock_Vesting_EffectFieldSpecified;
			}
			set
			{
				this.stock_Vesting_EffectFieldSpecified = value;
				this.RaisePropertyChanged("Stock_Vesting_EffectSpecified");
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
