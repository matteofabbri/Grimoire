using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Course_Section_Relationship_Request_ReferencesType : INotifyPropertyChanged
	{
		private Student_Course_Section_ClusterObjectType[] course_Section_Relationship_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Course_Section_Relationship_Reference", Order = 0)]
		public Student_Course_Section_ClusterObjectType[] Course_Section_Relationship_Reference
		{
			get
			{
				return this.course_Section_Relationship_ReferenceField;
			}
			set
			{
				this.course_Section_Relationship_ReferenceField = value;
				this.RaisePropertyChanged("Course_Section_Relationship_Reference");
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
