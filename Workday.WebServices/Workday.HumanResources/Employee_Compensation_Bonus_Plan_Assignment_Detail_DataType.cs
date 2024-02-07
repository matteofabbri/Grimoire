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
	public class Employee_Compensation_Bonus_Plan_Assignment_Detail_DataType : INotifyPropertyChanged
	{
		private Compensation_Element_ReferenceType compensation_Element_ReferenceField;

		private decimal amountField;

		private bool amountFieldSpecified;

		private decimal percentageField;

		private bool percentageFieldSpecified;

		private bool guaranteed_MinimumField;

		private bool guaranteed_MinimumFieldSpecified;

		private Currency_Reference_DataType currency_ReferenceField;

		private Frequency_Reference_DataType frequency_ReferenceField;

		private decimal percentage_AssignedField;

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

		[XmlElement(Order = 2)]
		public decimal Percentage
		{
			get
			{
				return this.percentageField;
			}
			set
			{
				this.percentageField = value;
				this.RaisePropertyChanged("Percentage");
			}
		}

		[XmlIgnore]
		public bool PercentageSpecified
		{
			get
			{
				return this.percentageFieldSpecified;
			}
			set
			{
				this.percentageFieldSpecified = value;
				this.RaisePropertyChanged("PercentageSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Guaranteed_Minimum
		{
			get
			{
				return this.guaranteed_MinimumField;
			}
			set
			{
				this.guaranteed_MinimumField = value;
				this.RaisePropertyChanged("Guaranteed_Minimum");
			}
		}

		[XmlIgnore]
		public bool Guaranteed_MinimumSpecified
		{
			get
			{
				return this.guaranteed_MinimumFieldSpecified;
			}
			set
			{
				this.guaranteed_MinimumFieldSpecified = value;
				this.RaisePropertyChanged("Guaranteed_MinimumSpecified");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
		public decimal Percentage_Assigned
		{
			get
			{
				return this.percentage_AssignedField;
			}
			set
			{
				this.percentage_AssignedField = value;
				this.RaisePropertyChanged("Percentage_Assigned");
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
