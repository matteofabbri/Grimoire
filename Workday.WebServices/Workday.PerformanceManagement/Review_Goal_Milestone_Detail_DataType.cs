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
	public class Review_Goal_Milestone_Detail_DataType : INotifyPropertyChanged
	{
		private string goal_Milestone_NameField;

		private DateTime due_DateField;

		private bool due_DateFieldSpecified;

		private Component_CompletionObjectType goal_Milestone_Status_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(DataType = "date", Order = 1)]
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

		[XmlElement(Order = 2)]
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
