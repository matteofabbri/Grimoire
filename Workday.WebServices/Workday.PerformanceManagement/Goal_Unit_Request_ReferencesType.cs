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
	public class Goal_Unit_Request_ReferencesType : INotifyPropertyChanged
	{
		private Goal_Target_And_Actual_Track_By__Tenanted_ObjectType[] goal_Unit_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Goal_Unit_Reference", Order = 0)]
		public Goal_Target_And_Actual_Track_By__Tenanted_ObjectType[] Goal_Unit_Reference
		{
			get
			{
				return this.goal_Unit_ReferenceField;
			}
			set
			{
				this.goal_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Goal_Unit_Reference");
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
