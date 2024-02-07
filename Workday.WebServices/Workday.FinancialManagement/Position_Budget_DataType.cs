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
	public class Position_Budget_DataType : INotifyPropertyChanged
	{
		private bool locked_in_Workday_ReferenceField;

		private bool locked_in_Workday_ReferenceFieldSpecified;

		private CompanyObjectType company_ReferenceField;

		private Budget_StructureObjectType business_Plan_Structure_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private decimal fiscal_Year_NumberField;

		private Fiscal_Time_IntervalObjectType fiscal_Time_Interval_ReferenceField;

		private Position_RestrictionsObjectType position_ReferenceField;

		private Position_Budget_Group_EventObjectType position_Budget_Group_Load_ReferenceField;

		private decimal compensation_BudgetField;

		private bool compensation_BudgetFieldSpecified;

		private decimal fringe_Benefit_BudgetField;

		private bool fringe_Benefit_BudgetFieldSpecified;

		private Budget_Amendment_TypeObjectType business_Plan_Amendment_Type_ReferenceField;

		private string memoField;

		private Position_Budget_Line_Replacement_DataType[] position_Budget_Line_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Locked_in_Workday_Reference
		{
			get
			{
				return this.locked_in_Workday_ReferenceField;
			}
			set
			{
				this.locked_in_Workday_ReferenceField = value;
				this.RaisePropertyChanged("Locked_in_Workday_Reference");
			}
		}

		[XmlIgnore]
		public bool Locked_in_Workday_ReferenceSpecified
		{
			get
			{
				return this.locked_in_Workday_ReferenceFieldSpecified;
			}
			set
			{
				this.locked_in_Workday_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Locked_in_Workday_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Budget_StructureObjectType Business_Plan_Structure_Reference
		{
			get
			{
				return this.business_Plan_Structure_ReferenceField;
			}
			set
			{
				this.business_Plan_Structure_ReferenceField = value;
				this.RaisePropertyChanged("Business_Plan_Structure_Reference");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public decimal Fiscal_Year_Number
		{
			get
			{
				return this.fiscal_Year_NumberField;
			}
			set
			{
				this.fiscal_Year_NumberField = value;
				this.RaisePropertyChanged("Fiscal_Year_Number");
			}
		}

		[XmlElement(Order = 5)]
		public Fiscal_Time_IntervalObjectType Fiscal_Time_Interval_Reference
		{
			get
			{
				return this.fiscal_Time_Interval_ReferenceField;
			}
			set
			{
				this.fiscal_Time_Interval_ReferenceField = value;
				this.RaisePropertyChanged("Fiscal_Time_Interval_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Position_RestrictionsObjectType Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Position_Budget_Group_EventObjectType Position_Budget_Group_Load_Reference
		{
			get
			{
				return this.position_Budget_Group_Load_ReferenceField;
			}
			set
			{
				this.position_Budget_Group_Load_ReferenceField = value;
				this.RaisePropertyChanged("Position_Budget_Group_Load_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Compensation_Budget
		{
			get
			{
				return this.compensation_BudgetField;
			}
			set
			{
				this.compensation_BudgetField = value;
				this.RaisePropertyChanged("Compensation_Budget");
			}
		}

		[XmlIgnore]
		public bool Compensation_BudgetSpecified
		{
			get
			{
				return this.compensation_BudgetFieldSpecified;
			}
			set
			{
				this.compensation_BudgetFieldSpecified = value;
				this.RaisePropertyChanged("Compensation_BudgetSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Fringe_Benefit_Budget
		{
			get
			{
				return this.fringe_Benefit_BudgetField;
			}
			set
			{
				this.fringe_Benefit_BudgetField = value;
				this.RaisePropertyChanged("Fringe_Benefit_Budget");
			}
		}

		[XmlIgnore]
		public bool Fringe_Benefit_BudgetSpecified
		{
			get
			{
				return this.fringe_Benefit_BudgetFieldSpecified;
			}
			set
			{
				this.fringe_Benefit_BudgetFieldSpecified = value;
				this.RaisePropertyChanged("Fringe_Benefit_BudgetSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public Budget_Amendment_TypeObjectType Business_Plan_Amendment_Type_Reference
		{
			get
			{
				return this.business_Plan_Amendment_Type_ReferenceField;
			}
			set
			{
				this.business_Plan_Amendment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Business_Plan_Amendment_Type_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
			}
		}

		[XmlElement("Position_Budget_Line_Replacement_Data", Order = 12)]
		public Position_Budget_Line_Replacement_DataType[] Position_Budget_Line_Replacement_Data
		{
			get
			{
				return this.position_Budget_Line_Replacement_DataField;
			}
			set
			{
				this.position_Budget_Line_Replacement_DataField = value;
				this.RaisePropertyChanged("Position_Budget_Line_Replacement_Data");
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
