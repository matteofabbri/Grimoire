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
	public class Statistic_Line_DataType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private Financial_BudgetObjectType[] budget_Name_ReferenceField;

		private decimal statistic_Line_ValueField;

		private bool statistic_Line_ValueFieldSpecified;

		private Accounting_WorktagObjectType[] worktag_ReferenceField;

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

		[XmlElement("Budget_Name_Reference", Order = 1)]
		public Financial_BudgetObjectType[] Budget_Name_Reference
		{
			get
			{
				return this.budget_Name_ReferenceField;
			}
			set
			{
				this.budget_Name_ReferenceField = value;
				this.RaisePropertyChanged("Budget_Name_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Statistic_Line_Value
		{
			get
			{
				return this.statistic_Line_ValueField;
			}
			set
			{
				this.statistic_Line_ValueField = value;
				this.RaisePropertyChanged("Statistic_Line_Value");
			}
		}

		[XmlIgnore]
		public bool Statistic_Line_ValueSpecified
		{
			get
			{
				return this.statistic_Line_ValueFieldSpecified;
			}
			set
			{
				this.statistic_Line_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Statistic_Line_ValueSpecified");
			}
		}

		[XmlElement("Worktag_Reference", Order = 3)]
		public Accounting_WorktagObjectType[] Worktag_Reference
		{
			get
			{
				return this.worktag_ReferenceField;
			}
			set
			{
				this.worktag_ReferenceField = value;
				this.RaisePropertyChanged("Worktag_Reference");
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
