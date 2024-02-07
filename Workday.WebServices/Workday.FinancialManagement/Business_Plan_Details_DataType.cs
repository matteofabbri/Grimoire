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
	public class Business_Plan_Details_DataType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private Budget_StructureObjectType business_Plan_Structure_ReferenceField;

		private Accounting_Worktag_and_Aggregation_DimensionObjectType organizing_Dimension_ReferenceField;

		private Budget_SourceObjectType award_Contract_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private decimal yearField;

		private Fiscal_Time_IntervalObjectType fiscal_Time_Interval_ReferenceField;

		private string plan_MemoField;

		private Business_Plan_Entry_Line_DataType[] business_Plan_Entry_Line_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Accounting_Worktag_and_Aggregation_DimensionObjectType Organizing_Dimension_Reference
		{
			get
			{
				return this.organizing_Dimension_ReferenceField;
			}
			set
			{
				this.organizing_Dimension_ReferenceField = value;
				this.RaisePropertyChanged("Organizing_Dimension_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Budget_SourceObjectType Award_Contract_Reference
		{
			get
			{
				return this.award_Contract_ReferenceField;
			}
			set
			{
				this.award_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Award_Contract_Reference");
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

		[XmlElement(Order = 5)]
		public decimal Year
		{
			get
			{
				return this.yearField;
			}
			set
			{
				this.yearField = value;
				this.RaisePropertyChanged("Year");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public string Plan_Memo
		{
			get
			{
				return this.plan_MemoField;
			}
			set
			{
				this.plan_MemoField = value;
				this.RaisePropertyChanged("Plan_Memo");
			}
		}

		[XmlElement("Business_Plan_Entry_Line_Replacement_Data", Order = 8)]
		public Business_Plan_Entry_Line_DataType[] Business_Plan_Entry_Line_Replacement_Data
		{
			get
			{
				return this.business_Plan_Entry_Line_Replacement_DataField;
			}
			set
			{
				this.business_Plan_Entry_Line_Replacement_DataField = value;
				this.RaisePropertyChanged("Business_Plan_Entry_Line_Replacement_Data");
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
