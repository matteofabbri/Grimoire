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
	public class Student_Accomplishment_DataType : INotifyPropertyChanged
	{
		private string idField;

		private StudentObjectType student_ReferenceField;

		private Student_Accomplishment_TypeObjectType student_Accomplishment_Type_ReferenceField;

		private string titleField;

		private DateTime accomplishment_DateField;

		private bool completedField;

		private bool completedFieldSpecified;

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
		public StudentObjectType Student_Reference
		{
			get
			{
				return this.student_ReferenceField;
			}
			set
			{
				this.student_ReferenceField = value;
				this.RaisePropertyChanged("Student_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Student_Accomplishment_TypeObjectType Student_Accomplishment_Type_Reference
		{
			get
			{
				return this.student_Accomplishment_Type_ReferenceField;
			}
			set
			{
				this.student_Accomplishment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Student_Accomplishment_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
				this.RaisePropertyChanged("Title");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Accomplishment_Date
		{
			get
			{
				return this.accomplishment_DateField;
			}
			set
			{
				this.accomplishment_DateField = value;
				this.RaisePropertyChanged("Accomplishment_Date");
			}
		}

		[XmlElement(Order = 5)]
		public bool Completed
		{
			get
			{
				return this.completedField;
			}
			set
			{
				this.completedField = value;
				this.RaisePropertyChanged("Completed");
			}
		}

		[XmlIgnore]
		public bool CompletedSpecified
		{
			get
			{
				return this.completedFieldSpecified;
			}
			set
			{
				this.completedFieldSpecified = value;
				this.RaisePropertyChanged("CompletedSpecified");
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
