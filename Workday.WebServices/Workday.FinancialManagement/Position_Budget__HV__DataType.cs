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
	public class Position_Budget__HV__DataType : INotifyPropertyChanged
	{
		private bool locked_in_WorkdayField;

		private bool locked_in_WorkdayFieldSpecified;

		private bool submitField;

		private bool submitFieldSpecified;

		private Position_Budget_Group_EventObjectType position_Budget_Group_Load_ReferenceField;

		private string memoField;

		private CompanyObjectType company_ReferenceField;

		private Budget_StructureObjectType budget_Structure_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private decimal fiscal_Year_NumberField;

		private Fiscal_Time_IntervalObjectType fiscal_Time_Interval_ReferenceField;

		private Position_RestrictionsObjectType position_ReferenceField;

		private decimal compensation_Budget_TotalField;

		private bool compensation_Budget_TotalFieldSpecified;

		private Budget_Amendment_TypeObjectType business_Plan_Amendment_Type_ReferenceField;

		private Position_Budget_Line_Replacement__HV__DataType[] position_Budget_Line_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Locked_in_Workday
		{
			get
			{
				return this.locked_in_WorkdayField;
			}
			set
			{
				this.locked_in_WorkdayField = value;
				this.RaisePropertyChanged("Locked_in_Workday");
			}
		}

		[XmlIgnore]
		public bool Locked_in_WorkdaySpecified
		{
			get
			{
				return this.locked_in_WorkdayFieldSpecified;
			}
			set
			{
				this.locked_in_WorkdayFieldSpecified = value;
				this.RaisePropertyChanged("Locked_in_WorkdaySpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Submit
		{
			get
			{
				return this.submitField;
			}
			set
			{
				this.submitField = value;
				this.RaisePropertyChanged("Submit");
			}
		}

		[XmlIgnore]
		public bool SubmitSpecified
		{
			get
			{
				return this.submitFieldSpecified;
			}
			set
			{
				this.submitFieldSpecified = value;
				this.RaisePropertyChanged("SubmitSpecified");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public Budget_StructureObjectType Budget_Structure_Reference
		{
			get
			{
				return this.budget_Structure_ReferenceField;
			}
			set
			{
				this.budget_Structure_ReferenceField = value;
				this.RaisePropertyChanged("Budget_Structure_Reference");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public decimal Compensation_Budget_Total
		{
			get
			{
				return this.compensation_Budget_TotalField;
			}
			set
			{
				this.compensation_Budget_TotalField = value;
				this.RaisePropertyChanged("Compensation_Budget_Total");
			}
		}

		[XmlIgnore]
		public bool Compensation_Budget_TotalSpecified
		{
			get
			{
				return this.compensation_Budget_TotalFieldSpecified;
			}
			set
			{
				this.compensation_Budget_TotalFieldSpecified = value;
				this.RaisePropertyChanged("Compensation_Budget_TotalSpecified");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement("Position_Budget_Line_Replacement_Data", Order = 12)]
		public Position_Budget_Line_Replacement__HV__DataType[] Position_Budget_Line_Replacement_Data
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
