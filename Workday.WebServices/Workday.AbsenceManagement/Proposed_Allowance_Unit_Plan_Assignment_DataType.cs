using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Proposed_Allowance_Unit_Plan_Assignment_DataType : INotifyPropertyChanged
	{
		private Allowance_Unit_PlanObjectType unit_Allowance_Plan_ReferenceField;

		private decimal number_of_UnitsField;

		private bool number_of_UnitsFieldSpecified;

		private FrequencyObjectType frequency_ReferenceField;

		private decimal per_Unit_AmountField;

		private bool per_Unit_AmountFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private DateTime reimbursement_Start_DateField;

		private bool reimbursement_Start_DateFieldSpecified;

		private DateTime actual_End_DateField;

		private bool actual_End_DateFieldSpecified;

		private bool fixed_for_Manage_by_Basis_TotalField;

		private bool fixed_for_Manage_by_Basis_TotalFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Allowance_Unit_PlanObjectType Unit_Allowance_Plan_Reference
		{
			get
			{
				return this.unit_Allowance_Plan_ReferenceField;
			}
			set
			{
				this.unit_Allowance_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Unit_Allowance_Plan_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Number_of_Units
		{
			get
			{
				return this.number_of_UnitsField;
			}
			set
			{
				this.number_of_UnitsField = value;
				this.RaisePropertyChanged("Number_of_Units");
			}
		}

		[XmlIgnore]
		public bool Number_of_UnitsSpecified
		{
			get
			{
				return this.number_of_UnitsFieldSpecified;
			}
			set
			{
				this.number_of_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_UnitsSpecified");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public decimal Per_Unit_Amount
		{
			get
			{
				return this.per_Unit_AmountField;
			}
			set
			{
				this.per_Unit_AmountField = value;
				this.RaisePropertyChanged("Per_Unit_Amount");
			}
		}

		[XmlIgnore]
		public bool Per_Unit_AmountSpecified
		{
			get
			{
				return this.per_Unit_AmountFieldSpecified;
			}
			set
			{
				this.per_Unit_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Per_Unit_AmountSpecified");
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

		[XmlElement(DataType = "date", Order = 5)]
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

		[XmlElement(DataType = "date", Order = 6)]
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

		[XmlElement(Order = 7)]
		public bool Fixed_for_Manage_by_Basis_Total
		{
			get
			{
				return this.fixed_for_Manage_by_Basis_TotalField;
			}
			set
			{
				this.fixed_for_Manage_by_Basis_TotalField = value;
				this.RaisePropertyChanged("Fixed_for_Manage_by_Basis_Total");
			}
		}

		[XmlIgnore]
		public bool Fixed_for_Manage_by_Basis_TotalSpecified
		{
			get
			{
				return this.fixed_for_Manage_by_Basis_TotalFieldSpecified;
			}
			set
			{
				this.fixed_for_Manage_by_Basis_TotalFieldSpecified = value;
				this.RaisePropertyChanged("Fixed_for_Manage_by_Basis_TotalSpecified");
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
