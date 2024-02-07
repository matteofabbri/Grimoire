using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Period_DataType : INotifyPropertyChanged
	{
		private DateTime period_Start_DateField;

		private DateTime period_End_DateField;

		private DateTime payroll_Payment_DateField;

		private bool payroll_Payment_DateFieldSpecified;

		private bool payroll_GL_AccrualsField;

		private bool payroll_GL_AccrualsFieldSpecified;

		private decimal days_to_AccrueField;

		private bool days_to_AccrueFieldSpecified;

		private decimal days_in_BasisField;

		private bool days_in_BasisFieldSpecified;

		private DateTime accrual_DateField;

		private bool accrual_DateFieldSpecified;

		private DateTime accrual_Reversal_DateField;

		private bool accrual_Reversal_DateFieldSpecified;

		private DateTime open_Time_EntryField;

		private bool open_Time_EntryFieldSpecified;

		private DateTime lock_Time_EntryField;

		private bool lock_Time_EntryFieldSpecified;

		private DateTime unlock_for_AdjustmentsField;

		private bool unlock_for_AdjustmentsFieldSpecified;

		private DateTime close_Time_EntryField;

		private bool close_Time_EntryFieldSpecified;

		private PeriodObjectType payroll_Period_ReferenceField;

		private Valuation_Date_Override_DataType[] valuation_Date_Override_DataField;

		private string period_IDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
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

		[XmlElement(DataType = "date", Order = 1)]
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

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Payroll_Payment_Date
		{
			get
			{
				return this.payroll_Payment_DateField;
			}
			set
			{
				this.payroll_Payment_DateField = value;
				this.RaisePropertyChanged("Payroll_Payment_Date");
			}
		}

		[XmlIgnore]
		public bool Payroll_Payment_DateSpecified
		{
			get
			{
				return this.payroll_Payment_DateFieldSpecified;
			}
			set
			{
				this.payroll_Payment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Payroll_Payment_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Payroll_GL_Accruals
		{
			get
			{
				return this.payroll_GL_AccrualsField;
			}
			set
			{
				this.payroll_GL_AccrualsField = value;
				this.RaisePropertyChanged("Payroll_GL_Accruals");
			}
		}

		[XmlIgnore]
		public bool Payroll_GL_AccrualsSpecified
		{
			get
			{
				return this.payroll_GL_AccrualsFieldSpecified;
			}
			set
			{
				this.payroll_GL_AccrualsFieldSpecified = value;
				this.RaisePropertyChanged("Payroll_GL_AccrualsSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Days_to_Accrue
		{
			get
			{
				return this.days_to_AccrueField;
			}
			set
			{
				this.days_to_AccrueField = value;
				this.RaisePropertyChanged("Days_to_Accrue");
			}
		}

		[XmlIgnore]
		public bool Days_to_AccrueSpecified
		{
			get
			{
				return this.days_to_AccrueFieldSpecified;
			}
			set
			{
				this.days_to_AccrueFieldSpecified = value;
				this.RaisePropertyChanged("Days_to_AccrueSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Days_in_Basis
		{
			get
			{
				return this.days_in_BasisField;
			}
			set
			{
				this.days_in_BasisField = value;
				this.RaisePropertyChanged("Days_in_Basis");
			}
		}

		[XmlIgnore]
		public bool Days_in_BasisSpecified
		{
			get
			{
				return this.days_in_BasisFieldSpecified;
			}
			set
			{
				this.days_in_BasisFieldSpecified = value;
				this.RaisePropertyChanged("Days_in_BasisSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Accrual_Date
		{
			get
			{
				return this.accrual_DateField;
			}
			set
			{
				this.accrual_DateField = value;
				this.RaisePropertyChanged("Accrual_Date");
			}
		}

		[XmlIgnore]
		public bool Accrual_DateSpecified
		{
			get
			{
				return this.accrual_DateFieldSpecified;
			}
			set
			{
				this.accrual_DateFieldSpecified = value;
				this.RaisePropertyChanged("Accrual_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Accrual_Reversal_Date
		{
			get
			{
				return this.accrual_Reversal_DateField;
			}
			set
			{
				this.accrual_Reversal_DateField = value;
				this.RaisePropertyChanged("Accrual_Reversal_Date");
			}
		}

		[XmlIgnore]
		public bool Accrual_Reversal_DateSpecified
		{
			get
			{
				return this.accrual_Reversal_DateFieldSpecified;
			}
			set
			{
				this.accrual_Reversal_DateFieldSpecified = value;
				this.RaisePropertyChanged("Accrual_Reversal_DateSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public DateTime Open_Time_Entry
		{
			get
			{
				return this.open_Time_EntryField;
			}
			set
			{
				this.open_Time_EntryField = value;
				this.RaisePropertyChanged("Open_Time_Entry");
			}
		}

		[XmlIgnore]
		public bool Open_Time_EntrySpecified
		{
			get
			{
				return this.open_Time_EntryFieldSpecified;
			}
			set
			{
				this.open_Time_EntryFieldSpecified = value;
				this.RaisePropertyChanged("Open_Time_EntrySpecified");
			}
		}

		[XmlElement(Order = 9)]
		public DateTime Lock_Time_Entry
		{
			get
			{
				return this.lock_Time_EntryField;
			}
			set
			{
				this.lock_Time_EntryField = value;
				this.RaisePropertyChanged("Lock_Time_Entry");
			}
		}

		[XmlIgnore]
		public bool Lock_Time_EntrySpecified
		{
			get
			{
				return this.lock_Time_EntryFieldSpecified;
			}
			set
			{
				this.lock_Time_EntryFieldSpecified = value;
				this.RaisePropertyChanged("Lock_Time_EntrySpecified");
			}
		}

		[XmlElement(Order = 10)]
		public DateTime Unlock_for_Adjustments
		{
			get
			{
				return this.unlock_for_AdjustmentsField;
			}
			set
			{
				this.unlock_for_AdjustmentsField = value;
				this.RaisePropertyChanged("Unlock_for_Adjustments");
			}
		}

		[XmlIgnore]
		public bool Unlock_for_AdjustmentsSpecified
		{
			get
			{
				return this.unlock_for_AdjustmentsFieldSpecified;
			}
			set
			{
				this.unlock_for_AdjustmentsFieldSpecified = value;
				this.RaisePropertyChanged("Unlock_for_AdjustmentsSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public DateTime Close_Time_Entry
		{
			get
			{
				return this.close_Time_EntryField;
			}
			set
			{
				this.close_Time_EntryField = value;
				this.RaisePropertyChanged("Close_Time_Entry");
			}
		}

		[XmlIgnore]
		public bool Close_Time_EntrySpecified
		{
			get
			{
				return this.close_Time_EntryFieldSpecified;
			}
			set
			{
				this.close_Time_EntryFieldSpecified = value;
				this.RaisePropertyChanged("Close_Time_EntrySpecified");
			}
		}

		[XmlElement(Order = 12)]
		public PeriodObjectType Payroll_Period_Reference
		{
			get
			{
				return this.payroll_Period_ReferenceField;
			}
			set
			{
				this.payroll_Period_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Period_Reference");
			}
		}

		[XmlElement("Valuation_Date_Override_Data", Order = 13)]
		public Valuation_Date_Override_DataType[] Valuation_Date_Override_Data
		{
			get
			{
				return this.valuation_Date_Override_DataField;
			}
			set
			{
				this.valuation_Date_Override_DataField = value;
				this.RaisePropertyChanged("Valuation_Date_Override_Data");
			}
		}

		[XmlElement(Order = 14)]
		public string Period_ID
		{
			get
			{
				return this.period_IDField;
			}
			set
			{
				this.period_IDField = value;
				this.RaisePropertyChanged("Period_ID");
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
