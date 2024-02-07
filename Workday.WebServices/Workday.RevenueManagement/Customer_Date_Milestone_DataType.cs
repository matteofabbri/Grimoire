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
	public class Customer_Date_Milestone_DataType : INotifyPropertyChanged
	{
		private string customer_Milestone_IDField;

		private Billable_EntityObjectType customer_ReferenceField;

		private Milestone_TypeObjectType customer_Date_Milestone_Type_ReferenceField;

		private string customer_Milestone_NameField;

		private DateTime estimated_Completion_DateField;

		private bool estimated_Completion_DateFieldSpecified;

		private bool completeField;

		private bool completeFieldSpecified;

		private DateTime completed_OnField;

		private bool completed_OnFieldSpecified;

		private string commentsField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Customer_Milestone_ID
		{
			get
			{
				return this.customer_Milestone_IDField;
			}
			set
			{
				this.customer_Milestone_IDField = value;
				this.RaisePropertyChanged("Customer_Milestone_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Billable_EntityObjectType Customer_Reference
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

		[XmlElement(Order = 2)]
		public Milestone_TypeObjectType Customer_Date_Milestone_Type_Reference
		{
			get
			{
				return this.customer_Date_Milestone_Type_ReferenceField;
			}
			set
			{
				this.customer_Date_Milestone_Type_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Date_Milestone_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Customer_Milestone_Name
		{
			get
			{
				return this.customer_Milestone_NameField;
			}
			set
			{
				this.customer_Milestone_NameField = value;
				this.RaisePropertyChanged("Customer_Milestone_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Estimated_Completion_Date
		{
			get
			{
				return this.estimated_Completion_DateField;
			}
			set
			{
				this.estimated_Completion_DateField = value;
				this.RaisePropertyChanged("Estimated_Completion_Date");
			}
		}

		[XmlIgnore]
		public bool Estimated_Completion_DateSpecified
		{
			get
			{
				return this.estimated_Completion_DateFieldSpecified;
			}
			set
			{
				this.estimated_Completion_DateFieldSpecified = value;
				this.RaisePropertyChanged("Estimated_Completion_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Complete
		{
			get
			{
				return this.completeField;
			}
			set
			{
				this.completeField = value;
				this.RaisePropertyChanged("Complete");
			}
		}

		[XmlIgnore]
		public bool CompleteSpecified
		{
			get
			{
				return this.completeFieldSpecified;
			}
			set
			{
				this.completeFieldSpecified = value;
				this.RaisePropertyChanged("CompleteSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Completed_On
		{
			get
			{
				return this.completed_OnField;
			}
			set
			{
				this.completed_OnField = value;
				this.RaisePropertyChanged("Completed_On");
			}
		}

		[XmlIgnore]
		public bool Completed_OnSpecified
		{
			get
			{
				return this.completed_OnFieldSpecified;
			}
			set
			{
				this.completed_OnFieldSpecified = value;
				this.RaisePropertyChanged("Completed_OnSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public string Comments
		{
			get
			{
				return this.commentsField;
			}
			set
			{
				this.commentsField = value;
				this.RaisePropertyChanged("Comments");
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
