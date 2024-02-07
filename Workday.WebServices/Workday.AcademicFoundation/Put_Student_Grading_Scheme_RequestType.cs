using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Student_Grading_Scheme_RequestType : INotifyPropertyChanged
	{
		private Student_Grading_SchemeObjectType student_Grading_Scheme_ReferenceField;

		private Student_Grading_Scheme_DataType student_Grading_Scheme_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Grading_SchemeObjectType Student_Grading_Scheme_Reference
		{
			get
			{
				return this.student_Grading_Scheme_ReferenceField;
			}
			set
			{
				this.student_Grading_Scheme_ReferenceField = value;
				this.RaisePropertyChanged("Student_Grading_Scheme_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Student_Grading_Scheme_DataType Student_Grading_Scheme_Data
		{
			get
			{
				return this.student_Grading_Scheme_DataField;
			}
			set
			{
				this.student_Grading_Scheme_DataField = value;
				this.RaisePropertyChanged("Student_Grading_Scheme_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
