using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Compensation_Default_DataType : INotifyPropertyChanged
	{
		private Compensatable_Default_Guidelines_DataType guidelines_DataField;

		private Proposed_Base_Pay_Plan_Assignment_Container_DataType pay_Plan_DataField;

		private Proposed_Salary_Unit_Plan_Assignment_Container_DataType unit_Salary_Plan_DataField;

		private Proposed_Allowance_Plan_Assignment_Container_DataType allowance_Plan_NonUnit_Based_DataField;

		private Proposed_Allowance_Unit_Plan_Assignment_Container_DataType allowance_Plan_Unit_Based_DataField;

		private Proposed_Bonus_Plan_Assignment_Container_DataType bonus_Plan_DataField;

		private Proposed_Merit_Plan_Assignment_Container_DataType merit_Plan_DataField;

		private Proposed_Commission_Plan_Assignment_Container_DataType commission_Plan_DataField;

		private Proposed_Stock_Plan_Assignment_Container_DataType stock_Plan_DataField;

		private Proposed_Period_Salary_Plan_Assignment_Container_DataType period_Salary_Plan_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Compensatable_Default_Guidelines_DataType Guidelines_Data
		{
			get
			{
				return this.guidelines_DataField;
			}
			set
			{
				this.guidelines_DataField = value;
				this.RaisePropertyChanged("Guidelines_Data");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement("Allowance_Plan_Non-Unit_Based_Data", Order = 3)]
		public Proposed_Allowance_Plan_Assignment_Container_DataType Allowance_Plan_NonUnit_Based_Data
		{
			get
			{
				return this.allowance_Plan_NonUnit_Based_DataField;
			}
			set
			{
				this.allowance_Plan_NonUnit_Based_DataField = value;
				this.RaisePropertyChanged("Allowance_Plan_NonUnit_Based_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Proposed_Allowance_Unit_Plan_Assignment_Container_DataType Allowance_Plan_Unit_Based_Data
		{
			get
			{
				return this.allowance_Plan_Unit_Based_DataField;
			}
			set
			{
				this.allowance_Plan_Unit_Based_DataField = value;
				this.RaisePropertyChanged("Allowance_Plan_Unit_Based_Data");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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
