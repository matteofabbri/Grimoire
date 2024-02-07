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
	public class Employee_Compensation_Allowance_Plan_Assignment_Detail_DataType : INotifyPropertyChanged
	{
		private Compensation_Element_ReferenceType compensation_Element_ReferenceField;

		private decimal percentField;

		private bool percentFieldSpecified;

		private decimal amountField;

		private bool amountFieldSpecified;

		private Currency_Reference_DataType currency_ReferenceField;

		private Frequency_Reference_DataType frequency_ReferenceField;

		private DateTime expected_End_DateField;

		private bool expected_End_DateFieldSpecified;

		private DateTime reimbursement_Start_DateField;

		private bool reimbursement_Start_DateFieldSpecified;

		private DateTime actual_End_DateField;

		private bool actual_End_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Compensation_Element_ReferenceType Compensation_Element_Reference
		{
			get
			{
				return this.compensation_Element_ReferenceField;
			}
			set
			{
				this.compensation_Element_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Element_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Percent
		{
			get
			{
				return this.percentField;
			}
			set
			{
				this.percentField = value;
				this.RaisePropertyChanged("Percent");
			}
		}

		[XmlIgnore]
		public bool PercentSpecified
		{
			get
			{
				return this.percentFieldSpecified;
			}
			set
			{
				this.percentFieldSpecified = value;
				this.RaisePropertyChanged("PercentSpecified");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public Currency_Reference_DataType Currency_Reference
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

		[XmlElement(Order = 4)]
		public Frequency_Reference_DataType Frequency_Reference
		{
			get
			{
				return this.frequency_ReferenceField;
			}
			set
			{
				this.frequency_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Expected_End_Date
		{
			get
			{
				return this.expected_End_DateField;
			}
			set
			{
				this.expected_End_DateField = value;
				this.RaisePropertyChanged("Expected_End_Date");
			}
		}

		[XmlIgnore]
		public bool Expected_End_DateSpecified
		{
			get
			{
				return this.expected_End_DateFieldSpecified;
			}
			set
			{
				this.expected_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Expected_End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Reimbursement_Start_Date
		{
			get
			{
				return this.reimbursement_Start_DateField;
			}
			set
			{
				this.reimbursement_Start_DateField = value;
				this.RaisePropertyChanged("Reimbursement_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Reimbursement_Start_DateSpecified
		{
			get
			{
				return this.reimbursement_Start_DateFieldSpecified;
			}
			set
			{
				this.reimbursement_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Reimbursement_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Actual_End_Date
		{
			get
			{
				return this.actual_End_DateField;
			}
			set
			{
				this.actual_End_DateField = value;
				this.RaisePropertyChanged("Actual_End_Date");
			}
		}

		[XmlIgnore]
		public bool Actual_End_DateSpecified
		{
			get
			{
				return this.actual_End_DateFieldSpecified;
			}
			set
			{
				this.actual_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Actual_End_DateSpecified");
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
