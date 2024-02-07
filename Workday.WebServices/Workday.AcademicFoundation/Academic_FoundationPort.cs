using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Academic_Foundation", ConfigurationName = "Academic_FoundationService.Academic_FoundationPort")]
	public interface Academic_FoundationPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Programs_of_StudyOutput Get_Programs_of_Study(Get_Programs_of_StudyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Programs_of_StudyOutput> Get_Programs_of_StudyAsync(Get_Programs_of_StudyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Program_of_StudyOutput Put_Program_of_Study(Put_Program_of_StudyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Program_of_StudyOutput> Put_Program_of_StudyAsync(Put_Program_of_StudyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_External_AssociationsOutput Get_External_Associations(Get_External_AssociationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_External_AssociationsOutput> Get_External_AssociationsAsync(Get_External_AssociationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_External_AssociationOutput Put_External_Association(Put_External_AssociationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_External_AssociationOutput> Put_External_AssociationAsync(Put_External_AssociationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Tag_CategoriesOutput Get_Student_Tag_Categories(Get_Student_Tag_CategoriesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Tag_CategoriesOutput> Get_Student_Tag_CategoriesAsync(Get_Student_Tag_CategoriesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Tag_CategoryOutput Put_Student_Tag_Category(Put_Student_Tag_CategoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Tag_CategoryOutput> Put_Student_Tag_CategoryAsync(Put_Student_Tag_CategoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_TagsOutput Get_Student_Tags(Get_Student_TagsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_TagsOutput> Get_Student_TagsAsync(Get_Student_TagsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_TagOutput Put_Student_Tag(Put_Student_TagInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_TagOutput> Put_Student_TagAsync(Put_Student_TagInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Extracurricular_ActivitiesOutput Get_Extracurricular_Activities(Get_Extracurricular_ActivitiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Extracurricular_ActivitiesOutput> Get_Extracurricular_ActivitiesAsync(Get_Extracurricular_ActivitiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Extracurricular_ActivityOutput Put_Extracurricular_Activity(Put_Extracurricular_ActivityInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Extracurricular_ActivityOutput> Put_Extracurricular_ActivityAsync(Put_Extracurricular_ActivityInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Academic_ContactsOutput Get_Academic_Contacts(Get_Academic_ContactsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Academic_ContactsOutput> Get_Academic_ContactsAsync(Get_Academic_ContactsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Academic_ContactOutput Put_Academic_Contact(Put_Academic_ContactInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Academic_ContactOutput> Put_Academic_ContactAsync(Put_Academic_ContactInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Grading_SchemesOutput Get_Student_Grading_Schemes(Get_Student_Grading_SchemesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Grading_SchemesOutput> Get_Student_Grading_SchemesAsync(Get_Student_Grading_SchemesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Grading_SchemeOutput Put_Student_Grading_Scheme(Put_Student_Grading_SchemeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Grading_SchemeOutput> Put_Student_Grading_SchemeAsync(Put_Student_Grading_SchemeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Education_Test_ResultsOutput Get_Education_Test_Results(Get_Education_Test_ResultsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Education_Test_ResultsOutput> Get_Education_Test_ResultsAsync(Get_Education_Test_ResultsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Education_Test_ResultOutput Put_Education_Test_Result(Put_Education_Test_ResultInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Education_Test_ResultOutput> Put_Education_Test_ResultAsync(Put_Education_Test_ResultInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Maintained_Academic_PeriodsOutput Get_Maintained_Academic_Periods(Get_Maintained_Academic_PeriodsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Maintained_Academic_PeriodsOutput> Get_Maintained_Academic_PeriodsAsync(Get_Maintained_Academic_PeriodsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Maintained_Academic_PeriodOutput Put_Maintained_Academic_Period(Put_Maintained_Academic_PeriodInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Maintained_Academic_PeriodOutput> Put_Maintained_Academic_PeriodAsync(Put_Maintained_Academic_PeriodInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Prospective_StudentsOutput Get_Prospective_Students(Get_Prospective_StudentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Prospective_StudentsOutput> Get_Prospective_StudentsAsync(Get_Prospective_StudentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Educational_InstitutionOutput Get_Student_Educational_Institution(Get_Student_Educational_InstitutionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Educational_InstitutionOutput> Get_Student_Educational_InstitutionAsync(Get_Student_Educational_InstitutionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Educational_InstitutionOutput Put_Student_Educational_Institution(Put_Student_Educational_InstitutionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Educational_InstitutionOutput> Put_Student_Educational_InstitutionAsync(Put_Student_Educational_InstitutionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Educational_Institution_CourseOutput Put_Educational_Institution_Course(Put_Educational_Institution_CourseInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Educational_Institution_CourseOutput> Put_Educational_Institution_CourseAsync(Put_Educational_Institution_CourseInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Educational_Institution_CourseOutput Get_Educational_Institution_Course(Get_Educational_Institution_CourseInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Educational_Institution_CourseOutput> Get_Educational_Institution_CourseAsync(Get_Educational_Institution_CourseInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Educational_Institution_DistrictsOutput Get_Student_Educational_Institution_Districts(Get_Student_Educational_Institution_DistrictsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Educational_Institution_DistrictsOutput> Get_Student_Educational_Institution_DistrictsAsync(Get_Student_Educational_Institution_DistrictsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Educational_Institution_DistrictOutput Put_Student_Educational_Institution_District(Put_Student_Educational_Institution_DistrictInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Educational_Institution_DistrictOutput> Put_Student_Educational_Institution_DistrictAsync(Put_Student_Educational_Institution_DistrictInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_StudentsOutput Get_Students(Get_StudentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_StudentsOutput> Get_StudentsAsync(Get_StudentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Transfer_Credit_RulesOutput Get_Student_Transfer_Credit_Rules(Get_Student_Transfer_Credit_RulesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Transfer_Credit_RulesOutput> Get_Student_Transfer_Credit_RulesAsync(Get_Student_Transfer_Credit_RulesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Transfer_Credit_RuleOutput Put_Student_Transfer_Credit_Rule(Put_Student_Transfer_Credit_RuleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Transfer_Credit_RuleOutput> Put_Student_Transfer_Credit_RuleAsync(Put_Student_Transfer_Credit_RuleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Friends_and_FamilyOutput Get_Student_Friends_and_Family(Get_Student_Friends_and_FamilyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Friends_and_FamilyOutput> Get_Student_Friends_and_FamilyAsync(Get_Student_Friends_and_FamilyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Friends_and_FamilyOutput Put_Student_Friends_and_Family(Put_Student_Friends_and_FamilyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Friends_and_FamilyOutput> Put_Student_Friends_and_FamilyAsync(Put_Student_Friends_and_FamilyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Universal_IdentifierOutput Get_Universal_Identifier(Get_Universal_IdentifierInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Universal_IdentifierOutput> Get_Universal_IdentifierAsync(Get_Universal_IdentifierInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Universal_IdentifierOutput Put_Universal_Identifier(Put_Universal_IdentifierInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Universal_IdentifierOutput> Put_Universal_IdentifierAsync(Put_Universal_IdentifierInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Education_Test_ResultsOutput Import_Education_Test_Results(Import_Education_Test_ResultsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Education_Test_ResultsOutput> Import_Education_Test_ResultsAsync(Import_Education_Test_ResultsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Education_Test_ResultsOutput Import_Student_Personal_Information(Import_Student_Personal_InformationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Education_Test_ResultsOutput> Import_Student_Personal_InformationAsync(Import_Student_Personal_InformationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Education_Test_ResultsOutput Import_Universal_Identifiers(Import_Universal_IdentifiersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Education_Test_ResultsOutput> Import_Universal_IdentifiersAsync(Import_Universal_IdentifiersInput request);
	}
}
