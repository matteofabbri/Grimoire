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
	public class Student_Recruitment_Data_W25Type : INotifyPropertyChanged
	{
		private string idField;

		private Academic_Curricular_Division_Subedit_DataType[] academic_Unit_Subedit_DataField;

		private Academic_Period_Subedit_DataType[] academic_Period_Subedit_DataField;

		private Student_Prospect_StageObjectType student_Prospect_Stage_ReferenceField;

		private Educational_InterestObjectType[] educational_Interest_ReferenceField;

		private Student_Prospect_SourceObjectType student_Prospect_Source_ReferenceField;

		private Source_DetailObjectType[] source_Detail_ReferenceField;

		private RegionObjectType[] region_ReferenceField;

		private RegionObjectType[] region_to_Exclude_ReferenceField;

		private Admissions_CounselorObjectType[] admissions_Counselor_ReferenceField;

		private Admissions_CounselorObjectType[] admissions_Counselor_to_Exclude_ReferenceField;

		private Student_Prospect_TypeObjectType[] student_Prospect_Type_ReferenceField;

		private Student_TagObjectType[] student_Tags_ReferenceField;

		private DateTime expected_AvailabilityField;

		private bool expected_AvailabilityFieldSpecified;

		private LocationObjectType location_ReferenceField;

		private Student_ApplicationObjectType source_Student_Application_ReferenceField;

		private Student_Preliminary_Award_Subedit_DataType[] student_Preliminary_Award_DataField;

		private Student_Recruitment_Prospect_DataType student_Prospect_DataField;

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

		[XmlElement("Academic_Unit_Subedit_Data", Order = 1)]
		public Academic_Curricular_Division_Subedit_DataType[] Academic_Unit_Subedit_Data
		{
			get
			{
				return this.academic_Unit_Subedit_DataField;
			}
			set
			{
				this.academic_Unit_Subedit_DataField = value;
				this.RaisePropertyChanged("Academic_Unit_Subedit_Data");
			}
		}

		[XmlElement("Academic_Period_Subedit_Data", Order = 2)]
		public Academic_Period_Subedit_DataType[] Academic_Period_Subedit_Data
		{
			get
			{
				return this.academic_Period_Subedit_DataField;
			}
			set
			{
				this.academic_Period_Subedit_DataField = value;
				this.RaisePropertyChanged("Academic_Period_Subedit_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Student_Prospect_StageObjectType Student_Prospect_Stage_Reference
		{
			get
			{
				return this.student_Prospect_Stage_ReferenceField;
			}
			set
			{
				this.student_Prospect_Stage_ReferenceField = value;
				this.RaisePropertyChanged("Student_Prospect_Stage_Reference");
			}
		}

		[XmlElement("Educational_Interest_Reference", Order = 4)]
		public Educational_InterestObjectType[] Educational_Interest_Reference
		{
			get
			{
				return this.educational_Interest_ReferenceField;
			}
			set
			{
				this.educational_Interest_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Interest_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Student_Prospect_SourceObjectType Student_Prospect_Source_Reference
		{
			get
			{
				return this.student_Prospect_Source_ReferenceField;
			}
			set
			{
				this.student_Prospect_Source_ReferenceField = value;
				this.RaisePropertyChanged("Student_Prospect_Source_Reference");
			}
		}

		[XmlElement("Source_Detail_Reference", Order = 6)]
		public Source_DetailObjectType[] Source_Detail_Reference
		{
			get
			{
				return this.source_Detail_ReferenceField;
			}
			set
			{
				this.source_Detail_ReferenceField = value;
				this.RaisePropertyChanged("Source_Detail_Reference");
			}
		}

		[XmlElement("Region_Reference", Order = 7)]
		public RegionObjectType[] Region_Reference
		{
			get
			{
				return this.region_ReferenceField;
			}
			set
			{
				this.region_ReferenceField = value;
				this.RaisePropertyChanged("Region_Reference");
			}
		}

		[XmlElement("Region_to_Exclude_Reference", Order = 8)]
		public RegionObjectType[] Region_to_Exclude_Reference
		{
			get
			{
				return this.region_to_Exclude_ReferenceField;
			}
			set
			{
				this.region_to_Exclude_ReferenceField = value;
				this.RaisePropertyChanged("Region_to_Exclude_Reference");
			}
		}

		[XmlElement("Admissions_Counselor_Reference", Order = 9)]
		public Admissions_CounselorObjectType[] Admissions_Counselor_Reference
		{
			get
			{
				return this.admissions_Counselor_ReferenceField;
			}
			set
			{
				this.admissions_Counselor_ReferenceField = value;
				this.RaisePropertyChanged("Admissions_Counselor_Reference");
			}
		}

		[XmlElement("Admissions_Counselor_to_Exclude_Reference", Order = 10)]
		public Admissions_CounselorObjectType[] Admissions_Counselor_to_Exclude_Reference
		{
			get
			{
				return this.admissions_Counselor_to_Exclude_ReferenceField;
			}
			set
			{
				this.admissions_Counselor_to_Exclude_ReferenceField = value;
				this.RaisePropertyChanged("Admissions_Counselor_to_Exclude_Reference");
			}
		}

		[XmlElement("Student_Prospect_Type_Reference", Order = 11)]
		public Student_Prospect_TypeObjectType[] Student_Prospect_Type_Reference
		{
			get
			{
				return this.student_Prospect_Type_ReferenceField;
			}
			set
			{
				this.student_Prospect_Type_ReferenceField = value;
				this.RaisePropertyChanged("Student_Prospect_Type_Reference");
			}
		}

		[XmlElement("Student_Tags_Reference", Order = 12)]
		public Student_TagObjectType[] Student_Tags_Reference
		{
			get
			{
				return this.student_Tags_ReferenceField;
			}
			set
			{
				this.student_Tags_ReferenceField = value;
				this.RaisePropertyChanged("Student_Tags_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 13)]
		public DateTime Expected_Availability
		{
			get
			{
				return this.expected_AvailabilityField;
			}
			set
			{
				this.expected_AvailabilityField = value;
				this.RaisePropertyChanged("Expected_Availability");
			}
		}

		[XmlIgnore]
		public bool Expected_AvailabilitySpecified
		{
			get
			{
				return this.expected_AvailabilityFieldSpecified;
			}
			set
			{
				this.expected_AvailabilityFieldSpecified = value;
				this.RaisePropertyChanged("Expected_AvailabilitySpecified");
			}
		}

		[XmlElement(Order = 14)]
		public LocationObjectType Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
			}
		}

		[XmlElement(Order = 15)]
		public Student_ApplicationObjectType Source_Student_Application_Reference
		{
			get
			{
				return this.source_Student_Application_ReferenceField;
			}
			set
			{
				this.source_Student_Application_ReferenceField = value;
				this.RaisePropertyChanged("Source_Student_Application_Reference");
			}
		}

		[XmlElement("Student_Preliminary_Award_Data", Order = 16)]
		public Student_Preliminary_Award_Subedit_DataType[] Student_Preliminary_Award_Data
		{
			get
			{
				return this.student_Preliminary_Award_DataField;
			}
			set
			{
				this.student_Preliminary_Award_DataField = value;
				this.RaisePropertyChanged("Student_Preliminary_Award_Data");
			}
		}

		[XmlElement(Order = 17)]
		public Student_Recruitment_Prospect_DataType Student_Prospect_Data
		{
			get
			{
				return this.student_Prospect_DataField;
			}
			set
			{
				this.student_Prospect_DataField = value;
				this.RaisePropertyChanged("Student_Prospect_Data");
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
