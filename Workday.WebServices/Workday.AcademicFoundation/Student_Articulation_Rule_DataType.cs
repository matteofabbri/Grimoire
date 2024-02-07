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
	public class Student_Articulation_Rule_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Academic_UnitObjectType institution_Academic_Unit_ReferenceField;

		private Educational_InstitutionObjectType educational_Institution_ReferenceField;

		private Educational_Institution_CourseObjectType[] educational_Institution_Course_ReferenceField;

		private Student_Articulation_Rule_Snapshot_DataType[] student_Articulation_Rule_Snapshot_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public Academic_UnitObjectType Institution_Academic_Unit_Reference
		{
			get
			{
				return this.institution_Academic_Unit_ReferenceField;
			}
			set
			{
				this.institution_Academic_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Institution_Academic_Unit_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Educational_InstitutionObjectType Educational_Institution_Reference
		{
			get
			{
				return this.educational_Institution_ReferenceField;
			}
			set
			{
				this.educational_Institution_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Reference");
			}
		}

		[XmlElement("Educational_Institution_Course_Reference", Order = 3)]
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

		[XmlElement("Student_Articulation_Rule_Snapshot_Data", Order = 4)]
		public Student_Articulation_Rule_Snapshot_DataType[] Student_Articulation_Rule_Snapshot_Data
		{
			get
			{
				return this.student_Articulation_Rule_Snapshot_DataField;
			}
			set
			{
				this.student_Articulation_Rule_Snapshot_DataField = value;
				this.RaisePropertyChanged("Student_Articulation_Rule_Snapshot_Data");
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
