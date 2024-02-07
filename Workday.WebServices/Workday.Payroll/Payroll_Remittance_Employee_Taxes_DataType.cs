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
	public class Payroll_Remittance_Employee_Taxes_DataType : INotifyPropertyChanged
	{
		private string gB_NameField;

		private Pay_Component_ReferenceType[] pay_Component_ReferenceField;

		private string pay_ComponentField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private Payroll_WorktagObjectType[] payroll_Worktags_ReferenceField;

		private decimal amountField;

		private bool amountFieldSpecified;

		private decimal yTDField;

		private bool yTDFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string GB_Name
		{
			get
			{
				return this.gB_NameField;
			}
			set
			{
				this.gB_NameField = value;
				this.RaisePropertyChanged("GB_Name");
			}
		}

		[XmlElement("Pay_Component_Reference", Order = 1)]
		public Pay_Component_ReferenceType[] Pay_Component_Reference
		{
			get
			{
				return this.pay_Component_ReferenceField;
			}
			set
			{
				this.pay_Component_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Component_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Pay_Component
		{
			get
			{
				return this.pay_ComponentField;
			}
			set
			{
				this.pay_ComponentField = value;
				this.RaisePropertyChanged("Pay_Component");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlIgnore]
		public bool Start_DateSpecified
		{
			get
			{
				return this.start_DateFieldSpecified;
			}
			set
			{
				this.start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
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

		[XmlElement("Payroll_Worktags_Reference", Order = 5)]
		public Payroll_WorktagObjectType[] Payroll_Worktags_Reference
		{
			get
			{
				return this.payroll_Worktags_ReferenceField;
			}
			set
			{
				this.payroll_Worktags_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Worktags_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
				this.RaisePropertyChanged("Amount");
			}
		}

		[XmlIgnore]
		public bool AmountSpecified
		{
			get
			{
				return this.amountFieldSpecified;
			}
			set
			{
				this.amountFieldSpecified = value;
				this.RaisePropertyChanged("AmountSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal YTD
		{
			get
			{
				return this.yTDField;
			}
			set
			{
				this.yTDField = value;
				this.RaisePropertyChanged("YTD");
			}
		}

		[XmlIgnore]
		public bool YTDSpecified
		{
			get
			{
				return this.yTDFieldSpecified;
			}
			set
			{
				this.yTDFieldSpecified = value;
				this.RaisePropertyChanged("YTDSpecified");
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
