using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Recruiting_Campaign_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string nameField;

		private Student_Recruiting_CycleObjectType student_Recruiting_Cycle_ReferenceField;

		private Admissions_CounselorObjectType owner_ReferenceField;

		private Student_Engagement_PlanObjectType engagement_Plan_ReferenceField;

		private Unique_IdentifierObjectType[] campaign_Type_ReferenceField;

		private DateTime start_DateField;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private RegionObjectType[] region_ReferenceField;

		private decimal recruitment_GoalField;

		private bool recruitment_GoalFieldSpecified;

		private decimal budgetField;

		private bool budgetFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private string descriptionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 2)]
		public Student_Recruiting_CycleObjectType Student_Recruiting_Cycle_Reference
		{
			get
			{
				return this.student_Recruiting_Cycle_ReferenceField;
			}
			set
			{
				this.student_Recruiting_Cycle_ReferenceField = value;
				this.RaisePropertyChanged("Student_Recruiting_Cycle_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Admissions_CounselorObjectType Owner_Reference
		{
			get
			{
				return this.owner_ReferenceField;
			}
			set
			{
				this.owner_ReferenceField = value;
				this.RaisePropertyChanged("Owner_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Student_Engagement_PlanObjectType Engagement_Plan_Reference
		{
			get
			{
				return this.engagement_Plan_ReferenceField;
			}
			set
			{
				this.engagement_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Engagement_Plan_Reference");
			}
		}

		[XmlElement("Campaign_Type_Reference", Order = 5)]
		public Unique_IdentifierObjectType[] Campaign_Type_Reference
		{
			get
			{
				return this.campaign_Type_ReferenceField;
			}
			set
			{
				this.campaign_Type_ReferenceField = value;
				this.RaisePropertyChanged("Campaign_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement("Region_Reference", Order = 8)]
		public RegionObjectType[] Region_Reference
		{
			get
			{
				return this.region_ReferenceField;
			}
			set
			{
				this.region_ReferenceField = value;
				this.RaisePropertyChanged("Region_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Recruitment_Goal
		{
			get
			{
				return this.recruitment_GoalField;
			}
			set
			{
				this.recruitment_GoalField = value;
				this.RaisePropertyChanged("Recruitment_Goal");
			}
		}

		[XmlIgnore]
		public bool Recruitment_GoalSpecified
		{
			get
			{
				return this.recruitment_GoalFieldSpecified;
			}
			set
			{
				this.recruitment_GoalFieldSpecified = value;
				this.RaisePropertyChanged("Recruitment_GoalSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Budget
		{
			get
			{
				return this.budgetField;
			}
			set
			{
				this.budgetField = value;
				this.RaisePropertyChanged("Budget");
			}
		}

		[XmlIgnore]
		public bool BudgetSpecified
		{
			get
			{
				return this.budgetFieldSpecified;
			}
			set
			{
				this.budgetFieldSpecified = value;
				this.RaisePropertyChanged("BudgetSpecified");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
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
