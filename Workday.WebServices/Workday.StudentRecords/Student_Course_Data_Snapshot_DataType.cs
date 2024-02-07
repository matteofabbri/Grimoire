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
	public class Student_Course_Data_Snapshot_DataType : INotifyPropertyChanged
	{
		private DateTime effective_DateField;

		private string course_TitleField;

		private string abbreviated_TitleField;

		private bool special_Topics_CourseField;

		private bool special_Topics_CourseFieldSpecified;

		private Student_Course_Special_Topic_DataType[] special_Topic_DataField;

		private Student_Course_Listing_DataType[] student_Course_Listing_DataField;

		private Academic_LevelObjectType academic_Level_ReferenceField;

		private Student_Course_Academic_Unit_DataType[] academic_Unit_DataField;

		private bool other_Unit_ValuesField;

		private bool other_Unit_ValuesFieldSpecified;

		private Other_Credit_Type_Value_DataType[] other_Credit_Type_Value_DataField;

		private Academic_Period_TypeObjectType[] periods_Offered_ReferenceField;

		private Student_Grading_BasisObjectType[] default_Grading_Bases_ReferenceField;

		private LocationObjectType[] allowed_Locations_ReferenceField;

		private Other_Unit_TypeObjectType unit_Type_ReferenceField;

		private decimal minimum_UnitsField;

		private bool minimum_UnitsFieldSpecified;

		private decimal maximum_UnitsField;

		private bool maximum_UnitsFieldSpecified;

		private bool repeatableField;

		private bool repeatableFieldSpecified;

		private decimal repeat_Maximum_AttemptsField;

		private bool repeat_Maximum_AttemptsFieldSpecified;

		private decimal repeat_Maximum_UnitsField;

		private bool repeat_Maximum_UnitsFieldSpecified;

		private decimal contact_HoursField;

		private bool contact_HoursFieldSpecified;

		private Student_Course_Fees_DataType[] course_Fee_DataField;

		private Student_Additional_Fees_DataType[] additional_Fee_DataField;

		private Student_Fee_GroupObjectType student_Fee_Group_ReferenceField;

		private bool graded_AnonymouslyField;

		private bool graded_AnonymouslyFieldSpecified;

		private Student_Eligibility_RuleObjectType student_Eligibility_Rule_ReferenceField;

		private string student_Eligibility_Rule_NameField;

		private Course_DefinitionObjectType[] co_Requisite_Courses_ReferenceField;

		private string public_NotesField;

		private string private_NotesField;

		private bool hide_CourseField;

		private bool hide_CourseFieldSpecified;

		private bool unlimited_CapacityField;

		private bool unlimited_CapacityFieldSpecified;

		private decimal default_Section_CapacityField;

		private bool default_Section_CapacityFieldSpecified;

		private decimal default_Wait_List_CapacityField;

		private bool default_Wait_List_CapacityFieldSpecified;

		private decimal default_Projected_EnrollmentField;

		private bool default_Projected_EnrollmentFieldSpecified;

		private bool default_Manually_Manage_Waitlist_PromotionField;

		private bool default_Manually_Manage_Waitlist_PromotionFieldSpecified;

		private Learning_OutcomeObjectType[] learning_Outcome_ReferenceField;

		private CompetencyObjectType[] competencies_ReferenceField;

		private Student_Course_TagObjectType[] course_Tag_ReferenceField;

		private CIP_Code__Workday_Owned_ObjectType cIP_Code_ReferenceField;

		private Educational_Taxonomy_CodeObjectType[] educational_Taxonomy_Codes_ReferenceField;

		private string descriptionField;

		private Student_Course_Component_DataType[] student_Course_Component_DataField;

		private Student_Course_Combination_Instructional_Format_Contact_Hours_DataType[] course_Combination_Instructional_Format_Contact_Hours_DataField;

		private Course_Material_Course_Assignment_DataType[] course_Material_Course_Assignment_DataField;

		private bool section_Overrides_AllowedField;

		private bool section_Overrides_AllowedFieldSpecified;

		private bool auto_Generate_Section_NumbersField;

		private bool auto_Generate_Section_NumbersFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlElement(Order = 1)]
		public string Course_Title
		{
			get
			{
				return this.course_TitleField;
			}
			set
			{
				this.course_TitleField = value;
				this.RaisePropertyChanged("Course_Title");
			}
		}

		[XmlElement(Order = 2)]
		public string Abbreviated_Title
		{
			get
			{
				return this.abbreviated_TitleField;
			}
			set
			{
				this.abbreviated_TitleField = value;
				this.RaisePropertyChanged("Abbreviated_Title");
			}
		}

		[XmlElement(Order = 3)]
		public bool Special_Topics_Course
		{
			get
			{
				return this.special_Topics_CourseField;
			}
			set
			{
				this.special_Topics_CourseField = value;
				this.RaisePropertyChanged("Special_Topics_Course");
			}
		}

		[XmlIgnore]
		public bool Special_Topics_CourseSpecified
		{
			get
			{
				return this.special_Topics_CourseFieldSpecified;
			}
			set
			{
				this.special_Topics_CourseFieldSpecified = value;
				this.RaisePropertyChanged("Special_Topics_CourseSpecified");
			}
		}

		[XmlElement("Special_Topic_Data", Order = 4)]
		public Student_Course_Special_Topic_DataType[] Special_Topic_Data
		{
			get
			{
				return this.special_Topic_DataField;
			}
			set
			{
				this.special_Topic_DataField = value;
				this.RaisePropertyChanged("Special_Topic_Data");
			}
		}

		[XmlElement("Student_Course_Listing_Data", Order = 5)]
		public Student_Course_Listing_DataType[] Student_Course_Listing_Data
		{
			get
			{
				return this.student_Course_Listing_DataField;
			}
			set
			{
				this.student_Course_Listing_DataField = value;
				this.RaisePropertyChanged("Student_Course_Listing_Data");
			}
		}

		[XmlElement(Order = 6)]
		public Academic_LevelObjectType Academic_Level_Reference
		{
			get
			{
				return this.academic_Level_ReferenceField;
			}
			set
			{
				this.academic_Level_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Level_Reference");
			}
		}

		[XmlElement("Academic_Unit_Data", Order = 7)]
		public Student_Course_Academic_Unit_DataType[] Academic_Unit_Data
		{
			get
			{
				return this.academic_Unit_DataField;
			}
			set
			{
				this.academic_Unit_DataField = value;
				this.RaisePropertyChanged("Academic_Unit_Data");
			}
		}

		[XmlElement(Order = 8)]
		public bool Other_Unit_Values
		{
			get
			{
				return this.other_Unit_ValuesField;
			}
			set
			{
				this.other_Unit_ValuesField = value;
				this.RaisePropertyChanged("Other_Unit_Values");
			}
		}

		[XmlIgnore]
		public bool Other_Unit_ValuesSpecified
		{
			get
			{
				return this.other_Unit_ValuesFieldSpecified;
			}
			set
			{
				this.other_Unit_ValuesFieldSpecified = value;
				this.RaisePropertyChanged("Other_Unit_ValuesSpecified");
			}
		}

		[XmlElement("Other_Credit_Type_Value_Data", Order = 9)]
		public Other_Credit_Type_Value_DataType[] Other_Credit_Type_Value_Data
		{
			get
			{
				return this.other_Credit_Type_Value_DataField;
			}
			set
			{
				this.other_Credit_Type_Value_DataField = value;
				this.RaisePropertyChanged("Other_Credit_Type_Value_Data");
			}
		}

		[XmlElement("Periods_Offered_Reference", Order = 10)]
		public Academic_Period_TypeObjectType[] Periods_Offered_Reference
		{
			get
			{
				return this.periods_Offered_ReferenceField;
			}
			set
			{
				this.periods_Offered_ReferenceField = value;
				this.RaisePropertyChanged("Periods_Offered_Reference");
			}
		}

		[XmlElement("Default_Grading_Bases_Reference", Order = 11)]
		public Student_Grading_BasisObjectType[] Default_Grading_Bases_Reference
		{
			get
			{
				return this.default_Grading_Bases_ReferenceField;
			}
			set
			{
				this.default_Grading_Bases_ReferenceField = value;
				this.RaisePropertyChanged("Default_Grading_Bases_Reference");
			}
		}

		[XmlElement("Allowed_Locations_Reference", Order = 12)]
		public LocationObjectType[] Allowed_Locations_Reference
		{
			get
			{
				return this.allowed_Locations_ReferenceField;
			}
			set
			{
				this.allowed_Locations_ReferenceField = value;
				this.RaisePropertyChanged("Allowed_Locations_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public Other_Unit_TypeObjectType Unit_Type_Reference
		{
			get
			{
				return this.unit_Type_ReferenceField;
			}
			set
			{
				this.unit_Type_ReferenceField = value;
				this.RaisePropertyChanged("Unit_Type_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Minimum_Units
		{
			get
			{
				return this.minimum_UnitsField;
			}
			set
			{
				this.minimum_UnitsField = value;
				this.RaisePropertyChanged("Minimum_Units");
			}
		}

		[XmlIgnore]
		public bool Minimum_UnitsSpecified
		{
			get
			{
				return this.minimum_UnitsFieldSpecified;
			}
			set
			{
				this.minimum_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Minimum_UnitsSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public decimal Maximum_Units
		{
			get
			{
				return this.maximum_UnitsField;
			}
			set
			{
				this.maximum_UnitsField = value;
				this.RaisePropertyChanged("Maximum_Units");
			}
		}

		[XmlIgnore]
		public bool Maximum_UnitsSpecified
		{
			get
			{
				return this.maximum_UnitsFieldSpecified;
			}
			set
			{
				this.maximum_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Maximum_UnitsSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public bool Repeatable
		{
			get
			{
				return this.repeatableField;
			}
			set
			{
				this.repeatableField = value;
				this.RaisePropertyChanged("Repeatable");
			}
		}

		[XmlIgnore]
		public bool RepeatableSpecified
		{
			get
			{
				return this.repeatableFieldSpecified;
			}
			set
			{
				this.repeatableFieldSpecified = value;
				this.RaisePropertyChanged("RepeatableSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public decimal Repeat_Maximum_Attempts
		{
			get
			{
				return this.repeat_Maximum_AttemptsField;
			}
			set
			{
				this.repeat_Maximum_AttemptsField = value;
				this.RaisePropertyChanged("Repeat_Maximum_Attempts");
			}
		}

		[XmlIgnore]
		public bool Repeat_Maximum_AttemptsSpecified
		{
			get
			{
				return this.repeat_Maximum_AttemptsFieldSpecified;
			}
			set
			{
				this.repeat_Maximum_AttemptsFieldSpecified = value;
				this.RaisePropertyChanged("Repeat_Maximum_AttemptsSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public decimal Repeat_Maximum_Units
		{
			get
			{
				return this.repeat_Maximum_UnitsField;
			}
			set
			{
				this.repeat_Maximum_UnitsField = value;
				this.RaisePropertyChanged("Repeat_Maximum_Units");
			}
		}

		[XmlIgnore]
		public bool Repeat_Maximum_UnitsSpecified
		{
			get
			{
				return this.repeat_Maximum_UnitsFieldSpecified;
			}
			set
			{
				this.repeat_Maximum_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Repeat_Maximum_UnitsSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public decimal Contact_Hours
		{
			get
			{
				return this.contact_HoursField;
			}
			set
			{
				this.contact_HoursField = value;
				this.RaisePropertyChanged("Contact_Hours");
			}
		}

		[XmlIgnore]
		public bool Contact_HoursSpecified
		{
			get
			{
				return this.contact_HoursFieldSpecified;
			}
			set
			{
				this.contact_HoursFieldSpecified = value;
				this.RaisePropertyChanged("Contact_HoursSpecified");
			}
		}

		[XmlElement("Course_Fee_Data", Order = 20)]
		public Student_Course_Fees_DataType[] Course_Fee_Data
		{
			get
			{
				return this.course_Fee_DataField;
			}
			set
			{
				this.course_Fee_DataField = value;
				this.RaisePropertyChanged("Course_Fee_Data");
			}
		}

		[XmlElement("Additional_Fee_Data", Order = 21)]
		public Student_Additional_Fees_DataType[] Additional_Fee_Data
		{
			get
			{
				return this.additional_Fee_DataField;
			}
			set
			{
				this.additional_Fee_DataField = value;
				this.RaisePropertyChanged("Additional_Fee_Data");
			}
		}

		[XmlElement(Order = 22)]
		public Student_Fee_GroupObjectType Student_Fee_Group_Reference
		{
			get
			{
				return this.student_Fee_Group_ReferenceField;
			}
			set
			{
				this.student_Fee_Group_ReferenceField = value;
				this.RaisePropertyChanged("Student_Fee_Group_Reference");
			}
		}

		[XmlElement(Order = 23)]
		public bool Graded_Anonymously
		{
			get
			{
				return this.graded_AnonymouslyField;
			}
			set
			{
				this.graded_AnonymouslyField = value;
				this.RaisePropertyChanged("Graded_Anonymously");
			}
		}

		[XmlIgnore]
		public bool Graded_AnonymouslySpecified
		{
			get
			{
				return this.graded_AnonymouslyFieldSpecified;
			}
			set
			{
				this.graded_AnonymouslyFieldSpecified = value;
				this.RaisePropertyChanged("Graded_AnonymouslySpecified");
			}
		}

		[XmlElement(Order = 24)]
		public Student_Eligibility_RuleObjectType Student_Eligibility_Rule_Reference
		{
			get
			{
				return this.student_Eligibility_Rule_ReferenceField;
			}
			set
			{
				this.student_Eligibility_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Student_Eligibility_Rule_Reference");
			}
		}

		[XmlElement(Order = 25)]
		public string Student_Eligibility_Rule_Name
		{
			get
			{
				return this.student_Eligibility_Rule_NameField;
			}
			set
			{
				this.student_Eligibility_Rule_NameField = value;
				this.RaisePropertyChanged("Student_Eligibility_Rule_Name");
			}
		}

		[XmlElement("Co_Requisite_Courses_Reference", Order = 26)]
		public Course_DefinitionObjectType[] Co_Requisite_Courses_Reference
		{
			get
			{
				return this.co_Requisite_Courses_ReferenceField;
			}
			set
			{
				this.co_Requisite_Courses_ReferenceField = value;
				this.RaisePropertyChanged("Co_Requisite_Courses_Reference");
			}
		}

		[XmlElement(Order = 27)]
		public string Public_Notes
		{
			get
			{
				return this.public_NotesField;
			}
			set
			{
				this.public_NotesField = value;
				this.RaisePropertyChanged("Public_Notes");
			}
		}

		[XmlElement(Order = 28)]
		public string Private_Notes
		{
			get
			{
				return this.private_NotesField;
			}
			set
			{
				this.private_NotesField = value;
				this.RaisePropertyChanged("Private_Notes");
			}
		}

		[XmlElement(Order = 29)]
		public bool Hide_Course
		{
			get
			{
				return this.hide_CourseField;
			}
			set
			{
				this.hide_CourseField = value;
				this.RaisePropertyChanged("Hide_Course");
			}
		}

		[XmlIgnore]
		public bool Hide_CourseSpecified
		{
			get
			{
				return this.hide_CourseFieldSpecified;
			}
			set
			{
				this.hide_CourseFieldSpecified = value;
				this.RaisePropertyChanged("Hide_CourseSpecified");
			}
		}

		[XmlElement(Order = 30)]
		public bool Unlimited_Capacity
		{
			get
			{
				return this.unlimited_CapacityField;
			}
			set
			{
				this.unlimited_CapacityField = value;
				this.RaisePropertyChanged("Unlimited_Capacity");
			}
		}

		[XmlIgnore]
		public bool Unlimited_CapacitySpecified
		{
			get
			{
				return this.unlimited_CapacityFieldSpecified;
			}
			set
			{
				this.unlimited_CapacityFieldSpecified = value;
				this.RaisePropertyChanged("Unlimited_CapacitySpecified");
			}
		}

		[XmlElement(Order = 31)]
		public decimal Default_Section_Capacity
		{
			get
			{
				return this.default_Section_CapacityField;
			}
			set
			{
				this.default_Section_CapacityField = value;
				this.RaisePropertyChanged("Default_Section_Capacity");
			}
		}

		[XmlIgnore]
		public bool Default_Section_CapacitySpecified
		{
			get
			{
				return this.default_Section_CapacityFieldSpecified;
			}
			set
			{
				this.default_Section_CapacityFieldSpecified = value;
				this.RaisePropertyChanged("Default_Section_CapacitySpecified");
			}
		}

		[XmlElement(Order = 32)]
		public decimal Default_Wait_List_Capacity
		{
			get
			{
				return this.default_Wait_List_CapacityField;
			}
			set
			{
				this.default_Wait_List_CapacityField = value;
				this.RaisePropertyChanged("Default_Wait_List_Capacity");
			}
		}

		[XmlIgnore]
		public bool Default_Wait_List_CapacitySpecified
		{
			get
			{
				return this.default_Wait_List_CapacityFieldSpecified;
			}
			set
			{
				this.default_Wait_List_CapacityFieldSpecified = value;
				this.RaisePropertyChanged("Default_Wait_List_CapacitySpecified");
			}
		}

		[XmlElement(Order = 33)]
		public decimal Default_Projected_Enrollment
		{
			get
			{
				return this.default_Projected_EnrollmentField;
			}
			set
			{
				this.default_Projected_EnrollmentField = value;
				this.RaisePropertyChanged("Default_Projected_Enrollment");
			}
		}

		[XmlIgnore]
		public bool Default_Projected_EnrollmentSpecified
		{
			get
			{
				return this.default_Projected_EnrollmentFieldSpecified;
			}
			set
			{
				this.default_Projected_EnrollmentFieldSpecified = value;
				this.RaisePropertyChanged("Default_Projected_EnrollmentSpecified");
			}
		}

		[XmlElement(Order = 34)]
		public bool Default_Manually_Manage_Waitlist_Promotion
		{
			get
			{
				return this.default_Manually_Manage_Waitlist_PromotionField;
			}
			set
			{
				this.default_Manually_Manage_Waitlist_PromotionField = value;
				this.RaisePropertyChanged("Default_Manually_Manage_Waitlist_Promotion");
			}
		}

		[XmlIgnore]
		public bool Default_Manually_Manage_Waitlist_PromotionSpecified
		{
			get
			{
				return this.default_Manually_Manage_Waitlist_PromotionFieldSpecified;
			}
			set
			{
				this.default_Manually_Manage_Waitlist_PromotionFieldSpecified = value;
				this.RaisePropertyChanged("Default_Manually_Manage_Waitlist_PromotionSpecified");
			}
		}

		[XmlElement("Learning_Outcome_Reference", Order = 35)]
		public Learning_OutcomeObjectType[] Learning_Outcome_Reference
		{
			get
			{
				return this.learning_Outcome_ReferenceField;
			}
			set
			{
				this.learning_Outcome_ReferenceField = value;
				this.RaisePropertyChanged("Learning_Outcome_Reference");
			}
		}

		[XmlElement("Competencies_Reference", Order = 36)]
		public CompetencyObjectType[] Competencies_Reference
		{
			get
			{
				return this.competencies_ReferenceField;
			}
			set
			{
				this.competencies_ReferenceField = value;
				this.RaisePropertyChanged("Competencies_Reference");
			}
		}

		[XmlElement("Course_Tag_Reference", Order = 37)]
		public Student_Course_TagObjectType[] Course_Tag_Reference
		{
			get
			{
				return this.course_Tag_ReferenceField;
			}
			set
			{
				this.course_Tag_ReferenceField = value;
				this.RaisePropertyChanged("Course_Tag_Reference");
			}
		}

		[XmlElement(Order = 38)]
		public CIP_Code__Workday_Owned_ObjectType CIP_Code_Reference
		{
			get
			{
				return this.cIP_Code_ReferenceField;
			}
			set
			{
				this.cIP_Code_ReferenceField = value;
				this.RaisePropertyChanged("CIP_Code_Reference");
			}
		}

		[XmlElement("Educational_Taxonomy_Codes_Reference", Order = 39)]
		public Educational_Taxonomy_CodeObjectType[] Educational_Taxonomy_Codes_Reference
		{
			get
			{
				return this.educational_Taxonomy_Codes_ReferenceField;
			}
			set
			{
				this.educational_Taxonomy_Codes_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Taxonomy_Codes_Reference");
			}
		}

		[XmlElement(Order = 40)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement("Student_Course_Component_Data", Order = 41)]
		public Student_Course_Component_DataType[] Student_Course_Component_Data
		{
			get
			{
				return this.student_Course_Component_DataField;
			}
			set
			{
				this.student_Course_Component_DataField = value;
				this.RaisePropertyChanged("Student_Course_Component_Data");
			}
		}

		[XmlElement("Course_Combination_Instructional_Format_Contact_Hours_Data", Order = 42)]
		public Student_Course_Combination_Instructional_Format_Contact_Hours_DataType[] Course_Combination_Instructional_Format_Contact_Hours_Data
		{
			get
			{
				return this.course_Combination_Instructional_Format_Contact_Hours_DataField;
			}
			set
			{
				this.course_Combination_Instructional_Format_Contact_Hours_DataField = value;
				this.RaisePropertyChanged("Course_Combination_Instructional_Format_Contact_Hours_Data");
			}
		}

		[XmlElement("Course_Material_Course_Assignment_Data", Order = 43)]
		public Course_Material_Course_Assignment_DataType[] Course_Material_Course_Assignment_Data
		{
			get
			{
				return this.course_Material_Course_Assignment_DataField;
			}
			set
			{
				this.course_Material_Course_Assignment_DataField = value;
				this.RaisePropertyChanged("Course_Material_Course_Assignment_Data");
			}
		}

		[XmlElement(Order = 44)]
		public bool Section_Overrides_Allowed
		{
			get
			{
				return this.section_Overrides_AllowedField;
			}
			set
			{
				this.section_Overrides_AllowedField = value;
				this.RaisePropertyChanged("Section_Overrides_Allowed");
			}
		}

		[XmlIgnore]
		public bool Section_Overrides_AllowedSpecified
		{
			get
			{
				return this.section_Overrides_AllowedFieldSpecified;
			}
			set
			{
				this.section_Overrides_AllowedFieldSpecified = value;
				this.RaisePropertyChanged("Section_Overrides_AllowedSpecified");
			}
		}

		[XmlElement(Order = 45)]
		public bool Auto_Generate_Section_Numbers
		{
			get
			{
				return this.auto_Generate_Section_NumbersField;
			}
			set
			{
				this.auto_Generate_Section_NumbersField = value;
				this.RaisePropertyChanged("Auto_Generate_Section_Numbers");
			}
		}

		[XmlIgnore]
		public bool Auto_Generate_Section_NumbersSpecified
		{
			get
			{
				return this.auto_Generate_Section_NumbersFieldSpecified;
			}
			set
			{
				this.auto_Generate_Section_NumbersFieldSpecified = value;
				this.RaisePropertyChanged("Auto_Generate_Section_NumbersSpecified");
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
