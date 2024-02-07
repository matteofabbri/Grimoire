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
	public class Canadian_Record_of_Employment_Data_DataType : INotifyPropertyChanged
	{
		private string serial_NumberField;

		private DateTime date_IssuedField;

		private bool date_IssuedFieldSpecified;

		private string payroll_Ref_NumberField;

		private string business_NumberField;

		private string sINField;

		private DateTime first_Day_WorkedField;

		private DateTime last_Day_For_Which_PaidField;

		private DateTime final_Pay_Period_Ending_DateField;

		private decimal total_Insurable_EarningsField;

		private bool total_Insurable_EarningsFieldSpecified;

		private Unique_IdentifierObjectType rOE_Status_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Serial_Number
		{
			get
			{
				return this.serial_NumberField;
			}
			set
			{
				this.serial_NumberField = value;
				this.RaisePropertyChanged("Serial_Number");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Date_Issued
		{
			get
			{
				return this.date_IssuedField;
			}
			set
			{
				this.date_IssuedField = value;
				this.RaisePropertyChanged("Date_Issued");
			}
		}

		[XmlIgnore]
		public bool Date_IssuedSpecified
		{
			get
			{
				return this.date_IssuedFieldSpecified;
			}
			set
			{
				this.date_IssuedFieldSpecified = value;
				this.RaisePropertyChanged("Date_IssuedSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string Payroll_Ref_Number
		{
			get
			{
				return this.payroll_Ref_NumberField;
			}
			set
			{
				this.payroll_Ref_NumberField = value;
				this.RaisePropertyChanged("Payroll_Ref_Number");
			}
		}

		[XmlElement(Order = 3)]
		public string Business_Number
		{
			get
			{
				return this.business_NumberField;
			}
			set
			{
				this.business_NumberField = value;
				this.RaisePropertyChanged("Business_Number");
			}
		}

		[XmlElement(Order = 4)]
		public string SIN
		{
			get
			{
				return this.sINField;
			}
			set
			{
				this.sINField = value;
				this.RaisePropertyChanged("SIN");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime First_Day_Worked
		{
			get
			{
				return this.first_Day_WorkedField;
			}
			set
			{
				this.first_Day_WorkedField = value;
				this.RaisePropertyChanged("First_Day_Worked");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Last_Day_For_Which_Paid
		{
			get
			{
				return this.last_Day_For_Which_PaidField;
			}
			set
			{
				this.last_Day_For_Which_PaidField = value;
				this.RaisePropertyChanged("Last_Day_For_Which_Paid");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Final_Pay_Period_Ending_Date
		{
			get
			{
				return this.final_Pay_Period_Ending_DateField;
			}
			set
			{
				this.final_Pay_Period_Ending_DateField = value;
				this.RaisePropertyChanged("Final_Pay_Period_Ending_Date");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Total_Insurable_Earnings
		{
			get
			{
				return this.total_Insurable_EarningsField;
			}
			set
			{
				this.total_Insurable_EarningsField = value;
				this.RaisePropertyChanged("Total_Insurable_Earnings");
			}
		}

		[XmlIgnore]
		public bool Total_Insurable_EarningsSpecified
		{
			get
			{
				return this.total_Insurable_EarningsFieldSpecified;
			}
			set
			{
				this.total_Insurable_EarningsFieldSpecified = value;
				this.RaisePropertyChanged("Total_Insurable_EarningsSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public Unique_IdentifierObjectType ROE_Status_Reference
		{
			get
			{
				return this.rOE_Status_ReferenceField;
			}
			set
			{
				this.rOE_Status_ReferenceField = value;
				this.RaisePropertyChanged("ROE_Status_Reference");
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
