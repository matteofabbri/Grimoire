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
	public class Student_Course_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Student_Course_Data_DataType[] student_Course_Data_DataField;

		private Student_Course_Data_Snapshot_DataType[] student_Course_Data_Snapshot_DataField;

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

		[XmlElement("Student_Course_Data_Data", Order = 1)]
		public Student_Course_Data_DataType[] Student_Course_Data_Data
		{
			get
			{
				return this.student_Course_Data_DataField;
			}
			set
			{
				this.student_Course_Data_DataField = value;
				this.RaisePropertyChanged("Student_Course_Data_Data");
			}
		}

		[XmlElement("Student_Course_Data_Snapshot_Data", Order = 2)]
		public Student_Course_Data_Snapshot_DataType[] Student_Course_Data_Snapshot_Data
		{
			get
			{
				return this.student_Course_Data_Snapshot_DataField;
			}
			set
			{
				this.student_Course_Data_Snapshot_DataField = value;
				this.RaisePropertyChanged("Student_Course_Data_Snapshot_Data");
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
