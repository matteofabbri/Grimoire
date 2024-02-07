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
	public class Student_Application_DataType : INotifyPropertyChanged
	{
		private Student_ApplicationObjectType student_Application_ReferenceField;

		private bool activeField;

		private bool activeFieldSpecified;

		private Student_Prospect_StageObjectType student_Prospect_Stage_ReferenceField;

		private Student_Application_File_StatusObjectType student_Application_File_Status_ReferenceField;

		private Student_Application_Review_StatusObjectType application_Review_Status_ReferenceField;

		private Student_Applicant_TypeObjectType student_Applicant_Type_ReferenceField;

		private DateTime application_DateField;

		private Program_of_StudyObjectType[] program_of_Study_ReferenceField;

		private Program_of_StudyObjectType[] program_Focuses_ReferenceField;

		private Academic_Period_Subedit_DataType[] academic_Period_DataField;

		private Student_Load_StatusObjectType anticipated_Enrollment_Level_ReferenceField;

		private LocationObjectType location_ReferenceField;

		private Learning_ModeObjectType[] learning_Mode_ReferenceField;

		private Student_TagObjectType[] student_Tags_ReferenceField;

		private DateTime payment_DateField;

		private bool payment_DateFieldSpecified;

		private decimal payment_AmountField;

		private bool payment_AmountFieldSpecified;

		private decimal expected_Payment_AmountField;

		private bool expected_Payment_AmountFieldSpecified;

		private Student_Application_Payment_StatusObjectType student_Application_Payment_Status_ReferenceField;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private CurrencyObjectType[] currency_ReferenceField;

		private Student_Application_Decision_Published_StatusObjectType decision_Published_Status_ReferenceField;

		private Student_Document_Subedit_DataType[] student_Document_DataField;

		private Student_Application_SourceObjectType student_Application_Source_ReferenceField;

		private bool previous_College_AttendanceField;

		private bool previous_College_AttendanceFieldSpecified;

		private bool first_Generation_College_StudentField;

		private bool first_Generation_College_StudentFieldSpecified;

		private string application_IdentifierField;

		private bool attended_this_InstitutionField;

		private bool attended_this_InstitutionFieldSpecified;

		private bool legacyField;

		private bool legacyFieldSpecified;

		private bool criminal_HistoryField;

		private bool criminal_HistoryFieldSpecified;

		private string criminal_History_CommentsField;

		private bool academic_Disciplinary_HistoryField;

		private bool academic_Disciplinary_HistoryFieldSpecified;

		private string academic_Disciplinary_History_CommentsField;

		private Student_Application_Details_Post_Secondary_Subedit_DataType[] student_Application_Details_Post_Secondary_Education_DataField;

		private bool homeschooledField;

		private bool homeschooledFieldSpecified;

		private Student_Graduation_or_EquivalencyObjectType graduation_or_Equivalency_ReferenceField;

		private Student_Application_Details_Secondary_Education_Subedit_DataType[] student_Application_Details_Secondary_Education_DataField;

		private bool selective_ServiceField;

		private bool selective_ServiceFieldSpecified;

		private Veteran_Benefits_EligibilityObjectType veteran_Benefits_Eligibility_ReferenceField;

		private Student_Immigration_StatusObjectType intended_Immigration_Status_ReferenceField;

		private string immigration_IDField;

		private Student_Application_Details_Candidate_Skills_Subedit_DataType student_Application_Details_Candidate_Skills_DataField;

		private Student_Application_Recommender_Subedit_DataType[] student_Application_Recommender_DataField;

		private Admission_DecisionObjectType admission_Decision_ReferenceField;

		private Program_of_StudyObjectType[] admitted_Program_of_Study_ReferenceField;

		private Academic_UnitObjectType admitting_Academic_Unit_ReferenceField;

		private Academic_LevelObjectType admitting_Academic_Level_ReferenceField;

		private Admission_Decision_ReasonObjectType admission_Decision_Reason_ReferenceField;

		private DateTime decision_DateField;

		private bool decision_DateFieldSpecified;

		private string decision_CommentField;

		private string rendered_ByField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_ApplicationObjectType Student_Application_Reference
		{
			get
			{
				return this.student_Application_ReferenceField;
			}
			set
			{
				this.student_Application_ReferenceField = value;
				this.RaisePropertyChanged("Student_Application_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Active
		{
			get
			{
				return this.activeField;
			}
			set
			{
				this.activeField = value;
				this.RaisePropertyChanged("Active");
			}
		}

		[XmlIgnore]
		public bool ActiveSpecified
		{
			get
			{
				return this.activeFieldSpecified;
			}
			set
			{
				this.activeFieldSpecified = value;
				this.RaisePropertyChanged("ActiveSpecified");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public Student_Application_File_StatusObjectType Student_Application_File_Status_Reference
		{
			get
			{
				return this.student_Application_File_Status_ReferenceField;
			}
			set
			{
				this.student_Application_File_Status_ReferenceField = value;
				this.RaisePropertyChanged("Student_Application_File_Status_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Student_Application_Review_StatusObjectType Application_Review_Status_Reference
		{
			get
			{
				return this.application_Review_Status_ReferenceField;
			}
			set
			{
				this.application_Review_Status_ReferenceField = value;
				this.RaisePropertyChanged("Application_Review_Status_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Student_Applicant_TypeObjectType Student_Applicant_Type_Reference
		{
			get
			{
				return this.student_Applicant_Type_ReferenceField;
			}
			set
			{
				this.student_Applicant_Type_ReferenceField = value;
				this.RaisePropertyChanged("Student_Applicant_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Application_Date
		{
			get
			{
				return this.application_DateField;
			}
			set
			{
				this.application_DateField = value;
				this.RaisePropertyChanged("Application_Date");
			}
		}

		[XmlElement("Program_of_Study_Reference", Order = 7)]
		public Program_of_StudyObjectType[] Program_of_Study_Reference
		{
			get
			{
				return this.program_of_Study_ReferenceField;
			}
			set
			{
				this.program_of_Study_ReferenceField = value;
				this.RaisePropertyChanged("Program_of_Study_Reference");
			}
		}

		[XmlElement("Program_Focuses_Reference", Order = 8)]
		public Program_of_StudyObjectType[] Program_Focuses_Reference
		{
			get
			{
				return this.program_Focuses_ReferenceField;
			}
			set
			{
				this.program_Focuses_ReferenceField = value;
				this.RaisePropertyChanged("Program_Focuses_Reference");
			}
		}

		[XmlElement("Academic_Period_Data", Order = 9)]
		public Academic_Period_Subedit_DataType[] Academic_Period_Data
		{
			get
			{
				return this.academic_Period_DataField;
			}
			set
			{
				this.academic_Period_DataField = value;
				this.RaisePropertyChanged("Academic_Period_Data");
			}
		}

		[XmlElement(Order = 10)]
		public Student_Load_StatusObjectType Anticipated_Enrollment_Level_Reference
		{
			get
			{
				return this.anticipated_Enrollment_Level_ReferenceField;
			}
			set
			{
				this.anticipated_Enrollment_Level_ReferenceField = value;
				this.RaisePropertyChanged("Anticipated_Enrollment_Level_Reference");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement("Learning_Mode_Reference", Order = 12)]
		public Learning_ModeObjectType[] Learning_Mode_Reference
		{
			get
			{
				return this.learning_Mode_ReferenceField;
			}
			set
			{
				this.learning_Mode_ReferenceField = value;
				this.RaisePropertyChanged("Learning_Mode_Reference");
			}
		}

		[XmlElement("Student_Tags_Reference", Order = 13)]
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

		[XmlElement(DataType = "date", Order = 14)]
		public DateTime Payment_Date
		{
			get
			{
				return this.payment_DateField;
			}
			set
			{
				this.payment_DateField = value;
				this.RaisePropertyChanged("Payment_Date");
			}
		}

		[XmlIgnore]
		public bool Payment_DateSpecified
		{
			get
			{
				return this.payment_DateFieldSpecified;
			}
			set
			{
				this.payment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Payment_DateSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public decimal Payment_Amount
		{
			get
			{
				return this.payment_AmountField;
			}
			set
			{
				this.payment_AmountField = value;
				this.RaisePropertyChanged("Payment_Amount");
			}
		}

		[XmlIgnore]
		public bool Payment_AmountSpecified
		{
			get
			{
				return this.payment_AmountFieldSpecified;
			}
			set
			{
				this.payment_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Payment_AmountSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public decimal Expected_Payment_Amount
		{
			get
			{
				return this.expected_Payment_AmountField;
			}
			set
			{
				this.expected_Payment_AmountField = value;
				this.RaisePropertyChanged("Expected_Payment_Amount");
			}
		}

		[XmlIgnore]
		public bool Expected_Payment_AmountSpecified
		{
			get
			{
				return this.expected_Payment_AmountFieldSpecified;
			}
			set
			{
				this.expected_Payment_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Expected_Payment_AmountSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public Student_Application_Payment_StatusObjectType Student_Application_Payment_Status_Reference
		{
			get
			{
				return this.student_Application_Payment_Status_ReferenceField;
			}
			set
			{
				this.student_Application_Payment_Status_ReferenceField = value;
				this.RaisePropertyChanged("Student_Application_Payment_Status_Reference");
			}
		}

		[XmlElement(Order = 18)]
		public Payment_TypeObjectType Payment_Type_Reference
		{
			get
			{
				return this.payment_Type_ReferenceField;
			}
			set
			{
				this.payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Type_Reference");
			}
		}

		[XmlElement("Currency_Reference", Order = 19)]
		public CurrencyObjectType[] Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(Order = 20)]
		public Student_Application_Decision_Published_StatusObjectType Decision_Published_Status_Reference
		{
			get
			{
				return this.decision_Published_Status_ReferenceField;
			}
			set
			{
				this.decision_Published_Status_ReferenceField = value;
				this.RaisePropertyChanged("Decision_Published_Status_Reference");
			}
		}

		[XmlElement("Student_Document_Data", Order = 21)]
		public Student_Document_Subedit_DataType[] Student_Document_Data
		{
			get
			{
				return this.student_Document_DataField;
			}
			set
			{
				this.student_Document_DataField = value;
				this.RaisePropertyChanged("Student_Document_Data");
			}
		}

		[XmlElement(Order = 22)]
		public Student_Application_SourceObjectType Student_Application_Source_Reference
		{
			get
			{
				return this.student_Application_Source_ReferenceField;
			}
			set
			{
				this.student_Application_Source_ReferenceField = value;
				this.RaisePropertyChanged("Student_Application_Source_Reference");
			}
		}

		[XmlElement(Order = 23)]
		public bool Previous_College_Attendance
		{
			get
			{
				return this.previous_College_AttendanceField;
			}
			set
			{
				this.previous_College_AttendanceField = value;
				this.RaisePropertyChanged("Previous_College_Attendance");
			}
		}

		[XmlIgnore]
		public bool Previous_College_AttendanceSpecified
		{
			get
			{
				return this.previous_College_AttendanceFieldSpecified;
			}
			set
			{
				this.previous_College_AttendanceFieldSpecified = value;
				this.RaisePropertyChanged("Previous_College_AttendanceSpecified");
			}
		}

		[XmlElement(Order = 24)]
		public bool First_Generation_College_Student
		{
			get
			{
				return this.first_Generation_College_StudentField;
			}
			set
			{
				this.first_Generation_College_StudentField = value;
				this.RaisePropertyChanged("First_Generation_College_Student");
			}
		}

		[XmlIgnore]
		public bool First_Generation_College_StudentSpecified
		{
			get
			{
				return this.first_Generation_College_StudentFieldSpecified;
			}
			set
			{
				this.first_Generation_College_StudentFieldSpecified = value;
				this.RaisePropertyChanged("First_Generation_College_StudentSpecified");
			}
		}

		[XmlElement(Order = 25)]
		public string Application_Identifier
		{
			get
			{
				return this.application_IdentifierField;
			}
			set
			{
				this.application_IdentifierField = value;
				this.RaisePropertyChanged("Application_Identifier");
			}
		}

		[XmlElement(Order = 26)]
		public bool Attended_this_Institution
		{
			get
			{
				return this.attended_this_InstitutionField;
			}
			set
			{
				this.attended_this_InstitutionField = value;
				this.RaisePropertyChanged("Attended_this_Institution");
			}
		}

		[XmlIgnore]
		public bool Attended_this_InstitutionSpecified
		{
			get
			{
				return this.attended_this_InstitutionFieldSpecified;
			}
			set
			{
				this.attended_this_InstitutionFieldSpecified = value;
				this.RaisePropertyChanged("Attended_this_InstitutionSpecified");
			}
		}

		[XmlElement(Order = 27)]
		public bool Legacy
		{
			get
			{
				return this.legacyField;
			}
			set
			{
				this.legacyField = value;
				this.RaisePropertyChanged("Legacy");
			}
		}

		[XmlIgnore]
		public bool LegacySpecified
		{
			get
			{
				return this.legacyFieldSpecified;
			}
			set
			{
				this.legacyFieldSpecified = value;
				this.RaisePropertyChanged("LegacySpecified");
			}
		}

		[XmlElement(Order = 28)]
		public bool Criminal_History
		{
			get
			{
				return this.criminal_HistoryField;
			}
			set
			{
				this.criminal_HistoryField = value;
				this.RaisePropertyChanged("Criminal_History");
			}
		}

		[XmlIgnore]
		public bool Criminal_HistorySpecified
		{
			get
			{
				return this.criminal_HistoryFieldSpecified;
			}
			set
			{
				this.criminal_HistoryFieldSpecified = value;
				this.RaisePropertyChanged("Criminal_HistorySpecified");
			}
		}

		[XmlElement(Order = 29)]
		public string Criminal_History_Comments
		{
			get
			{
				return this.criminal_History_CommentsField;
			}
			set
			{
				this.criminal_History_CommentsField = value;
				this.RaisePropertyChanged("Criminal_History_Comments");
			}
		}

		[XmlElement(Order = 30)]
		public bool Academic_Disciplinary_History
		{
			get
			{
				return this.academic_Disciplinary_HistoryField;
			}
			set
			{
				this.academic_Disciplinary_HistoryField = value;
				this.RaisePropertyChanged("Academic_Disciplinary_History");
			}
		}

		[XmlIgnore]
		public bool Academic_Disciplinary_HistorySpecified
		{
			get
			{
				return this.academic_Disciplinary_HistoryFieldSpecified;
			}
			set
			{
				this.academic_Disciplinary_HistoryFieldSpecified = value;
				this.RaisePropertyChanged("Academic_Disciplinary_HistorySpecified");
			}
		}

		[XmlElement(Order = 31)]
		public string Academic_Disciplinary_History_Comments
		{
			get
			{
				return this.academic_Disciplinary_History_CommentsField;
			}
			set
			{
				this.academic_Disciplinary_History_CommentsField = value;
				this.RaisePropertyChanged("Academic_Disciplinary_History_Comments");
			}
		}

		[XmlElement("Student_Application_Details_Post_Secondary_Education_Data", Order = 32)]
		public Student_Application_Details_Post_Secondary_Subedit_DataType[] Student_Application_Details_Post_Secondary_Education_Data
		{
			get
			{
				return this.student_Application_Details_Post_Secondary_Education_DataField;
			}
			set
			{
				this.student_Application_Details_Post_Secondary_Education_DataField = value;
				this.RaisePropertyChanged("Student_Application_Details_Post_Secondary_Education_Data");
			}
		}

		[XmlElement(Order = 33)]
		public bool Homeschooled
		{
			get
			{
				return this.homeschooledField;
			}
			set
			{
				this.homeschooledField = value;
				this.RaisePropertyChanged("Homeschooled");
			}
		}

		[XmlIgnore]
		public bool HomeschooledSpecified
		{
			get
			{
				return this.homeschooledFieldSpecified;
			}
			set
			{
				this.homeschooledFieldSpecified = value;
				this.RaisePropertyChanged("HomeschooledSpecified");
			}
		}

		[XmlElement(Order = 34)]
		public Student_Graduation_or_EquivalencyObjectType Graduation_or_Equivalency_Reference
		{
			get
			{
				return this.graduation_or_Equivalency_ReferenceField;
			}
			set
			{
				this.graduation_or_Equivalency_ReferenceField = value;
				this.RaisePropertyChanged("Graduation_or_Equivalency_Reference");
			}
		}

		[XmlElement("Student_Application_Details_Secondary_Education_Data", Order = 35)]
		public Student_Application_Details_Secondary_Education_Subedit_DataType[] Student_Application_Details_Secondary_Education_Data
		{
			get
			{
				return this.student_Application_Details_Secondary_Education_DataField;
			}
			set
			{
				this.student_Application_Details_Secondary_Education_DataField = value;
				this.RaisePropertyChanged("Student_Application_Details_Secondary_Education_Data");
			}
		}

		[XmlElement(Order = 36)]
		public bool Selective_Service
		{
			get
			{
				return this.selective_ServiceField;
			}
			set
			{
				this.selective_ServiceField = value;
				this.RaisePropertyChanged("Selective_Service");
			}
		}

		[XmlIgnore]
		public bool Selective_ServiceSpecified
		{
			get
			{
				return this.selective_ServiceFieldSpecified;
			}
			set
			{
				this.selective_ServiceFieldSpecified = value;
				this.RaisePropertyChanged("Selective_ServiceSpecified");
			}
		}

		[XmlElement(Order = 37)]
		public Veteran_Benefits_EligibilityObjectType Veteran_Benefits_Eligibility_Reference
		{
			get
			{
				return this.veteran_Benefits_Eligibility_ReferenceField;
			}
			set
			{
				this.veteran_Benefits_Eligibility_ReferenceField = value;
				this.RaisePropertyChanged("Veteran_Benefits_Eligibility_Reference");
			}
		}

		[XmlElement(Order = 38)]
		public Student_Immigration_StatusObjectType Intended_Immigration_Status_Reference
		{
			get
			{
				return this.intended_Immigration_Status_ReferenceField;
			}
			set
			{
				this.intended_Immigration_Status_ReferenceField = value;
				this.RaisePropertyChanged("Intended_Immigration_Status_Reference");
			}
		}

		[XmlElement(Order = 39)]
		public string Immigration_ID
		{
			get
			{
				return this.immigration_IDField;
			}
			set
			{
				this.immigration_IDField = value;
				this.RaisePropertyChanged("Immigration_ID");
			}
		}

		[XmlElement(Order = 40)]
		public Student_Application_Details_Candidate_Skills_Subedit_DataType Student_Application_Details_Candidate_Skills_Data
		{
			get
			{
				return this.student_Application_Details_Candidate_Skills_DataField;
			}
			set
			{
				this.student_Application_Details_Candidate_Skills_DataField = value;
				this.RaisePropertyChanged("Student_Application_Details_Candidate_Skills_Data");
			}
		}

		[XmlElement("Student_Application_Recommender_Data", Order = 41)]
		public Student_Application_Recommender_Subedit_DataType[] Student_Application_Recommender_Data
		{
			get
			{
				return this.student_Application_Recommender_DataField;
			}
			set
			{
				this.student_Application_Recommender_DataField = value;
				this.RaisePropertyChanged("Student_Application_Recommender_Data");
			}
		}

		[XmlElement(Order = 42)]
		public Admission_DecisionObjectType Admission_Decision_Reference
		{
			get
			{
				return this.admission_Decision_ReferenceField;
			}
			set
			{
				this.admission_Decision_ReferenceField = value;
				this.RaisePropertyChanged("Admission_Decision_Reference");
			}
		}

		[XmlElement("Admitted_Program_of_Study_Reference", Order = 43)]
		public Program_of_StudyObjectType[] Admitted_Program_of_Study_Reference
		{
			get
			{
				return this.admitted_Program_of_Study_ReferenceField;
			}
			set
			{
				this.admitted_Program_of_Study_ReferenceField = value;
				this.RaisePropertyChanged("Admitted_Program_of_Study_Reference");
			}
		}

		[XmlElement(Order = 44)]
		public Academic_UnitObjectType Admitting_Academic_Unit_Reference
		{
			get
			{
				return this.admitting_Academic_Unit_ReferenceField;
			}
			set
			{
				this.admitting_Academic_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Admitting_Academic_Unit_Reference");
			}
		}

		[XmlElement(Order = 45)]
		public Academic_LevelObjectType Admitting_Academic_Level_Reference
		{
			get
			{
				return this.admitting_Academic_Level_ReferenceField;
			}
			set
			{
				this.admitting_Academic_Level_ReferenceField = value;
				this.RaisePropertyChanged("Admitting_Academic_Level_Reference");
			}
		}

		[XmlElement(Order = 46)]
		public Admission_Decision_ReasonObjectType Admission_Decision_Reason_Reference
		{
			get
			{
				return this.admission_Decision_Reason_ReferenceField;
			}
			set
			{
				this.admission_Decision_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Admission_Decision_Reason_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 47)]
		public DateTime Decision_Date
		{
			get
			{
				return this.decision_DateField;
			}
			set
			{
				this.decision_DateField = value;
				this.RaisePropertyChanged("Decision_Date");
			}
		}

		[XmlIgnore]
		public bool Decision_DateSpecified
		{
			get
			{
				return this.decision_DateFieldSpecified;
			}
			set
			{
				this.decision_DateFieldSpecified = value;
				this.RaisePropertyChanged("Decision_DateSpecified");
			}
		}

		[XmlElement(Order = 48)]
		public string Decision_Comment
		{
			get
			{
				return this.decision_CommentField;
			}
			set
			{
				this.decision_CommentField = value;
				this.RaisePropertyChanged("Decision_Comment");
			}
		}

		[XmlElement(Order = 49)]
		public string Rendered_By
		{
			get
			{
				return this.rendered_ByField;
			}
			set
			{
				this.rendered_ByField = value;
				this.RaisePropertyChanged("Rendered_By");
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
