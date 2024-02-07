using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_Goal_Milestone_Detail_DataType : INotifyPropertyChanged
	{
		private Goal_MilestoneObjectType goal_Milestone_ReferenceField;

		private string goal_Milestone_Reference_IDField;

		private string goal_Milestone_NameField;

		private DateTime goal_Milestone_Due_DateField;

		private bool goal_Milestone_Due_DateFieldSpecified;

		private Component_CompletionObjectType goal_Milestone_Status_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Goal_MilestoneObjectType Goal_Milestone_Reference
		{
			get
			{
				return this.goal_Milestone_ReferenceField;
			}
			set
			{
				this.goal_Milestone_ReferenceField = value;
				this.RaisePropertyChanged("Goal_Milestone_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Goal_Milestone_Reference_ID
		{
			get
			{
				return this.goal_Milestone_Reference_IDField;
			}
			set
			{
				this.goal_Milestone_Reference_IDField = value;
				this.RaisePropertyChanged("Goal_Milestone_Reference_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Goal_Milestone_Name
		{
			get
			{
				return this.goal_Milestone_NameField;
			}
			set
			{
				this.goal_Milestone_NameField = value;
				this.RaisePropertyChanged("Goal_Milestone_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Goal_Milestone_Due_Date
		{
			get
			{
				return this.goal_Milestone_Due_DateField;
			}
			set
			{
				this.goal_Milestone_Due_DateField = value;
				this.RaisePropertyChanged("Goal_Milestone_Due_Date");
			}
		}

		[XmlIgnore]
		public bool Goal_Milestone_Due_DateSpecified
		{
			get
			{
				return this.goal_Milestone_Due_DateFieldSpecified;
			}
			set
			{
				this.goal_Milestone_Due_DateFieldSpecified = value;
				this.RaisePropertyChanged("Goal_Milestone_Due_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Component_CompletionObjectType Goal_Milestone_Status_Reference
		{
			get
			{
				return this.goal_Milestone_Status_ReferenceField;
			}
			set
			{
				this.goal_Milestone_Status_ReferenceField = value;
				this.RaisePropertyChanged("Goal_Milestone_Status_Reference");
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
