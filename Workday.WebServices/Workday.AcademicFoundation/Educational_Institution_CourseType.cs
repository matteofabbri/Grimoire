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
	public class Educational_Institution_CourseType : INotifyPropertyChanged
	{
		private Educational_Institution_CourseObjectType educational_Institution_Course_ReferenceField;

		private Educational_Institution_Course_DataType educational_Institution_Course_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Educational_Institution_CourseObjectType Educational_Institution_Course_Reference
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

		[XmlElement(Order = 1)]
		public Educational_Institution_Course_DataType Educational_Institution_Course_Data
		{
			get
			{
				return this.educational_Institution_Course_DataField;
			}
			set
			{
				this.educational_Institution_Course_DataField = value;
				this.RaisePropertyChanged("Educational_Institution_Course_Data");
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
