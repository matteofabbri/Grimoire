using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Recruiter_DataType : INotifyPropertyChanged
	{
		private string idField;

		private WorkerObjectType worker_ReferenceField;

		private Student_Recruiter_Person_DataType student_Recruiter_Person_DataField;

		private Admissions_Counselor_TypeObjectType student_Recruiter_Type_ReferenceField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Prospect_Assignment_Criteria_DataType[] prospect_Assignment_Criteria_DataField;

		private Has_Academic_Unit_with_Shareable_Subordinates_DataType academic_Unit_Shareable_DataField;

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

		[XmlElement(Order = 2)]
		public Student_Recruiter_Person_DataType Student_Recruiter_Person_Data
		{
			get
			{
				return this.student_Recruiter_Person_DataField;
			}
			set
			{
				this.student_Recruiter_Person_DataField = value;
				this.RaisePropertyChanged("Student_Recruiter_Person_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Admissions_Counselor_TypeObjectType Student_Recruiter_Type_Reference
		{
			get
			{
				return this.student_Recruiter_Type_ReferenceField;
			}
			set
			{
				this.student_Recruiter_Type_ReferenceField = value;
				this.RaisePropertyChanged("Student_Recruiter_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlIgnore]
		public bool Start_DateSpecified
		{
			get
			{
				return this.start_DateFieldSpecified;
			}
			set
			{
				this.start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement("Prospect_Assignment_Criteria_Data", Order = 7)]
		public Prospect_Assignment_Criteria_DataType[] Prospect_Assignment_Criteria_Data
		{
			get
			{
				return this.prospect_Assignment_Criteria_DataField;
			}
			set
			{
				this.prospect_Assignment_Criteria_DataField = value;
				this.RaisePropertyChanged("Prospect_Assignment_Criteria_Data");
			}
		}

		[XmlElement(Order = 8)]
		public Has_Academic_Unit_with_Shareable_Subordinates_DataType Academic_Unit_Shareable_Data
		{
			get
			{
				return this.academic_Unit_Shareable_DataField;
			}
			set
			{
				this.academic_Unit_Shareable_DataField = value;
				this.RaisePropertyChanged("Academic_Unit_Shareable_Data");
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
