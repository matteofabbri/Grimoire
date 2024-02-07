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
	public class Student_Competency_DataType : INotifyPropertyChanged
	{
		private string idField;

		private StudentObjectType student_ReferenceField;

		private WorkerObjectType worker_ReferenceField;

		private CompetencyObjectType competency_ReferenceField;

		private DateTime student_Competency_Manual_Assignment_DateField;

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
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public CompetencyObjectType Competency_Reference
		{
			get
			{
				return this.competency_ReferenceField;
			}
			set
			{
				this.competency_ReferenceField = value;
				this.RaisePropertyChanged("Competency_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Student_Competency_Manual_Assignment_Date
		{
			get
			{
				return this.student_Competency_Manual_Assignment_DateField;
			}
			set
			{
				this.student_Competency_Manual_Assignment_DateField = value;
				this.RaisePropertyChanged("Student_Competency_Manual_Assignment_Date");
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
