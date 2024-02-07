using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Proposed_Calculated_Plan_Assignment_DataType : INotifyPropertyChanged
	{
		private Calculated_PlanObjectType calculated_Plan_ReferenceField;

		private decimal manage_by_Compensation_Basis_Override_AmountField;

		private bool manage_by_Compensation_Basis_Override_AmountFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private FrequencyObjectType frequency_ReferenceField;

		private DateTime actual_End_DateField;

		private bool actual_End_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Calculated_PlanObjectType Calculated_Plan_Reference
		{
			get
			{
				return this.calculated_Plan_ReferenceField;
			}
			set
			{
				this.calculated_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Calculated_Plan_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Manage_by_Compensation_Basis_Override_Amount
		{
			get
			{
				return this.manage_by_Compensation_Basis_Override_AmountField;
			}
			set
			{
				this.manage_by_Compensation_Basis_Override_AmountField = value;
				this.RaisePropertyChanged("Manage_by_Compensation_Basis_Override_Amount");
			}
		}

		[XmlIgnore]
		public bool Manage_by_Compensation_Basis_Override_AmountSpecified
		{
			get
			{
				return this.manage_by_Compensation_Basis_Override_AmountFieldSpecified;
			}
			set
			{
				this.manage_by_Compensation_Basis_Override_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Manage_by_Compensation_Basis_Override_AmountSpecified");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public FrequencyObjectType Frequency_Reference
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

		[XmlElement(DataType = "date", Order = 4)]
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
