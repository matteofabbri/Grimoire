using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.WorkforcePlanning
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Headcount_Plan_Structure_DataType : INotifyPropertyChanged
	{
		private string headcount_Plan_Structure_IDField;

		private string headcount_Plan_Structure_NameField;

		private bool link_to_Financial_BudgetField;

		private bool link_to_Financial_BudgetFieldSpecified;

		private Budget_Statistic_TypeObjectType[] statistic_Type_ReferenceField;

		private Worktag_and_Aggregation_TypeObjectType[] dimension_ReferenceField;

		private Headcount_Plan_Structure_Schedule_DataType[] headcount_Plan_Structure_Schedule_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Headcount_Plan_Structure_ID
		{
			get
			{
				return this.headcount_Plan_Structure_IDField;
			}
			set
			{
				this.headcount_Plan_Structure_IDField = value;
				this.RaisePropertyChanged("Headcount_Plan_Structure_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Headcount_Plan_Structure_Name
		{
			get
			{
				return this.headcount_Plan_Structure_NameField;
			}
			set
			{
				this.headcount_Plan_Structure_NameField = value;
				this.RaisePropertyChanged("Headcount_Plan_Structure_Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Link_to_Financial_Budget
		{
			get
			{
				return this.link_to_Financial_BudgetField;
			}
			set
			{
				this.link_to_Financial_BudgetField = value;
				this.RaisePropertyChanged("Link_to_Financial_Budget");
			}
		}

		[XmlIgnore]
		public bool Link_to_Financial_BudgetSpecified
		{
			get
			{
				return this.link_to_Financial_BudgetFieldSpecified;
			}
			set
			{
				this.link_to_Financial_BudgetFieldSpecified = value;
				this.RaisePropertyChanged("Link_to_Financial_BudgetSpecified");
			}
		}

		[XmlElement("Statistic_Type_Reference", Order = 3)]
		public Budget_Statistic_TypeObjectType[] Statistic_Type_Reference
		{
			get
			{
				return this.statistic_Type_ReferenceField;
			}
			set
			{
				this.statistic_Type_ReferenceField = value;
				this.RaisePropertyChanged("Statistic_Type_Reference");
			}
		}

		[XmlElement("Dimension_Reference", Order = 4)]
		public Worktag_and_Aggregation_TypeObjectType[] Dimension_Reference
		{
			get
			{
				return this.dimension_ReferenceField;
			}
			set
			{
				this.dimension_ReferenceField = value;
				this.RaisePropertyChanged("Dimension_Reference");
			}
		}

		[XmlElement("Headcount_Plan_Structure_Schedule_Data", Order = 5)]
		public Headcount_Plan_Structure_Schedule_DataType[] Headcount_Plan_Structure_Schedule_Data
		{
			get
			{
				return this.headcount_Plan_Structure_Schedule_DataField;
			}
			set
			{
				this.headcount_Plan_Structure_Schedule_DataField = value;
				this.RaisePropertyChanged("Headcount_Plan_Structure_Schedule_Data");
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
