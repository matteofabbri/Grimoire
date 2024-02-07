using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Project_Request_CriteriaType : INotifyPropertyChanged
	{
		private string idField;

		private string project_NameField;

		private Project_HierarchyObjectType project_Hierarchy_ReferenceField;

		private Document_StatusObjectType[] project_Status_ReferenceField;

		private WorkerObjectType worker_who_owns_Project_ReferenceField;

		private DateTime start_Date_On_or_AfterField;

		private bool start_Date_On_or_AfterFieldSpecified;

		private DateTime start_Date_On_or_BeforeField;

		private bool start_Date_On_or_BeforeFieldSpecified;

		private DateTime end_Date_On_or_AfterField;

		private bool end_Date_On_or_AfterFieldSpecified;

		private DateTime end_Date_On_or_BeforeField;

		private bool end_Date_On_or_BeforeFieldSpecified;

		private CustomerObjectType customer_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private Project_GroupObjectType project_Group_ReferenceField;

		private InitiativeObjectType initiative_ReferenceField;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private Success_RatingObjectType success_Rating_ReferenceField;

		private WorkerObjectType assigned_Worker_ReferenceField;

		private bool itemField;

		private ItemChoiceType5 itemElementNameField;

		private bool item1Field;

		private Item1ChoiceType2 item1ElementNameField;

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
		public string Project_Name
		{
			get
			{
				return this.project_NameField;
			}
			set
			{
				this.project_NameField = value;
				this.RaisePropertyChanged("Project_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Project_HierarchyObjectType Project_Hierarchy_Reference
		{
			get
			{
				return this.project_Hierarchy_ReferenceField;
			}
			set
			{
				this.project_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Project_Hierarchy_Reference");
			}
		}

		[XmlElement("Project_Status_Reference", Order = 3)]
		public Document_StatusObjectType[] Project_Status_Reference
		{
			get
			{
				return this.project_Status_ReferenceField;
			}
			set
			{
				this.project_Status_ReferenceField = value;
				this.RaisePropertyChanged("Project_Status_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public WorkerObjectType Worker_who_owns_Project_Reference
		{
			get
			{
				return this.worker_who_owns_Project_ReferenceField;
			}
			set
			{
				this.worker_who_owns_Project_ReferenceField = value;
				this.RaisePropertyChanged("Worker_who_owns_Project_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Start_Date_On_or_After
		{
			get
			{
				return this.start_Date_On_or_AfterField;
			}
			set
			{
				this.start_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Start_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Start_Date_On_or_AfterSpecified
		{
			get
			{
				return this.start_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.start_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Start_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Start_Date_On_or_Before
		{
			get
			{
				return this.start_Date_On_or_BeforeField;
			}
			set
			{
				this.start_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Start_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Start_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.start_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.start_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Start_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime End_Date_On_or_After
		{
			get
			{
				return this.end_Date_On_or_AfterField;
			}
			set
			{
				this.end_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("End_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool End_Date_On_or_AfterSpecified
		{
			get
			{
				return this.end_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.end_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("End_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime End_Date_On_or_Before
		{
			get
			{
				return this.end_Date_On_or_BeforeField;
			}
			set
			{
				this.end_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("End_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool End_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.end_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.end_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("End_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public CustomerObjectType Customer_Reference
		{
			get
			{
				return this.customer_ReferenceField;
			}
			set
			{
				this.customer_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Reference");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
		public Project_GroupObjectType Project_Group_Reference
		{
			get
			{
				return this.project_Group_ReferenceField;
			}
			set
			{
				this.project_Group_ReferenceField = value;
				this.RaisePropertyChanged("Project_Group_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public InitiativeObjectType Initiative_Reference
		{
			get
			{
				return this.initiative_ReferenceField;
			}
			set
			{
				this.initiative_ReferenceField = value;
				this.RaisePropertyChanged("Initiative_Reference");
			}
		}

		[XmlElement("Worktags_Reference", Order = 13)]
		public Accounting_WorktagObjectType[] Worktags_Reference
		{
			get
			{
				return this.worktags_ReferenceField;
			}
			set
			{
				this.worktags_ReferenceField = value;
				this.RaisePropertyChanged("Worktags_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public Success_RatingObjectType Success_Rating_Reference
		{
			get
			{
				return this.success_Rating_ReferenceField;
			}
			set
			{
				this.success_Rating_ReferenceField = value;
				this.RaisePropertyChanged("Success_Rating_Reference");
			}
		}

		[XmlElement(Order = 15)]
		public WorkerObjectType Assigned_Worker_Reference
		{
			get
			{
				return this.assigned_Worker_ReferenceField;
			}
			set
			{
				this.assigned_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Assigned_Worker_Reference");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Billable", typeof(bool), Order = 16), XmlElement("Both_Billable_and_Non-Billable", typeof(bool), Order = 16), XmlElement("Non-Billable", typeof(bool), Order = 16)]
		public bool Item
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

		[XmlElement(Order = 17), XmlIgnore]
		public ItemChoiceType5 ItemElementName
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

		[XmlChoiceIdentifier("Item1ElementName"), XmlElement("Both_Capital_and_Non-Capital", typeof(bool), Order = 18), XmlElement("Capital", typeof(bool), Order = 18), XmlElement("Non-Capital", typeof(bool), Order = 18)]
		public bool Item1
		{
			get
			{
				return this.item1Field;
			}
			set
			{
				this.item1Field = value;
				this.RaisePropertyChanged("Item1");
			}
		}

		[XmlElement(Order = 19), XmlIgnore]
		public Item1ChoiceType2 Item1ElementName
		{
			get
			{
				return this.item1ElementNameField;
			}
			set
			{
				this.item1ElementNameField = value;
				this.RaisePropertyChanged("Item1ElementName");
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
