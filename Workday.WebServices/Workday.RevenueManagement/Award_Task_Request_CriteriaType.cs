using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Award_Task_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] company_ReferenceField;

		private Award_ContractObjectType[] award_ReferenceField;

		private Award_Task_TypeObjectType[] task_Type_ReferenceField;

		private Award_Task_Type_GroupObjectType[] task_Type_Group_ReferenceField;

		private Security_GroupObjectType[] role_ReferenceField;

		private Award_Task_StatusObjectType[] status_ReferenceField;

		private DateTime due_Date_On_or_AfterField;

		private bool due_Date_On_or_AfterFieldSpecified;

		private DateTime due_Date_On_or_BeforeField;

		private bool due_Date_On_or_BeforeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Company_Reference", Order = 0)]
		public OrganizationObjectType[] Company_Reference
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

		[XmlElement("Award_Reference", Order = 1)]
		public Award_ContractObjectType[] Award_Reference
		{
			get
			{
				return this.award_ReferenceField;
			}
			set
			{
				this.award_ReferenceField = value;
				this.RaisePropertyChanged("Award_Reference");
			}
		}

		[XmlElement("Task_Type_Reference", Order = 2)]
		public Award_Task_TypeObjectType[] Task_Type_Reference
		{
			get
			{
				return this.task_Type_ReferenceField;
			}
			set
			{
				this.task_Type_ReferenceField = value;
				this.RaisePropertyChanged("Task_Type_Reference");
			}
		}

		[XmlElement("Task_Type_Group_Reference", Order = 3)]
		public Award_Task_Type_GroupObjectType[] Task_Type_Group_Reference
		{
			get
			{
				return this.task_Type_Group_ReferenceField;
			}
			set
			{
				this.task_Type_Group_ReferenceField = value;
				this.RaisePropertyChanged("Task_Type_Group_Reference");
			}
		}

		[XmlElement("Role_Reference", Order = 4)]
		public Security_GroupObjectType[] Role_Reference
		{
			get
			{
				return this.role_ReferenceField;
			}
			set
			{
				this.role_ReferenceField = value;
				this.RaisePropertyChanged("Role_Reference");
			}
		}

		[XmlElement("Status_Reference", Order = 5)]
		public Award_Task_StatusObjectType[] Status_Reference
		{
			get
			{
				return this.status_ReferenceField;
			}
			set
			{
				this.status_ReferenceField = value;
				this.RaisePropertyChanged("Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Due_Date_On_or_After
		{
			get
			{
				return this.due_Date_On_or_AfterField;
			}
			set
			{
				this.due_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Due_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Due_Date_On_or_AfterSpecified
		{
			get
			{
				return this.due_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.due_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Due_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Due_Date_On_or_Before
		{
			get
			{
				return this.due_Date_On_or_BeforeField;
			}
			set
			{
				this.due_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Due_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Due_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.due_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.due_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Due_Date_On_or_BeforeSpecified");
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
