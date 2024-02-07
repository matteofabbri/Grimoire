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
	public class Withholding_Order_Fee_DataType : INotifyPropertyChanged
	{
		private decimal fee_AmountField;

		private Withholding_Order_Fee_TypeObjectType fee_Type_ReferenceField;

		private Deduction_RecipientObjectType deduction_Recipient_ReferenceField;

		private bool override_Fee_ScheduleField;

		private bool override_Fee_ScheduleFieldSpecified;

		private DateTime begin_DateField;

		private bool begin_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Fee_Amount
		{
			get
			{
				return this.fee_AmountField;
			}
			set
			{
				this.fee_AmountField = value;
				this.RaisePropertyChanged("Fee_Amount");
			}
		}

		[XmlElement(Order = 1)]
		public Withholding_Order_Fee_TypeObjectType Fee_Type_Reference
		{
			get
			{
				return this.fee_Type_ReferenceField;
			}
			set
			{
				this.fee_Type_ReferenceField = value;
				this.RaisePropertyChanged("Fee_Type_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Deduction_RecipientObjectType Deduction_Recipient_Reference
		{
			get
			{
				return this.deduction_Recipient_ReferenceField;
			}
			set
			{
				this.deduction_Recipient_ReferenceField = value;
				this.RaisePropertyChanged("Deduction_Recipient_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool Override_Fee_Schedule
		{
			get
			{
				return this.override_Fee_ScheduleField;
			}
			set
			{
				this.override_Fee_ScheduleField = value;
				this.RaisePropertyChanged("Override_Fee_Schedule");
			}
		}

		[XmlIgnore]
		public bool Override_Fee_ScheduleSpecified
		{
			get
			{
				return this.override_Fee_ScheduleFieldSpecified;
			}
			set
			{
				this.override_Fee_ScheduleFieldSpecified = value;
				this.RaisePropertyChanged("Override_Fee_ScheduleSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Begin_Date
		{
			get
			{
				return this.begin_DateField;
			}
			set
			{
				this.begin_DateField = value;
				this.RaisePropertyChanged("Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Begin_DateSpecified
		{
			get
			{
				return this.begin_DateFieldSpecified;
			}
			set
			{
				this.begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Begin_DateSpecified");
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
