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
	public class Student_Activity_Registration_Record_Request_ReferencesType : INotifyPropertyChanged
	{
		private Student_Activity_Registration_RecordObjectType[] student_Activity_Registration_Record_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Student_Activity_Registration_Record_Reference", Order = 0)]
		public Student_Activity_Registration_RecordObjectType[] Student_Activity_Registration_Record_Reference
		{
			get
			{
				return this.student_Activity_Registration_Record_ReferenceField;
			}
			set
			{
				this.student_Activity_Registration_Record_ReferenceField = value;
				this.RaisePropertyChanged("Student_Activity_Registration_Record_Reference");
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
