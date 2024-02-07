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
	public class Worker_GoalType : INotifyPropertyChanged
	{
		private GoalObjectType goal_ReferenceField;

		private Goal_Detail_DataType[] goal_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public GoalObjectType Goal_Reference
		{
			get
			{
				return this.goal_ReferenceField;
			}
			set
			{
				this.goal_ReferenceField = value;
				this.RaisePropertyChanged("Goal_Reference");
			}
		}

		[XmlElement("Goal_Data", Order = 1)]
		public Goal_Detail_DataType[] Goal_Data
		{
			get
			{
				return this.goal_DataField;
			}
			set
			{
				this.goal_DataField = value;
				this.RaisePropertyChanged("Goal_Data");
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
