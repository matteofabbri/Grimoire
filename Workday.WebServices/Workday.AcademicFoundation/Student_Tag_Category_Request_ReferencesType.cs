using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Tag_Category_Request_ReferencesType : INotifyPropertyChanged
	{
		private Student_Tag_CategoryObjectType[] student_Tag_Category_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Student_Tag_Category_Reference", Order = 0)]
		public Student_Tag_CategoryObjectType[] Student_Tag_Category_Reference
		{
			get
			{
				return this.student_Tag_Category_ReferenceField;
			}
			set
			{
				this.student_Tag_Category_ReferenceField = value;
				this.RaisePropertyChanged("Student_Tag_Category_Reference");
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
