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
	public class Educational_Institution_Course_Request_ReferencesType : INotifyPropertyChanged
	{
		private Educational_Institution_CourseObjectType[] educational_Institution_Course_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Educational_Institution_Course_Reference", Order = 0)]
		public Educational_Institution_CourseObjectType[] Educational_Institution_Course_Reference
		{
			get
			{
				return this.educational_Institution_Course_ReferenceField;
			}
			set
			{
				this.educational_Institution_Course_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Course_Reference");
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
