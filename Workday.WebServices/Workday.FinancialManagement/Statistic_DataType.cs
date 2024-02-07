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
	public class Statistic_DataType : INotifyPropertyChanged
	{
		private Statistic_DefinitionObjectType statistic_Definition_ReferenceField;

		private Financial_Entry_TypeObjectType[] ledger_Budget_Structure_Statistic_ReferenceField;

		private Fiscal_Period_Reference_DataType fiscal_Period_Reference_DataField;

		private Fiscal_YearObjectType fiscal_Summary_Year_ReferenceField;

		private Fiscal_Summary_IntervalObjectType fiscal_Summary_Interval_ReferenceField;

		private string statistic_MemoField;

		private Statistic_Line_DataType[] statistic_Values_Replacement_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Statistic_DefinitionObjectType Statistic_Definition_Reference
		{
			get
			{
				return this.statistic_Definition_ReferenceField;
			}
			set
			{
				this.statistic_Definition_ReferenceField = value;
				this.RaisePropertyChanged("Statistic_Definition_Reference");
			}
		}

		[XmlElement("Ledger_Budget_Structure_Statistic_Reference", Order = 1)]
		public Financial_Entry_TypeObjectType[] Ledger_Budget_Structure_Statistic_Reference
		{
			get
			{
				return this.ledger_Budget_Structure_Statistic_ReferenceField;
			}
			set
			{
				this.ledger_Budget_Structure_Statistic_ReferenceField = value;
				this.RaisePropertyChanged("Ledger_Budget_Structure_Statistic_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Fiscal_Period_Reference_DataType Fiscal_Period_Reference_Data
		{
			get
			{
				return this.fiscal_Period_Reference_DataField;
			}
			set
			{
				this.fiscal_Period_Reference_DataField = value;
				this.RaisePropertyChanged("Fiscal_Period_Reference_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Fiscal_YearObjectType Fiscal_Summary_Year_Reference
		{
			get
			{
				return this.fiscal_Summary_Year_ReferenceField;
			}
			set
			{
				this.fiscal_Summary_Year_ReferenceField = value;
				this.RaisePropertyChanged("Fiscal_Summary_Year_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Fiscal_Summary_IntervalObjectType Fiscal_Summary_Interval_Reference
		{
			get
			{
				return this.fiscal_Summary_Interval_ReferenceField;
			}
			set
			{
				this.fiscal_Summary_Interval_ReferenceField = value;
				this.RaisePropertyChanged("Fiscal_Summary_Interval_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Statistic_Memo
		{
			get
			{
				return this.statistic_MemoField;
			}
			set
			{
				this.statistic_MemoField = value;
				this.RaisePropertyChanged("Statistic_Memo");
			}
		}

		[XmlElement("Statistic_Values_Replacement_Data", Order = 6)]
		public Statistic_Line_DataType[] Statistic_Values_Replacement_Data
		{
			get
			{
				return this.statistic_Values_Replacement_DataField;
			}
			set
			{
				this.statistic_Values_Replacement_DataField = value;
				this.RaisePropertyChanged("Statistic_Values_Replacement_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 7)]
		public Financials_Attachment_DataType[] Attachment_Data
		{
			get
			{
				return this.attachment_DataField;
			}
			set
			{
				this.attachment_DataField = value;
				this.RaisePropertyChanged("Attachment_Data");
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
