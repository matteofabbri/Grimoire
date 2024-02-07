using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Student_Records", ConfigurationName = "StudentRecords.Student_RecordsPort")]
	public interface Student_RecordsPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Meeting_Day_PatternsOutput Get_Meeting_Day_Patterns(Get_Meeting_Day_PatternsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Meeting_Day_PatternsOutput> Get_Meeting_Day_PatternsAsync(Get_Meeting_Day_PatternsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Meeting_Day_PatternOutput Put_Meeting_Day_Pattern(Put_Meeting_Day_PatternInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Meeting_Day_PatternOutput> Put_Meeting_Day_PatternAsync(Put_Meeting_Day_PatternInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Meeting_PatternsOutput Get_Meeting_Patterns(Get_Meeting_PatternsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Meeting_PatternsOutput> Get_Meeting_PatternsAsync(Get_Meeting_PatternsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Meeting_PatternOutput Put_Meeting_Pattern(Put_Meeting_PatternInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Meeting_PatternOutput> Put_Meeting_PatternAsync(Put_Meeting_PatternInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Course_Tag_CategoriesOutput Get_Student_Course_Tag_Categories(Get_Student_Course_Tag_CategoriesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Course_Tag_CategoriesOutput> Get_Student_Course_Tag_CategoriesAsync(Get_Student_Course_Tag_CategoriesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Course_Tag_CategoryOutput Put_Student_Course_Tag_Category(Put_Student_Course_Tag_CategoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Course_Tag_CategoryOutput> Put_Student_Course_Tag_CategoryAsync(Put_Student_Course_Tag_CategoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Learning_OutcomesOutput Get_Learning_Outcomes(Get_Learning_OutcomesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Learning_OutcomesOutput> Get_Learning_OutcomesAsync(Get_Learning_OutcomesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Learning_OutcomeOutput Put_Learning_Outcome(Put_Learning_OutcomeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Learning_OutcomeOutput> Put_Learning_OutcomeAsync(Put_Learning_OutcomeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Course_SubjectsOutput Get_Course_Subjects(Get_Course_SubjectsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Course_SubjectsOutput> Get_Course_SubjectsAsync(Get_Course_SubjectsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Course_SubjectOutput Put_Course_Subject(Put_Course_SubjectInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Course_SubjectOutput> Put_Course_SubjectAsync(Put_Course_SubjectInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Course_TagsOutput Get_Student_Course_Tags(Get_Student_Course_TagsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Course_TagsOutput> Get_Student_Course_TagsAsync(Get_Student_Course_TagsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Course_TagOutput Put_Student_Course_Tag(Put_Student_Course_TagInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Course_TagOutput> Put_Student_Course_TagAsync(Put_Student_Course_TagInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_CourseOutput Get_Student_Course(Get_Student_CourseInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_CourseOutput> Get_Student_CourseAsync(Get_Student_CourseInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Student_CourseOutput Submit_Student_Course(Submit_Student_CourseInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Student_CourseOutput> Submit_Student_CourseAsync(Submit_Student_CourseInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Course_SectionsOutput Get_Course_Sections(Get_Course_SectionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Course_SectionsOutput> Get_Course_SectionsAsync(Get_Course_SectionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Course_SectionOutput Submit_Course_Section(Submit_Course_SectionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Course_SectionOutput> Submit_Course_SectionAsync(Submit_Course_SectionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Orientation_OfferingsOutput Get_Orientation_Offerings(Get_Orientation_OfferingsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Orientation_OfferingsOutput> Get_Orientation_OfferingsAsync(Get_Orientation_OfferingsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Orientation_OfferingOutput Put_Orientation_Offering(Put_Orientation_OfferingInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Orientation_OfferingOutput> Put_Orientation_OfferingAsync(Put_Orientation_OfferingInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Scheduled_AssessmentOutput Put_Scheduled_Assessment(Put_Scheduled_AssessmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Scheduled_AssessmentOutput> Put_Scheduled_AssessmentAsync(Put_Scheduled_AssessmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Scheduled_AssessmentsOutput Get_Scheduled_Assessments(Get_Scheduled_AssessmentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Scheduled_AssessmentsOutput> Get_Scheduled_AssessmentsAsync(Get_Scheduled_AssessmentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Course_Section_RelationshipOutput Get_Course_Section_Relationship(Get_Course_Section_RelationshipInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Course_Section_RelationshipOutput> Get_Course_Section_RelationshipAsync(Get_Course_Section_RelationshipInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Course_Section_RelationshipOutput Put_Course_Section_Relationship(Put_Course_Section_RelationshipInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Course_Section_RelationshipOutput> Put_Course_Section_RelationshipAsync(Put_Course_Section_RelationshipInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Course_Equivalency_GroupsOutput Get_Course_Equivalency_Groups(Get_Course_Equivalency_GroupsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Course_Equivalency_GroupsOutput> Get_Course_Equivalency_GroupsAsync(Get_Course_Equivalency_GroupsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Course_Equivalency_GroupOutput Put_Course_Equivalency_Group(Put_Course_Equivalency_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Course_Equivalency_GroupOutput> Put_Course_Equivalency_GroupAsync(Put_Course_Equivalency_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_OrientationsOutput Get_Orientations(Get_OrientationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_OrientationsOutput> Get_OrientationsAsync(Get_OrientationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_OrientationOutput Put_Orientation(Put_OrientationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_OrientationOutput> Put_OrientationAsync(Put_OrientationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Study_Abroad_OfferingsOutput Get_Study_Abroad_Offerings(Get_Study_Abroad_OfferingsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Study_Abroad_OfferingsOutput> Get_Study_Abroad_OfferingsAsync(Get_Study_Abroad_OfferingsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Study_Abroad_OfferingOutput Put_Study_Abroad_Offering(Put_Study_Abroad_OfferingInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Study_Abroad_OfferingOutput> Put_Study_Abroad_OfferingAsync(Put_Study_Abroad_OfferingInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Course_Offering_SetsOutput Get_Course_Offering_Sets(Get_Course_Offering_SetsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Course_Offering_SetsOutput> Get_Course_Offering_SetsAsync(Get_Course_Offering_SetsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Course_Offering_SetOutput Put_Course_Offering_Set(Put_Course_Offering_SetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Course_Offering_SetOutput> Put_Course_Offering_SetAsync(Put_Course_Offering_SetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Course_MaterialsOutput Get_Student_Course_Materials(Get_Student_Course_MaterialsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Course_MaterialsOutput> Get_Student_Course_MaterialsAsync(Get_Student_Course_MaterialsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Course_MaterialOutput Put_Student_Course_Material(Put_Student_Course_MaterialInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Course_MaterialOutput> Put_Student_Course_MaterialAsync(Put_Student_Course_MaterialInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Course_RegistrationOutput Put_Student_Course_Registration(Put_Student_Course_RegistrationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Course_RegistrationOutput> Put_Student_Course_RegistrationAsync(Put_Student_Course_RegistrationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Course_RegistrationsOutput Get_Student_Course_Registrations(Get_Student_Course_RegistrationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Course_RegistrationsOutput> Get_Student_Course_RegistrationsAsync(Get_Student_Course_RegistrationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_CompetenciesOutput Get_Student_Competencies(Get_Student_CompetenciesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_CompetenciesOutput> Get_Student_CompetenciesAsync(Get_Student_CompetenciesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_CompetencyOutput Put_Student_Competency(Put_Student_CompetencyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_CompetencyOutput> Put_Student_CompetencyAsync(Put_Student_CompetencyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Activity_Registration_RecordsOutput Get_Student_Activity_Registration_Records(Get_Student_Activity_Registration_RecordsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Activity_Registration_RecordsOutput> Get_Student_Activity_Registration_RecordsAsync(Get_Student_Activity_Registration_RecordsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Activity_Registration_RecordOutput Put_Student_Activity_Registration_Record(Put_Student_Activity_Registration_RecordInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Activity_Registration_RecordOutput> Put_Student_Activity_Registration_RecordAsync(Put_Student_Activity_Registration_RecordInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Practical_LearningOutput Put_Practical_Learning(Put_Practical_LearningInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Practical_LearningOutput> Put_Practical_LearningAsync(Put_Practical_LearningInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Practical_LearningsOutput Get_Practical_Learnings(Get_Practical_LearningsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Practical_LearningsOutput> Get_Practical_LearningsAsync(Get_Practical_LearningsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_AccomplishmentsOutput Get_Student_Accomplishments(Get_Student_AccomplishmentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_AccomplishmentsOutput> Get_Student_AccomplishmentsAsync(Get_Student_AccomplishmentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_AccomplishmentOutput Put_Student_Accomplishment(Put_Student_AccomplishmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_AccomplishmentOutput> Put_Student_AccomplishmentAsync(Put_Student_AccomplishmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Practical_Learning_OfferingsOutput Get_Practical_Learning_Offerings(Get_Practical_Learning_OfferingsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Practical_Learning_OfferingsOutput> Get_Practical_Learning_OfferingsAsync(Get_Practical_Learning_OfferingsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Practical_Learning_OfferingOutput Put_Practical_Learning_Offering(Put_Practical_Learning_OfferingInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Practical_Learning_OfferingOutput> Put_Practical_Learning_OfferingAsync(Put_Practical_Learning_OfferingInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Grades_for_RegistrationsOutput Submit_Grades_for_Registrations(Submit_Grades_for_RegistrationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Grades_for_RegistrationsOutput> Submit_Grades_for_RegistrationsAsync(Submit_Grades_for_RegistrationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Transcript_OrderOutput Put_Transcript_Order(Put_Transcript_OrderInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Transcript_OrderOutput> Put_Transcript_OrderAsync(Put_Transcript_OrderInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Transcript_OrdersOutput Get_Transcript_Orders(Get_Transcript_OrdersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Transcript_OrdersOutput> Get_Transcript_OrdersAsync(Get_Transcript_OrdersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Course_Registered_RegistrationOutput Put_Student_Course_Registered_Registration(Put_Student_Course_Registered_RegistrationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Course_Registered_RegistrationOutput> Put_Student_Course_Registered_RegistrationAsync(Put_Student_Course_Registered_RegistrationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Course_Dropped_RegistrationOutput Put_Student_Course_Dropped_Registration(Put_Student_Course_Dropped_RegistrationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Course_Dropped_RegistrationOutput> Put_Student_Course_Dropped_RegistrationAsync(Put_Student_Course_Dropped_RegistrationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Student_Course_Withdraw_RegistrationOutput Submit_Student_Course_Withdraw_Registration(Submit_Student_Course_Withdraw_RegistrationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Student_Course_Withdraw_RegistrationOutput> Submit_Student_Course_Withdraw_RegistrationAsync(Submit_Student_Course_Withdraw_RegistrationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Change_Program_of_StudyOutput Submit_Change_Program_of_Study(Submit_Change_Program_of_StudyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Change_Program_of_StudyOutput> Submit_Change_Program_of_StudyAsync(Submit_Change_Program_of_StudyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Add_Program_of_StudyOutput Submit_Add_Program_of_Study(Submit_Add_Program_of_StudyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Add_Program_of_StudyOutput> Submit_Add_Program_of_StudyAsync(Submit_Add_Program_of_StudyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Remove_Program_of_StudyOutput Submit_Remove_Program_of_Study(Submit_Remove_Program_of_StudyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Remove_Program_of_StudyOutput> Submit_Remove_Program_of_StudyAsync(Submit_Remove_Program_of_StudyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Courses_without_DependenciesOutput Get_Student_Courses_without_Dependencies(Get_Student_Courses_without_DependenciesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Courses_without_DependenciesOutput> Get_Student_Courses_without_DependenciesAsync(Get_Student_Courses_without_DependenciesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Student_Course_RegistrationsOutput Import_Student_Course_Registrations(Import_Student_Course_RegistrationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Student_Course_RegistrationsOutput> Import_Student_Course_RegistrationsAsync(Import_Student_Course_RegistrationsInput request);
	}
}
