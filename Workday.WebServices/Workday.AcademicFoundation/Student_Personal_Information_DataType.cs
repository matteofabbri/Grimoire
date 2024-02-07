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
	public class Student_Personal_Information_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string student_IDField;

		private WorkerObjectType worker_ReferenceField;

		private bool opt_OutField;

		private bool opt_OutFieldSpecified;

		private Student_Person_DataType student_Person_DataField;

		private International_Student_Person_DataType international_Student_Person_DataField;

		private Student_Photo_DataType student_Photo_DataField;

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
		public string Student_ID
		{
			get
			{
				return this.student_IDField;
			}
			set
			{
				this.student_IDField = value;
				this.RaisePropertyChanged("Student_ID");
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
		public bool Opt_Out
		{
			get
			{
				return this.opt_OutField;
			}
			set
			{
				this.opt_OutField = value;
				this.RaisePropertyChanged("Opt_Out");
			}
		}

		[XmlIgnore]
		public bool Opt_OutSpecified
		{
			get
			{
				return this.opt_OutFieldSpecified;
			}
			set
			{
				this.opt_OutFieldSpecified = value;
				this.RaisePropertyChanged("Opt_OutSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Student_Person_DataType Student_Person_Data
		{
			get
			{
				return this.student_Person_DataField;
			}
			set
			{
				this.student_Person_DataField = value;
				this.RaisePropertyChanged("Student_Person_Data");
			}
		}

		[XmlElement(Order = 5)]
		public International_Student_Person_DataType International_Student_Person_Data
		{
			get
			{
				return this.international_Student_Person_DataField;
			}
			set
			{
				this.international_Student_Person_DataField = value;
				this.RaisePropertyChanged("International_Student_Person_Data");
			}
		}

		[XmlElement(Order = 6)]
		public Student_Photo_DataType Student_Photo_Data
		{
			get
			{
				return this.student_Photo_DataField;
			}
			set
			{
				this.student_Photo_DataField = value;
				this.RaisePropertyChanged("Student_Photo_Data");
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
