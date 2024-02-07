using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Compensation_Change_DataType : INotifyPropertyChanged
	{
		private Event_Classification_SubcategoryObjectType reason_ReferenceField;

		private bool override_Compensation_Basis_CalculationField;

		private bool override_Compensation_Basis_CalculationFieldSpecified;

		private decimal itemField;

		private ItemChoiceType2 itemElementNameField;

		private Compensatable_Guidelines_DataType compensation_Guidelines_DataField;

		private Proposed_Base_Pay_Plan_Assignment_Container_DataType pay_Plan_DataField;

		private Proposed_Salary_Unit_Plan_Assignment_Container_DataType unit_Salary_Plan_DataField;

		private Proposed_Allowance_Plan_Assignment_Container_DataType allowance_Plan_DataField;

		private Proposed_Allowance_Unit_Plan_Assignment_Container_DataType unit_Allowance_Plan_DataField;

		private Proposed_Bonus_Plan_Assignment_Container_DataType bonus_Plan_DataField;

		private Proposed_Merit_Plan_Assignment_Container_DataType merit_Plan_DataField;

		private Proposed_Commission_Plan_Assignment_Container_DataType commission_Plan_DataField;

		private Proposed_Stock_Plan_Assignment_Container_DataType stock_Plan_DataField;

		private Compensation_PlanObjectType[] remove_Plan_DataField;

		private Proposed_Period_Salary_Plan_Assignment_Container_DataType period_Salary_Plan_DataField;

		private Proposed_Calculated_Plan_Assignment_Container_DataType calculated_Plan_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Event_Classification_SubcategoryObjectType Reason_Reference
		{
			get
			{
				return this.reason_ReferenceField;
			}
			set
			{
				this.reason_ReferenceField = value;
				this.RaisePropertyChanged("Reason_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Override_Compensation_Basis_Calculation
		{
			get
			{
				return this.override_Compensation_Basis_CalculationField;
			}
			set
			{
				this.override_Compensation_Basis_CalculationField = value;
				this.RaisePropertyChanged("Override_Compensation_Basis_Calculation");
			}
		}

		[XmlIgnore]
		public bool Override_Compensation_Basis_CalculationSpecified
		{
			get
			{
				return this.override_Compensation_Basis_CalculationFieldSpecified;
			}
			set
			{
				this.override_Compensation_Basis_CalculationFieldSpecified = value;
				this.RaisePropertyChanged("Override_Compensation_Basis_CalculationSpecified");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Primary_Compensation_Basis", typeof(decimal), Order = 2), XmlElement("Primary_Compensation_Basis_Amount_Change", typeof(decimal), Order = 2), XmlElement("Primary_Compensation_Basis_Percent_Change", typeof(decimal), Order = 2)]
		public decimal Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 3), XmlIgnore]
		public ItemChoiceType2 ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
			}
		}

		[XmlElement(Order = 4)]
		public Compensatable_Guidelines_DataType Compensation_Guidelines_Data
		{
			get
			{
				return this.compensation_Guidelines_DataField;
			}
			set
			{
				this.compensation_Guidelines_DataField = value;
				this.RaisePropertyChanged("Compensation_Guidelines_Data");
			}
		}

		[XmlElement(Order = 5)]
		public Proposed_Base_Pay_Plan_Assignment_Container_DataType Pay_Plan_Data
		{
			get
			{
				return this.pay_Plan_DataField;
			}
			set
			{
				this.pay_Plan_DataField = value;
				this.RaisePropertyChanged("Pay_Plan_Data");
			}
		}

		[XmlElement(Order = 6)]
		public Proposed_Salary_Unit_Plan_Assignment_Container_DataType Unit_Salary_Plan_Data
		{
			get
			{
				return this.unit_Salary_Plan_DataField;
			}
			set
			{
				this.unit_Salary_Plan_DataField = value;
				this.RaisePropertyChanged("Unit_Salary_Plan_Data");
			}
		}

		[XmlElement(Order = 7)]
		public Proposed_Allowance_Plan_Assignment_Container_DataType Allowance_Plan_Data
		{
			get
			{
				return this.allowance_Plan_DataField;
			}
			set
			{
				this.allowance_Plan_DataField = value;
				this.RaisePropertyChanged("Allowance_Plan_Data");
			}
		}

		[XmlElement(Order = 8)]
		public Proposed_Allowance_Unit_Plan_Assignment_Container_DataType Unit_Allowance_Plan_Data
		{
			get
			{
				return this.unit_Allowance_Plan_DataField;
			}
			set
			{
				this.unit_Allowance_Plan_DataField = value;
				this.RaisePropertyChanged("Unit_Allowance_Plan_Data");
			}
		}

		[XmlElement(Order = 9)]
		public Proposed_Bonus_Plan_Assignment_Container_DataType Bonus_Plan_Data
		{
			get
			{
				return this.bonus_Plan_DataField;
			}
			set
			{
				this.bonus_Plan_DataField = value;
				this.RaisePropertyChanged("Bonus_Plan_Data");
			}
		}

		[XmlElement(Order = 10)]
		public Proposed_Merit_Plan_Assignment_Container_DataType Merit_Plan_Data
		{
			get
			{
				return this.merit_Plan_DataField;
			}
			set
			{
				this.merit_Plan_DataField = value;
				this.RaisePropertyChanged("Merit_Plan_Data");
			}
		}

		[XmlElement(Order = 11)]
		public Proposed_Commission_Plan_Assignment_Container_DataType Commission_Plan_Data
		{
			get
			{
				return this.commission_Plan_DataField;
			}
			set
			{
				this.commission_Plan_DataField = value;
				this.RaisePropertyChanged("Commission_Plan_Data");
			}
		}

		[XmlElement(Order = 12)]
		public Proposed_Stock_Plan_Assignment_Container_DataType Stock_Plan_Data
		{
			get
			{
				return this.stock_Plan_DataField;
			}
			set
			{
				this.stock_Plan_DataField = value;
				this.RaisePropertyChanged("Stock_Plan_Data");
			}
		}

		[XmlArray(Order = 13), XmlArrayItem("Compensation_Plan_Reference", typeof(Compensation_PlanObjectType), IsNullable = false)]
		public Compensation_PlanObjectType[] Remove_Plan_Data
		{
			get
			{
				return this.remove_Plan_DataField;
			}
			set
			{
				this.remove_Plan_DataField = value;
				this.RaisePropertyChanged("Remove_Plan_Data");
			}
		}

		[XmlElement(Order = 14)]
		public Proposed_Period_Salary_Plan_Assignment_Container_DataType Period_Salary_Plan_Data
		{
			get
			{
				return this.period_Salary_Plan_DataField;
			}
			set
			{
				this.period_Salary_Plan_DataField = value;
				this.RaisePropertyChanged("Period_Salary_Plan_Data");
			}
		}

		[XmlElement(Order = 15)]
		public Proposed_Calculated_Plan_Assignment_Container_DataType Calculated_Plan_Data
		{
			get
			{
				return this.calculated_Plan_DataField;
			}
			set
			{
				this.calculated_Plan_DataField = value;
				this.RaisePropertyChanged("Calculated_Plan_Data");
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
