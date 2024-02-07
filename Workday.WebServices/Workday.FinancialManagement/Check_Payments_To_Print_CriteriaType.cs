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
	public class Check_Payments_To_Print_CriteriaType : INotifyPropertyChanged
	{
		private Payment_GroupObjectType payment_Group_ReferenceField;

		private DateTime payment_Date_on_Date_Or_AfterField;

		private bool payment_Date_on_Date_Or_AfterFieldSpecified;

		private DateTime payment_Date_on_Date_Or_BeforeField;

		private bool payment_Date_on_Date_Or_BeforeFieldSpecified;

		private PeriodObjectType[] periods_ReferenceField;

		private Pay_Run_Group_SelectionObjectType[] pay_Run_Groups_and_or_Pay_Groups_ReferenceField;

		private Payment_StatusObjectType[] exclude_Payment_Statuses_for_Check_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payment_GroupObjectType Payment_Group_Reference
		{
			get
			{
				return this.payment_Group_ReferenceField;
			}
			set
			{
				this.payment_Group_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Group_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Payment_Date_on_Date_Or_After
		{
			get
			{
				return this.payment_Date_on_Date_Or_AfterField;
			}
			set
			{
				this.payment_Date_on_Date_Or_AfterField = value;
				this.RaisePropertyChanged("Payment_Date_on_Date_Or_After");
			}
		}

		[XmlIgnore]
		public bool Payment_Date_on_Date_Or_AfterSpecified
		{
			get
			{
				return this.payment_Date_on_Date_Or_AfterFieldSpecified;
			}
			set
			{
				this.payment_Date_on_Date_Or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Date_on_Date_Or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Payment_Date_on_Date_Or_Before
		{
			get
			{
				return this.payment_Date_on_Date_Or_BeforeField;
			}
			set
			{
				this.payment_Date_on_Date_Or_BeforeField = value;
				this.RaisePropertyChanged("Payment_Date_on_Date_Or_Before");
			}
		}

		[XmlIgnore]
		public bool Payment_Date_on_Date_Or_BeforeSpecified
		{
			get
			{
				return this.payment_Date_on_Date_Or_BeforeFieldSpecified;
			}
			set
			{
				this.payment_Date_on_Date_Or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Date_on_Date_Or_BeforeSpecified");
			}
		}

		[XmlElement("Periods_Reference", Order = 3)]
		public PeriodObjectType[] Periods_Reference
		{
			get
			{
				return this.periods_ReferenceField;
			}
			set
			{
				this.periods_ReferenceField = value;
				this.RaisePropertyChanged("Periods_Reference");
			}
		}

		[XmlElement("Pay_Run_Groups_and_or_Pay_Groups_Reference", Order = 4)]
		public Pay_Run_Group_SelectionObjectType[] Pay_Run_Groups_and_or_Pay_Groups_Reference
		{
			get
			{
				return this.pay_Run_Groups_and_or_Pay_Groups_ReferenceField;
			}
			set
			{
				this.pay_Run_Groups_and_or_Pay_Groups_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Run_Groups_and_or_Pay_Groups_Reference");
			}
		}

		[XmlElement("Exclude_Payment_Statuses_for_Check_Reference", Order = 5)]
		public Payment_StatusObjectType[] Exclude_Payment_Statuses_for_Check_Reference
		{
			get
			{
				return this.exclude_Payment_Statuses_for_Check_ReferenceField;
			}
			set
			{
				this.exclude_Payment_Statuses_for_Check_ReferenceField = value;
				this.RaisePropertyChanged("Exclude_Payment_Statuses_for_Check_Reference");
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
