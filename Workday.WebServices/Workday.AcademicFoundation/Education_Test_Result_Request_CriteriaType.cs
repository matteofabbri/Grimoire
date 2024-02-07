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
	public class Education_Test_Result_Request_CriteriaType : INotifyPropertyChanged
	{
		private StudentObjectType student_ReferenceField;

		private DateTime date_TakenField;

		private bool date_TakenFieldSpecified;

		private Education_Test__All_ObjectType test_Type_ReferenceField;

		private Education_Test_Result_Data_LoadObjectType data_Load_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Date_Taken
		{
			get
			{
				return this.date_TakenField;
			}
			set
			{
				this.date_TakenField = value;
				this.RaisePropertyChanged("Date_Taken");
			}
		}

		[XmlIgnore]
		public bool Date_TakenSpecified
		{
			get
			{
				return this.date_TakenFieldSpecified;
			}
			set
			{
				this.date_TakenFieldSpecified = value;
				this.RaisePropertyChanged("Date_TakenSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Education_Test__All_ObjectType Test_Type_Reference
		{
			get
			{
				return this.test_Type_ReferenceField;
			}
			set
			{
				this.test_Type_ReferenceField = value;
				this.RaisePropertyChanged("Test_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Education_Test_Result_Data_LoadObjectType Data_Load_Reference
		{
			get
			{
				return this.data_Load_ReferenceField;
			}
			set
			{
				this.data_Load_ReferenceField = value;
				this.RaisePropertyChanged("Data_Load_Reference");
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
