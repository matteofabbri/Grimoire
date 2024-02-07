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
	public class Headcount_Plan_Template_DataType : INotifyPropertyChanged
	{
		private string headcount_Plan_Template_IDField;

		private string headcount_Plan_Template_NameField;

		private Headcount_Plan_StructureObjectType headcount_Plan_Structure_ReferenceField;

		private OrganizationObjectType top_Level_Organization_ReferenceField;

		private decimal additional_Organizational_Levels_in_PlanField;

		private bool additional_Organizational_Levels_in_PlanFieldSpecified;

		private DateTime organizations_Effective_As_Of_DateField;

		private bool organizations_Effective_As_Of_DateFieldSpecified;

		private Fiscal_YearObjectType start_Year_ReferenceField;

		private Fiscal_Time_IntervalObjectType start_Period_ReferenceField;

		private Fiscal_YearObjectType end_Year_ReferenceField;

		private Fiscal_Time_IntervalObjectType end_Period_ReferenceField;

		private PrePopulation_DataType prePopulation_DataField;

		private Headcount_Plan_Filter_DataType[] headcount_Plan_Filter_DataField;

		private Organization_Management_DataType[] organization_Management_DataField;

		private Organizations_to_Exclude_DataType[] organizations_to_Exclude_DataField;

		private Headcount_Plan_Dimension_Management_DataType[] headcount_Plan_Dimension_Management_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Headcount_Plan_Template_ID
		{
			get
			{
				return this.headcount_Plan_Template_IDField;
			}
			set
			{
				this.headcount_Plan_Template_IDField = value;
				this.RaisePropertyChanged("Headcount_Plan_Template_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Headcount_Plan_Template_Name
		{
			get
			{
				return this.headcount_Plan_Template_NameField;
			}
			set
			{
				this.headcount_Plan_Template_NameField = value;
				this.RaisePropertyChanged("Headcount_Plan_Template_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Headcount_Plan_StructureObjectType Headcount_Plan_Structure_Reference
		{
			get
			{
				return this.headcount_Plan_Structure_ReferenceField;
			}
			set
			{
				this.headcount_Plan_Structure_ReferenceField = value;
				this.RaisePropertyChanged("Headcount_Plan_Structure_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public OrganizationObjectType Top_Level_Organization_Reference
		{
			get
			{
				return this.top_Level_Organization_ReferenceField;
			}
			set
			{
				this.top_Level_Organization_ReferenceField = value;
				this.RaisePropertyChanged("Top_Level_Organization_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Additional_Organizational_Levels_in_Plan
		{
			get
			{
				return this.additional_Organizational_Levels_in_PlanField;
			}
			set
			{
				this.additional_Organizational_Levels_in_PlanField = value;
				this.RaisePropertyChanged("Additional_Organizational_Levels_in_Plan");
			}
		}

		[XmlIgnore]
		public bool Additional_Organizational_Levels_in_PlanSpecified
		{
			get
			{
				return this.additional_Organizational_Levels_in_PlanFieldSpecified;
			}
			set
			{
				this.additional_Organizational_Levels_in_PlanFieldSpecified = value;
				this.RaisePropertyChanged("Additional_Organizational_Levels_in_PlanSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Organizations_Effective_As_Of_Date
		{
			get
			{
				return this.organizations_Effective_As_Of_DateField;
			}
			set
			{
				this.organizations_Effective_As_Of_DateField = value;
				this.RaisePropertyChanged("Organizations_Effective_As_Of_Date");
			}
		}

		[XmlIgnore]
		public bool Organizations_Effective_As_Of_DateSpecified
		{
			get
			{
				return this.organizations_Effective_As_Of_DateFieldSpecified;
			}
			set
			{
				this.organizations_Effective_As_Of_DateFieldSpecified = value;
				this.RaisePropertyChanged("Organizations_Effective_As_Of_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public Fiscal_YearObjectType Start_Year_Reference
		{
			get
			{
				return this.start_Year_ReferenceField;
			}
			set
			{
				this.start_Year_ReferenceField = value;
				this.RaisePropertyChanged("Start_Year_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Fiscal_Time_IntervalObjectType Start_Period_Reference
		{
			get
			{
				return this.start_Period_ReferenceField;
			}
			set
			{
				this.start_Period_ReferenceField = value;
				this.RaisePropertyChanged("Start_Period_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Fiscal_YearObjectType End_Year_Reference
		{
			get
			{
				return this.end_Year_ReferenceField;
			}
			set
			{
				this.end_Year_ReferenceField = value;
				this.RaisePropertyChanged("End_Year_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Fiscal_Time_IntervalObjectType End_Period_Reference
		{
			get
			{
				return this.end_Period_ReferenceField;
			}
			set
			{
				this.end_Period_ReferenceField = value;
				this.RaisePropertyChanged("End_Period_Reference");
			}
		}

		[XmlElement("Pre-Population_Data", Order = 10)]
		public PrePopulation_DataType PrePopulation_Data
		{
			get
			{
				return this.prePopulation_DataField;
			}
			set
			{
				this.prePopulation_DataField = value;
				this.RaisePropertyChanged("PrePopulation_Data");
			}
		}

		[XmlElement("Headcount_Plan_Filter_Data", Order = 11)]
		public Headcount_Plan_Filter_DataType[] Headcount_Plan_Filter_Data
		{
			get
			{
				return this.headcount_Plan_Filter_DataField;
			}
			set
			{
				this.headcount_Plan_Filter_DataField = value;
				this.RaisePropertyChanged("Headcount_Plan_Filter_Data");
			}
		}

		[XmlElement("Organization_Management_Data", Order = 12)]
		public Organization_Management_DataType[] Organization_Management_Data
		{
			get
			{
				return this.organization_Management_DataField;
			}
			set
			{
				this.organization_Management_DataField = value;
				this.RaisePropertyChanged("Organization_Management_Data");
			}
		}

		[XmlElement("Organizations_to_Exclude_Data", Order = 13)]
		public Organizations_to_Exclude_DataType[] Organizations_to_Exclude_Data
		{
			get
			{
				return this.organizations_to_Exclude_DataField;
			}
			set
			{
				this.organizations_to_Exclude_DataField = value;
				this.RaisePropertyChanged("Organizations_to_Exclude_Data");
			}
		}

		[XmlElement("Headcount_Plan_Dimension_Management_Data", Order = 14)]
		public Headcount_Plan_Dimension_Management_DataType[] Headcount_Plan_Dimension_Management_Data
		{
			get
			{
				return this.headcount_Plan_Dimension_Management_DataField;
			}
			set
			{
				this.headcount_Plan_Dimension_Management_DataField = value;
				this.RaisePropertyChanged("Headcount_Plan_Dimension_Management_Data");
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
