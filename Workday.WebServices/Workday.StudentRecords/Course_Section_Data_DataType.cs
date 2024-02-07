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
	public class Course_Section_Data_DataType : INotifyPropertyChanged
	{
		private Course_Section_Academic_Unit_DataType[] course_Section_Academic_Unit_DataField;

		private Section_Listing_DataType[] section_Listing_DataField;

		private Academic_PeriodObjectType academic_Period_ReferenceField;

		private DateTime start_DateField;

		private DateTime end_DateField;

		private Instructional_FormatObjectType instructional_Format_ReferenceField;

		private Course_Section_Combination_Instructional_Format_Contact_Hours_DataType[] course_Section_Combination_Instructional_Format_Contact_Hours_DataField;

		private Delivery_ModeObjectType delivery_Mode_ReferenceField;

		private string titleField;

		private string abbreviated_TitleField;

		private Student_Course_Special_TopicObjectType special_Topic_ReferenceField;

		private CIP_Code__Workday_Owned_ObjectType cIP_Code_ReferenceField;

		private Educational_Taxonomy_CodeObjectType[] educational_Taxonomy_Code_ReferenceField;

		private Other_Unit_TypeObjectType unit_Type_ReferenceField;

		private decimal minimum_UnitsField;

		private bool minimum_UnitsFieldSpecified;

		private decimal maximum_UnitsField;

		private bool maximum_UnitsFieldSpecified;

		private decimal contact_HoursField;

		private bool contact_HoursFieldSpecified;

		private Student_Course_Fees_DataType[] course_Fee_DataField;

		private Student_Additional_Fees_DataType[] additional_Fee_DataField;

		private Student_Fee_GroupObjectType student_Fee_Group_ReferenceField;

		private Student_Grading_BasisObjectType[] grading_Basis_ReferenceField;

		private bool graded_AnonymouslyField;

		private bool graded_AnonymouslyFieldSpecified;

		private bool unlimited_CapacityField;

		private bool unlimited_CapacityFieldSpecified;

		private decimal section_CapacityField;

		private bool section_CapacityFieldSpecified;

		private decimal wait_List_CapacityField;

		private bool wait_List_CapacityFieldSpecified;

		private decimal reserved_CapacityField;

		private bool reserved_CapacityFieldSpecified;

		private decimal projected_EnrollmentField;

		private bool projected_EnrollmentFieldSpecified;

		private bool manually_Manage_Waitlist_PromotionField;

		private bool manually_Manage_Waitlist_PromotionFieldSpecified;

		private Student_Course_TagObjectType[] course_Tag_ReferenceField;

		private Learning_OutcomeObjectType[] learning_Outcome_ReferenceField;

		private CompetencyObjectType[] competency_ReferenceField;

		private bool not_VisibleField;

		private bool not_VisibleFieldSpecified;

		private string descriptionField;

		private string private_NotesField;

		private string public_NotesField;

		private bool other_Credit_ValuesField;

		private bool other_Credit_ValuesFieldSpecified;

		private Assignable_RoleObjectType[] published_Instructor_Roles_ReferenceField;

		private Course_Section_Other_Credit_Type_Value_DataType[] other_Credit_Type_Value_DataField;

		private bool override_Meeting_PatternField;

		private bool override_Meeting_PatternFieldSpecified;

		private Instructor_Role_Assignment_DataType[] instructor_Role_Assignment_DataField;

		private Section_Component_DataType[] section_Component_DataField;

		private Course_Material_Section_Assignment_DataType[] course_Material_Section_Assignment_DataField;

		private Student_Eligibility_RuleObjectType student_Eligibility_Rule_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Course_Section_Academic_Unit_Data", Order = 0)]
		public Course_Section_Academic_Unit_DataType[] Course_Section_Academic_Unit_Data
		{
			get
			{
				return this.course_Section_Academic_Unit_DataField;
			}
			set
			{
				this.course_Section_Academic_Unit_DataField = value;
				this.RaisePropertyChanged("Course_Section_Academic_Unit_Data");
			}
		}

		[XmlElement("Section_Listing_Data", Order = 1)]
		public Section_Listing_DataType[] Section_Listing_Data
		{
			get
			{
				return this.section_Listing_DataField;
			}
			set
			{
				this.section_Listing_DataField = value;
				this.RaisePropertyChanged("Section_Listing_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Academic_PeriodObjectType Academic_Period_Reference
		{
			get
			{
				return this.academic_Period_ReferenceField;
			}
			set
			{
				this.academic_Period_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Period_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
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

		[XmlElement(DataType = "date", Order = 4)]
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

		[XmlElement(Order = 5)]
		public Instructional_FormatObjectType Instructional_Format_Reference
		{
			get
			{
				return this.instructional_Format_ReferenceField;
			}
			set
			{
				this.instructional_Format_ReferenceField = value;
				this.RaisePropertyChanged("Instructional_Format_Reference");
			}
		}

		[XmlElement("Course_Section_Combination_Instructional_Format_Contact_Hours_Data", Order = 6)]
		public Course_Section_Combination_Instructional_Format_Contact_Hours_DataType[] Course_Section_Combination_Instructional_Format_Contact_Hours_Data
		{
			get
			{
				return this.course_Section_Combination_Instructional_Format_Contact_Hours_DataField;
			}
			set
			{
				this.course_Section_Combination_Instructional_Format_Contact_Hours_DataField = value;
				this.RaisePropertyChanged("Course_Section_Combination_Instructional_Format_Contact_Hours_Data");
			}
		}

		[XmlElement(Order = 7)]
		public Delivery_ModeObjectType Delivery_Mode_Reference
		{
			get
			{
				return this.delivery_Mode_ReferenceField;
			}
			set
			{
				this.delivery_Mode_ReferenceField = value;
				this.RaisePropertyChanged("Delivery_Mode_Reference");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public Student_Course_Special_TopicObjectType Special_Topic_Reference
		{
			get
			{
				return this.special_Topic_ReferenceField;
			}
			set
			{
				this.special_Topic_ReferenceField = value;
				this.RaisePropertyChanged("Special_Topic_Reference");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement("Educational_Taxonomy_Code_Reference", Order = 12)]
		public Educational_Taxonomy_CodeObjectType[] Educational_Taxonomy_Code_Reference
		{
			get
			{
				return this.educational_Taxonomy_Code_ReferenceField;
			}
			set
			{
				this.educational_Taxonomy_Code_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Taxonomy_Code_Reference");
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

		[XmlElement("Course_Fee_Data", Order = 17)]
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

		[XmlElement("Additional_Fee_Data", Order = 18)]
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

		[XmlElement(Order = 19)]
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

		[XmlElement("Grading_Basis_Reference", Order = 20)]
		public Student_Grading_BasisObjectType[] Grading_Basis_Reference
		{
			get
			{
				return this.grading_Basis_ReferenceField;
			}
			set
			{
				this.grading_Basis_ReferenceField = value;
				this.RaisePropertyChanged("Grading_Basis_Reference");
			}
		}

		[XmlElement(Order = 21)]
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

		[XmlElement(Order = 22)]
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

		[XmlElement(Order = 23)]
		public decimal Section_Capacity
		{
			get
			{
				return this.section_CapacityField;
			}
			set
			{
				this.section_CapacityField = value;
				this.RaisePropertyChanged("Section_Capacity");
			}
		}

		[XmlIgnore]
		public bool Section_CapacitySpecified
		{
			get
			{
				return this.section_CapacityFieldSpecified;
			}
			set
			{
				this.section_CapacityFieldSpecified = value;
				this.RaisePropertyChanged("Section_CapacitySpecified");
			}
		}

		[XmlElement(Order = 24)]
		public decimal Wait_List_Capacity
		{
			get
			{
				return this.wait_List_CapacityField;
			}
			set
			{
				this.wait_List_CapacityField = value;
				this.RaisePropertyChanged("Wait_List_Capacity");
			}
		}

		[XmlIgnore]
		public bool Wait_List_CapacitySpecified
		{
			get
			{
				return this.wait_List_CapacityFieldSpecified;
			}
			set
			{
				this.wait_List_CapacityFieldSpecified = value;
				this.RaisePropertyChanged("Wait_List_CapacitySpecified");
			}
		}

		[XmlElement(Order = 25)]
		public decimal Reserved_Capacity
		{
			get
			{
				return this.reserved_CapacityField;
			}
			set
			{
				this.reserved_CapacityField = value;
				this.RaisePropertyChanged("Reserved_Capacity");
			}
		}

		[XmlIgnore]
		public bool Reserved_CapacitySpecified
		{
			get
			{
				return this.reserved_CapacityFieldSpecified;
			}
			set
			{
				this.reserved_CapacityFieldSpecified = value;
				this.RaisePropertyChanged("Reserved_CapacitySpecified");
			}
		}

		[XmlElement(Order = 26)]
		public decimal Projected_Enrollment
		{
			get
			{
				return this.projected_EnrollmentField;
			}
			set
			{
				this.projected_EnrollmentField = value;
				this.RaisePropertyChanged("Projected_Enrollment");
			}
		}

		[XmlIgnore]
		public bool Projected_EnrollmentSpecified
		{
			get
			{
				return this.projected_EnrollmentFieldSpecified;
			}
			set
			{
				this.projected_EnrollmentFieldSpecified = value;
				this.RaisePropertyChanged("Projected_EnrollmentSpecified");
			}
		}

		[XmlElement(Order = 27)]
		public bool Manually_Manage_Waitlist_Promotion
		{
			get
			{
				return this.manually_Manage_Waitlist_PromotionField;
			}
			set
			{
				this.manually_Manage_Waitlist_PromotionField = value;
				this.RaisePropertyChanged("Manually_Manage_Waitlist_Promotion");
			}
		}

		[XmlIgnore]
		public bool Manually_Manage_Waitlist_PromotionSpecified
		{
			get
			{
				return this.manually_Manage_Waitlist_PromotionFieldSpecified;
			}
			set
			{
				this.manually_Manage_Waitlist_PromotionFieldSpecified = value;
				this.RaisePropertyChanged("Manually_Manage_Waitlist_PromotionSpecified");
			}
		}

		[XmlElement("Course_Tag_Reference", Order = 28)]
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

		[XmlElement("Learning_Outcome_Reference", Order = 29)]
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

		[XmlElement("Competency_Reference", Order = 30)]
		public CompetencyObjectType[] Competency_Reference
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

		[XmlElement(Order = 31)]
		public bool Not_Visible
		{
			get
			{
				return this.not_VisibleField;
			}
			set
			{
				this.not_VisibleField = value;
				this.RaisePropertyChanged("Not_Visible");
			}
		}

		[XmlIgnore]
		public bool Not_VisibleSpecified
		{
			get
			{
				return this.not_VisibleFieldSpecified;
			}
			set
			{
				this.not_VisibleFieldSpecified = value;
				this.RaisePropertyChanged("Not_VisibleSpecified");
			}
		}

		[XmlElement(Order = 32)]
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

		[XmlElement(Order = 33)]
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

		[XmlElement(Order = 34)]
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

		[XmlElement(Order = 35)]
		public bool Other_Credit_Values
		{
			get
			{
				return this.other_Credit_ValuesField;
			}
			set
			{
				this.other_Credit_ValuesField = value;
				this.RaisePropertyChanged("Other_Credit_Values");
			}
		}

		[XmlIgnore]
		public bool Other_Credit_ValuesSpecified
		{
			get
			{
				return this.other_Credit_ValuesFieldSpecified;
			}
			set
			{
				this.other_Credit_ValuesFieldSpecified = value;
				this.RaisePropertyChanged("Other_Credit_ValuesSpecified");
			}
		}

		[XmlElement("Published_Instructor_Roles_Reference", Order = 36)]
		public Assignable_RoleObjectType[] Published_Instructor_Roles_Reference
		{
			get
			{
				return this.published_Instructor_Roles_ReferenceField;
			}
			set
			{
				this.published_Instructor_Roles_ReferenceField = value;
				this.RaisePropertyChanged("Published_Instructor_Roles_Reference");
			}
		}

		[XmlElement("Other_Credit_Type_Value_Data", Order = 37)]
		public Course_Section_Other_Credit_Type_Value_DataType[] Other_Credit_Type_Value_Data
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

		[XmlElement(Order = 38)]
		public bool Override_Meeting_Pattern
		{
			get
			{
				return this.override_Meeting_PatternField;
			}
			set
			{
				this.override_Meeting_PatternField = value;
				this.RaisePropertyChanged("Override_Meeting_Pattern");
			}
		}

		[XmlIgnore]
		public bool Override_Meeting_PatternSpecified
		{
			get
			{
				return this.override_Meeting_PatternFieldSpecified;
			}
			set
			{
				this.override_Meeting_PatternFieldSpecified = value;
				this.RaisePropertyChanged("Override_Meeting_PatternSpecified");
			}
		}

		[XmlElement("Instructor_Role_Assignment_Data", Order = 39)]
		public Instructor_Role_Assignment_DataType[] Instructor_Role_Assignment_Data
		{
			get
			{
				return this.instructor_Role_Assignment_DataField;
			}
			set
			{
				this.instructor_Role_Assignment_DataField = value;
				this.RaisePropertyChanged("Instructor_Role_Assignment_Data");
			}
		}

		[XmlElement("Section_Component_Data", Order = 40)]
		public Section_Component_DataType[] Section_Component_Data
		{
			get
			{
				return this.section_Component_DataField;
			}
			set
			{
				this.section_Component_DataField = value;
				this.RaisePropertyChanged("Section_Component_Data");
			}
		}

		[XmlElement("Course_Material_Section_Assignment_Data", Order = 41)]
		public Course_Material_Section_Assignment_DataType[] Course_Material_Section_Assignment_Data
		{
			get
			{
				return this.course_Material_Section_Assignment_DataField;
			}
			set
			{
				this.course_Material_Section_Assignment_DataField = value;
				this.RaisePropertyChanged("Course_Material_Section_Assignment_Data");
			}
		}

		[XmlElement(Order = 42)]
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
