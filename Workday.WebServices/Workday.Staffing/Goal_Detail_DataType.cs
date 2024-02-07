using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Goal_Detail_DataType : INotifyPropertyChanged
	{
		private string goal_Reference_IDField;

		private string goalField;

		private string descriptionField;

		private Organization_GoalObjectType organization_Goal_ReferenceField;

		private DateTime due_DateField;

		private bool due_DateFieldSpecified;

		private Component_CompletionObjectType completion_Status_ReferenceField;

		private DateTime completion_DateField;

		private bool completion_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Goal_Reference_ID
		{
			get
			{
				return this.goal_Reference_IDField;
			}
			set
			{
				this.goal_Reference_IDField = value;
				this.RaisePropertyChanged("Goal_Reference_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Goal
		{
			get
			{
				return this.goalField;
			}
			set
			{
				this.goalField = value;
				this.RaisePropertyChanged("Goal");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public Organization_GoalObjectType Organization_Goal_Reference
		{
			get
			{
				return this.organization_Goal_ReferenceField;
			}
			set
			{
				this.organization_Goal_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Goal_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Due_Date
		{
			get
			{
				return this.due_DateField;
			}
			set
			{
				this.due_DateField = value;
				this.RaisePropertyChanged("Due_Date");
			}
		}

		[XmlIgnore]
		public bool Due_DateSpecified
		{
			get
			{
				return this.due_DateFieldSpecified;
			}
			set
			{
				this.due_DateFieldSpecified = value;
				this.RaisePropertyChanged("Due_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Component_CompletionObjectType Completion_Status_Reference
		{
			get
			{
				return this.completion_Status_ReferenceField;
			}
			set
			{
				this.completion_Status_ReferenceField = value;
				this.RaisePropertyChanged("Completion_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Completion_Date
		{
			get
			{
				return this.completion_DateField;
			}
			set
			{
				this.completion_DateField = value;
				this.RaisePropertyChanged("Completion_Date");
			}
		}

		[XmlIgnore]
		public bool Completion_DateSpecified
		{
			get
			{
				return this.completion_DateFieldSpecified;
			}
			set
			{
				this.completion_DateFieldSpecified = value;
				this.RaisePropertyChanged("Completion_DateSpecified");
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
