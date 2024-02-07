using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Admissions
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Application_Data_W25Type : INotifyPropertyChanged
	{
		private string idField;

		private bool activeField;

		private bool activeFieldSpecified;

		private Student_Prospect_StageObjectType student_Prospect_Stage_ReferenceField;

		private Student_Applicant_TypeObjectType student_Applicant_Type_ReferenceField;

		private DateTime application_DateField;

		private Program_of_StudyObjectType[] program_of_Study_ReferenceField;

		private Program_of_StudyObjectType[] program_Focus_ReferenceField;

		private Academic_Period_Subedit_DataType[] academic_Period_DataField;

		private Student_Load_StatusObjectType anticipated_Load_Status_ReferenceField;

		private LocationObjectType location_ReferenceField;

		private Learning_ModeObjectType[] learning_Mode_ReferenceField;

		private Student_TagObjectType[] student_Tags_ReferenceField;

		private DateTime payment_DateField;

		private bool payment_DateFieldSpecified;

		private decimal payment_AmountField;

		private bool payment_AmountFieldSpecified;

		private Student_Application_Payment_StatusObjectType student_Application_Payment_Status_ReferenceField;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private CurrencyObjectType[] currency_ReferenceField;

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

		private bool homeschooledField;

		private bool homeschooledFieldSpecified;

		private Student_Graduation_or_EquivalencyObjectType graduation_or_Equivalency_ReferenceField;

		private Student_Application_Details_Secondary_Education_Subedit_DataType[] student_Application_Details_Secondary_Education_DataField;

		private Student_Application_Details_Post_Secondary_Subedit_DataType[] student_Application_Details_Post_Secondary_Education_DataField;

		private bool selective_ServiceField;

		private bool selective_ServiceFieldSpecified;

		private Veteran_Benefits_EligibilityObjectType veteran_Benefits_Eligibility_ReferenceField;

		private Student_Immigration_StatusObjectType intended_Immigration_Status_ReferenceField;

		private string immigration_IDField;

		private Student_Application_Details_Candidate_Skills_Subedit_DataType student_Application_Details_Candidate_Skills_DataField;

		private Student_Application_Recommender_Subedit_DataType[] student_Application_Recommender_DataField;

		private Student_Application_Prospect_DataType student_Prospect_DataField;

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

		[XmlElement(DataType = "date", Order = 4)]
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

		[XmlElement("Program_of_Study_Reference", Order = 5)]
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

		[XmlElement("Program_Focus_Reference", Order = 6)]
		public Program_of_StudyObjectType[] Program_Focus_Reference
		{
			get
			{
				return this.program_Focus_ReferenceField;
			}
			set
			{
				this.program_Focus_ReferenceField = value;
				this.RaisePropertyChanged("Program_Focus_Reference");
			}
		}

		[XmlElement("Academic_Period_Data", Order = 7)]
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

		[XmlElement(Order = 8)]
		public Student_Load_StatusObjectType Anticipated_Load_Status_Reference
		{
			get
			{
				return this.anticipated_Load_Status_ReferenceField;
			}
			set
			{
				this.anticipated_Load_Status_ReferenceField = value;
				this.RaisePropertyChanged("Anticipated_Load_Status_Reference");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement("Learning_Mode_Reference", Order = 10)]
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

		[XmlElement("Student_Tags_Reference", Order = 11)]
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

		[XmlElement(DataType = "date", Order = 12)]
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

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
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

		[XmlElement(Order = 15)]
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

		[XmlElement("Currency_Reference", Order = 16)]
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

		[XmlElement("Student_Document_Data", Order = 17)]
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

		[XmlElement(Order = 18)]
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

		[XmlElement(Order = 19)]
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

		[XmlElement(Order = 20)]
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

		[XmlElement(Order = 21)]
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

		[XmlElement(Order = 22)]
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

		[XmlElement(Order = 23)]
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

		[XmlElement(Order = 24)]
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

		[XmlElement(Order = 25)]
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

		[XmlElement(Order = 26)]
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

		[XmlElement(Order = 27)]
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

		[XmlElement(Order = 28)]
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

		[XmlElement(Order = 29)]
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

		[XmlElement("Student_Application_Details_Secondary_Education_Data", Order = 30)]
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

		[XmlElement("Student_Application_Details_Post_Secondary_Education_Data", Order = 31)]
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

		[XmlElement(Order = 32)]
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

		[XmlElement(Order = 33)]
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

		[XmlElement(Order = 34)]
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

		[XmlElement(Order = 35)]
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

		[XmlElement(Order = 36)]
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

		[XmlElement("Student_Application_Recommender_Data", Order = 37)]
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

		[XmlElement(Order = 38)]
		public Student_Application_Prospect_DataType Student_Prospect_Data
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
