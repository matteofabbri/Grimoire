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
	public class Educational_Institution_Students_In_Grade_DataType : INotifyPropertyChanged
	{
		private Educational_Institution_Students_In_GradeObjectType educational_Institution_Students_In_Grade_ReferenceField;

		private Educational_Institution_Grade_OfferedObjectType grade_ReferenceField;

		private decimal countField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Educational_Institution_Students_In_GradeObjectType Educational_Institution_Students_In_Grade_Reference
		{
			get
			{
				return this.educational_Institution_Students_In_Grade_ReferenceField;
			}
			set
			{
				this.educational_Institution_Students_In_Grade_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Students_In_Grade_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Educational_Institution_Grade_OfferedObjectType Grade_Reference
		{
			get
			{
				return this.grade_ReferenceField;
			}
			set
			{
				this.grade_ReferenceField = value;
				this.RaisePropertyChanged("Grade_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
				this.RaisePropertyChanged("Count");
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
