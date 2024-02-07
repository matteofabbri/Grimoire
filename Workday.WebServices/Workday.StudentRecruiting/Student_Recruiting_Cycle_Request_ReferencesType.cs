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
	public class Student_Recruiting_Cycle_Request_ReferencesType : INotifyPropertyChanged
	{
		private Student_Recruiting_CycleObjectType[] student_Recruiting_Cycle_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Student_Recruiting_Cycle_Reference", Order = 0)]
		public Student_Recruiting_CycleObjectType[] Student_Recruiting_Cycle_Reference
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
