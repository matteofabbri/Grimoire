using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Student_RecordsPortClient : ClientBase<Student_RecordsPort>, Student_RecordsPort
	{
		public Student_RecordsPortClient()
		{
		}

		public Student_RecordsPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Student_RecordsPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Student_RecordsPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Student_RecordsPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Meeting_Day_PatternsOutput Student_RecordsPort.Get_Meeting_Day_Patterns(Get_Meeting_Day_PatternsInput request)
		{
			return base.Channel.Get_Meeting_Day_Patterns(request);
		}

		public Get_Meeting_Day_Patterns_ResponseType Get_Meeting_Day_Patterns(Workday_Common_HeaderType Workday_Common_Header, Get_Meeting_Day_Patterns_RequestType Get_Meeting_Day_Patterns_Request)
		{
			return ((Student_RecordsPort)this).Get_Meeting_Day_Patterns(new Get_Meeting_Day_PatternsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Meeting_Day_Patterns_Request = Get_Meeting_Day_Patterns_Request
			}).Get_Meeting_Day_Patterns_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Meeting_Day_PatternsOutput> Student_RecordsPort.Get_Meeting_Day_PatternsAsync(Get_Meeting_Day_PatternsInput request)
		{
			return base.Channel.Get_Meeting_Day_PatternsAsync(request);
		}

		public Task<Get_Meeting_Day_PatternsOutput> Get_Meeting_Day_PatternsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Meeting_Day_Patterns_RequestType Get_Meeting_Day_Patterns_Request)
		{
			return ((Student_RecordsPort)this).Get_Meeting_Day_PatternsAsync(new Get_Meeting_Day_PatternsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Meeting_Day_Patterns_Request = Get_Meeting_Day_Patterns_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Meeting_Day_PatternOutput Student_RecordsPort.Put_Meeting_Day_Pattern(Put_Meeting_Day_PatternInput request)
		{
			return base.Channel.Put_Meeting_Day_Pattern(request);
		}

		public Put_Meeting_Day_Pattern_ResponseType Put_Meeting_Day_Pattern(Workday_Common_HeaderType Workday_Common_Header, Put_Meeting_Day_Pattern_RequestType Put_Meeting_Day_Pattern_Request)
		{
			return ((Student_RecordsPort)this).Put_Meeting_Day_Pattern(new Put_Meeting_Day_PatternInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Meeting_Day_Pattern_Request = Put_Meeting_Day_Pattern_Request
			}).Put_Meeting_Day_Pattern_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Meeting_Day_PatternOutput> Student_RecordsPort.Put_Meeting_Day_PatternAsync(Put_Meeting_Day_PatternInput request)
		{
			return base.Channel.Put_Meeting_Day_PatternAsync(request);
		}

		public Task<Put_Meeting_Day_PatternOutput> Put_Meeting_Day_PatternAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Meeting_Day_Pattern_RequestType Put_Meeting_Day_Pattern_Request)
		{
			return ((Student_RecordsPort)this).Put_Meeting_Day_PatternAsync(new Put_Meeting_Day_PatternInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Meeting_Day_Pattern_Request = Put_Meeting_Day_Pattern_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Meeting_PatternsOutput Student_RecordsPort.Get_Meeting_Patterns(Get_Meeting_PatternsInput request)
		{
			return base.Channel.Get_Meeting_Patterns(request);
		}

		public Get_Meeting_Patterns_ResponseType Get_Meeting_Patterns(Workday_Common_HeaderType Workday_Common_Header, Get_Meeting_Patterns_RequestType Get_Meeting_Patterns_Request)
		{
			return ((Student_RecordsPort)this).Get_Meeting_Patterns(new Get_Meeting_PatternsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Meeting_Patterns_Request = Get_Meeting_Patterns_Request
			}).Get_Meeting_Patterns_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Meeting_PatternsOutput> Student_RecordsPort.Get_Meeting_PatternsAsync(Get_Meeting_PatternsInput request)
		{
			return base.Channel.Get_Meeting_PatternsAsync(request);
		}

		public Task<Get_Meeting_PatternsOutput> Get_Meeting_PatternsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Meeting_Patterns_RequestType Get_Meeting_Patterns_Request)
		{
			return ((Student_RecordsPort)this).Get_Meeting_PatternsAsync(new Get_Meeting_PatternsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Meeting_Patterns_Request = Get_Meeting_Patterns_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Meeting_PatternOutput Student_RecordsPort.Put_Meeting_Pattern(Put_Meeting_PatternInput request)
		{
			return base.Channel.Put_Meeting_Pattern(request);
		}

		public Put_Meeting_Pattern_ResponseType Put_Meeting_Pattern(Workday_Common_HeaderType Workday_Common_Header, Put_Meeting_Pattern_RequestType Put_Meeting_Pattern_Request)
		{
			return ((Student_RecordsPort)this).Put_Meeting_Pattern(new Put_Meeting_PatternInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Meeting_Pattern_Request = Put_Meeting_Pattern_Request
			}).Put_Meeting_Pattern_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Meeting_PatternOutput> Student_RecordsPort.Put_Meeting_PatternAsync(Put_Meeting_PatternInput request)
		{
			return base.Channel.Put_Meeting_PatternAsync(request);
		}

		public Task<Put_Meeting_PatternOutput> Put_Meeting_PatternAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Meeting_Pattern_RequestType Put_Meeting_Pattern_Request)
		{
			return ((Student_RecordsPort)this).Put_Meeting_PatternAsync(new Put_Meeting_PatternInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Meeting_Pattern_Request = Put_Meeting_Pattern_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Course_Tag_CategoriesOutput Student_RecordsPort.Get_Student_Course_Tag_Categories(Get_Student_Course_Tag_CategoriesInput request)
		{
			return base.Channel.Get_Student_Course_Tag_Categories(request);
		}

		public Get_Student_Course_Tag_Categories_ResponseType Get_Student_Course_Tag_Categories(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Course_Tag_Categories_RequestType Get_Student_Course_Tag_Categories_Request)
		{
			return ((Student_RecordsPort)this).Get_Student_Course_Tag_Categories(new Get_Student_Course_Tag_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Course_Tag_Categories_Request = Get_Student_Course_Tag_Categories_Request
			}).Get_Student_Course_Tag_Categories_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Course_Tag_CategoriesOutput> Student_RecordsPort.Get_Student_Course_Tag_CategoriesAsync(Get_Student_Course_Tag_CategoriesInput request)
		{
			return base.Channel.Get_Student_Course_Tag_CategoriesAsync(request);
		}

		public Task<Get_Student_Course_Tag_CategoriesOutput> Get_Student_Course_Tag_CategoriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Course_Tag_Categories_RequestType Get_Student_Course_Tag_Categories_Request)
		{
			return ((Student_RecordsPort)this).Get_Student_Course_Tag_CategoriesAsync(new Get_Student_Course_Tag_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Course_Tag_Categories_Request = Get_Student_Course_Tag_Categories_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Course_Tag_CategoryOutput Student_RecordsPort.Put_Student_Course_Tag_Category(Put_Student_Course_Tag_CategoryInput request)
		{
			return base.Channel.Put_Student_Course_Tag_Category(request);
		}

		public Put_Student_Course_Tag_Category_ResponseType Put_Student_Course_Tag_Category(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Course_Tag_Category_RequestType Put_Student_Course_Tag_Category_Request)
		{
			return ((Student_RecordsPort)this).Put_Student_Course_Tag_Category(new Put_Student_Course_Tag_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Course_Tag_Category_Request = Put_Student_Course_Tag_Category_Request
			}).Put_Student_Course_Tag_Category_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Course_Tag_CategoryOutput> Student_RecordsPort.Put_Student_Course_Tag_CategoryAsync(Put_Student_Course_Tag_CategoryInput request)
		{
			return base.Channel.Put_Student_Course_Tag_CategoryAsync(request);
		}

		public Task<Put_Student_Course_Tag_CategoryOutput> Put_Student_Course_Tag_CategoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Course_Tag_Category_RequestType Put_Student_Course_Tag_Category_Request)
		{
			return ((Student_RecordsPort)this).Put_Student_Course_Tag_CategoryAsync(new Put_Student_Course_Tag_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Course_Tag_Category_Request = Put_Student_Course_Tag_Category_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Learning_OutcomesOutput Student_RecordsPort.Get_Learning_Outcomes(Get_Learning_OutcomesInput request)
		{
			return base.Channel.Get_Learning_Outcomes(request);
		}

		public Get_Learning_Outcomes_ResponseType Get_Learning_Outcomes(Workday_Common_HeaderType Workday_Common_Header, Get_Learning_Outcomes_RequestType Get_Learning_Outcomes_Request)
		{
			return ((Student_RecordsPort)this).Get_Learning_Outcomes(new Get_Learning_OutcomesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Learning_Outcomes_Request = Get_Learning_Outcomes_Request
			}).Get_Learning_Outcomes_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Learning_OutcomesOutput> Student_RecordsPort.Get_Learning_OutcomesAsync(Get_Learning_OutcomesInput request)
		{
			return base.Channel.Get_Learning_OutcomesAsync(request);
		}

		public Task<Get_Learning_OutcomesOutput> Get_Learning_OutcomesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Learning_Outcomes_RequestType Get_Learning_Outcomes_Request)
		{
			return ((Student_RecordsPort)this).Get_Learning_OutcomesAsync(new Get_Learning_OutcomesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Learning_Outcomes_Request = Get_Learning_Outcomes_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Learning_OutcomeOutput Student_RecordsPort.Put_Learning_Outcome(Put_Learning_OutcomeInput request)
		{
			return base.Channel.Put_Learning_Outcome(request);
		}

		public Put_Learning_Outcome_ResponseType Put_Learning_Outcome(Workday_Common_HeaderType Workday_Common_Header, Put_Learning_Outcome_RequestType Put_Learning_Outcome_Request)
		{
			return ((Student_RecordsPort)this).Put_Learning_Outcome(new Put_Learning_OutcomeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Learning_Outcome_Request = Put_Learning_Outcome_Request
			}).Put_Learning_Outcome_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Learning_OutcomeOutput> Student_RecordsPort.Put_Learning_OutcomeAsync(Put_Learning_OutcomeInput request)
		{
			return base.Channel.Put_Learning_OutcomeAsync(request);
		}

		public Task<Put_Learning_OutcomeOutput> Put_Learning_OutcomeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Learning_Outcome_RequestType Put_Learning_Outcome_Request)
		{
			return ((Student_RecordsPort)this).Put_Learning_OutcomeAsync(new Put_Learning_OutcomeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Learning_Outcome_Request = Put_Learning_Outcome_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Course_SubjectsOutput Student_RecordsPort.Get_Course_Subjects(Get_Course_SubjectsInput request)
		{
			return base.Channel.Get_Course_Subjects(request);
		}

		public Get_Course_Subjects_ResponseType Get_Course_Subjects(Workday_Common_HeaderType Workday_Common_Header, Get_Course_Subjects_RequestType Get_Course_Subjects_Request)
		{
			return ((Student_RecordsPort)this).Get_Course_Subjects(new Get_Course_SubjectsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Course_Subjects_Request = Get_Course_Subjects_Request
			}).Get_Course_Subjects_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Course_SubjectsOutput> Student_RecordsPort.Get_Course_SubjectsAsync(Get_Course_SubjectsInput request)
		{
			return base.Channel.Get_Course_SubjectsAsync(request);
		}

		public Task<Get_Course_SubjectsOutput> Get_Course_SubjectsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Course_Subjects_RequestType Get_Course_Subjects_Request)
		{
			return ((Student_RecordsPort)this).Get_Course_SubjectsAsync(new Get_Course_SubjectsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Course_Subjects_Request = Get_Course_Subjects_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Course_SubjectOutput Student_RecordsPort.Put_Course_Subject(Put_Course_SubjectInput request)
		{
			return base.Channel.Put_Course_Subject(request);
		}

		public Put_Course_Subject_ResponseType Put_Course_Subject(Workday_Common_HeaderType Workday_Common_Header, Put_Course_Subject_RequestType Put_Course_Subject_Request)
		{
			return ((Student_RecordsPort)this).Put_Course_Subject(new Put_Course_SubjectInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Course_Subject_Request = Put_Course_Subject_Request
			}).Put_Course_Subject_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Course_SubjectOutput> Student_RecordsPort.Put_Course_SubjectAsync(Put_Course_SubjectInput request)
		{
			return base.Channel.Put_Course_SubjectAsync(request);
		}

		public Task<Put_Course_SubjectOutput> Put_Course_SubjectAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Course_Subject_RequestType Put_Course_Subject_Request)
		{
			return ((Student_RecordsPort)this).Put_Course_SubjectAsync(new Put_Course_SubjectInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Course_Subject_Request = Put_Course_Subject_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Course_TagsOutput Student_RecordsPort.Get_Student_Course_Tags(Get_Student_Course_TagsInput request)
		{
			return base.Channel.Get_Student_Course_Tags(request);
		}

		public Get_Student_Course_Tags_ResponseType Get_Student_Course_Tags(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Course_Tags_RequestType Get_Student_Course_Tags_Request)
		{
			return ((Student_RecordsPort)this).Get_Student_Course_Tags(new Get_Student_Course_TagsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Course_Tags_Request = Get_Student_Course_Tags_Request
			}).Get_Student_Course_Tags_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Course_TagsOutput> Student_RecordsPort.Get_Student_Course_TagsAsync(Get_Student_Course_TagsInput request)
		{
			return base.Channel.Get_Student_Course_TagsAsync(request);
		}

		public Task<Get_Student_Course_TagsOutput> Get_Student_Course_TagsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Course_Tags_RequestType Get_Student_Course_Tags_Request)
		{
			return ((Student_RecordsPort)this).Get_Student_Course_TagsAsync(new Get_Student_Course_TagsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Course_Tags_Request = Get_Student_Course_Tags_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Course_TagOutput Student_RecordsPort.Put_Student_Course_Tag(Put_Student_Course_TagInput request)
		{
			return base.Channel.Put_Student_Course_Tag(request);
		}

		public Put_Student_Course_Tag_ResponseType Put_Student_Course_Tag(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Course_Tag_RequestType Put_Student_Course_Tag_Request)
		{
			return ((Student_RecordsPort)this).Put_Student_Course_Tag(new Put_Student_Course_TagInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Course_Tag_Request = Put_Student_Course_Tag_Request
			}).Put_Student_Course_Tag_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Course_TagOutput> Student_RecordsPort.Put_Student_Course_TagAsync(Put_Student_Course_TagInput request)
		{
			return base.Channel.Put_Student_Course_TagAsync(request);
		}

		public Task<Put_Student_Course_TagOutput> Put_Student_Course_TagAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Course_Tag_RequestType Put_Student_Course_Tag_Request)
		{
			return ((Student_RecordsPort)this).Put_Student_Course_TagAsync(new Put_Student_Course_TagInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Course_Tag_Request = Put_Student_Course_Tag_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_CourseOutput Student_RecordsPort.Get_Student_Course(Get_Student_CourseInput request)
		{
			return base.Channel.Get_Student_Course(request);
		}

		public Get_Student_Courses_ResponseType Get_Student_Course(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Courses_RequestType Get_Student_Courses_Request)
		{
			return ((Student_RecordsPort)this).Get_Student_Course(new Get_Student_CourseInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Courses_Request = Get_Student_Courses_Request
			}).Get_Student_Courses_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_CourseOutput> Student_RecordsPort.Get_Student_CourseAsync(Get_Student_CourseInput request)
		{
			return base.Channel.Get_Student_CourseAsync(request);
		}

		public Task<Get_Student_CourseOutput> Get_Student_CourseAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Courses_RequestType Get_Student_Courses_Request)
		{
			return ((Student_RecordsPort)this).Get_Student_CourseAsync(new Get_Student_CourseInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Courses_Request = Get_Student_Courses_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Student_CourseOutput Student_RecordsPort.Submit_Student_Course(Submit_Student_CourseInput request)
		{
			return base.Channel.Submit_Student_Course(request);
		}

		public Submit_Student_Course_ResponseType Submit_Student_Course(Workday_Common_HeaderType Workday_Common_Header, Submit_Student_Course_RequestType Submit_Student_Course_Request)
		{
			return ((Student_RecordsPort)this).Submit_Student_Course(new Submit_Student_CourseInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Student_Course_Request = Submit_Student_Course_Request
			}).Submit_Student_Course_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Student_CourseOutput> Student_RecordsPort.Submit_Student_CourseAsync(Submit_Student_CourseInput request)
		{
			return base.Channel.Submit_Student_CourseAsync(request);
		}

		public Task<Submit_Student_CourseOutput> Submit_Student_CourseAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Student_Course_RequestType Submit_Student_Course_Request)
		{
			return ((Student_RecordsPort)this).Submit_Student_CourseAsync(new Submit_Student_CourseInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Student_Course_Request = Submit_Student_Course_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Course_SectionsOutput Student_RecordsPort.Get_Course_Sections(Get_Course_SectionsInput request)
		{
			return base.Channel.Get_Course_Sections(request);
		}

		public Get_Course_Sections_ResponseType Get_Course_Sections(Workday_Common_HeaderType Workday_Common_Header, Get_Course_Sections_RequestType Get_Course_Sections_Request)
		{
			return ((Student_RecordsPort)this).Get_Course_Sections(new Get_Course_SectionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Course_Sections_Request = Get_Course_Sections_Request
			}).Get_Course_Sections_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Course_SectionsOutput> Student_RecordsPort.Get_Course_SectionsAsync(Get_Course_SectionsInput request)
		{
			return base.Channel.Get_Course_SectionsAsync(request);
		}

		public Task<Get_Course_SectionsOutput> Get_Course_SectionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Course_Sections_RequestType Get_Course_Sections_Request)
		{
			return ((Student_RecordsPort)this).Get_Course_SectionsAsync(new Get_Course_SectionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Course_Sections_Request = Get_Course_Sections_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Course_SectionOutput Student_RecordsPort.Submit_Course_Section(Submit_Course_SectionInput request)
		{
			return base.Channel.Submit_Course_Section(request);
		}

		public Submit_Course_Section_ResponseType Submit_Course_Section(Workday_Common_HeaderType Workday_Common_Header, Submit_Course_Section_RequestType Submit_Course_Section_Request)
		{
			return ((Student_RecordsPort)this).Submit_Course_Section(new Submit_Course_SectionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Course_Section_Request = Submit_Course_Section_Request
			}).Submit_Course_Section_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Course_SectionOutput> Student_RecordsPort.Submit_Course_SectionAsync(Submit_Course_SectionInput request)
		{
			return base.Channel.Submit_Course_SectionAsync(request);
		}

		public Task<Submit_Course_SectionOutput> Submit_Course_SectionAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Course_Section_RequestType Submit_Course_Section_Request)
		{
			return ((Student_RecordsPort)this).Submit_Course_SectionAsync(new Submit_Course_SectionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Course_Section_Request = Submit_Course_Section_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Orientation_OfferingsOutput Student_RecordsPort.Get_Orientation_Offerings(Get_Orientation_OfferingsInput request)
		{
			return base.Channel.Get_Orientation_Offerings(request);
		}

		public Get_Orientation_Offerings_ResponseType Get_Orientation_Offerings(Workday_Common_HeaderType Workday_Common_Header, Get_Orientation_Offerings_RequestType Get_Orientation_Offerings_Request)
		{
			return ((Student_RecordsPort)this).Get_Orientation_Offerings(new Get_Orientation_OfferingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Orientation_Offerings_Request = Get_Orientation_Offerings_Request
			}).Get_Orientation_Offerings_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Orientation_OfferingsOutput> Student_RecordsPort.Get_Orientation_OfferingsAsync(Get_Orientation_OfferingsInput request)
		{
			return base.Channel.Get_Orientation_OfferingsAsync(request);
		}

		public Task<Get_Orientation_OfferingsOutput> Get_Orientation_OfferingsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Orientation_Offerings_RequestType Get_Orientation_Offerings_Request)
		{
			return ((Student_RecordsPort)this).Get_Orientation_OfferingsAsync(new Get_Orientation_OfferingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Orientation_Offerings_Request = Get_Orientation_Offerings_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Orientation_OfferingOutput Student_RecordsPort.Put_Orientation_Offering(Put_Orientation_OfferingInput request)
		{
			return base.Channel.Put_Orientation_Offering(request);
		}

		public Put_Orientation_Offering_ResponseType Put_Orientation_Offering(Workday_Common_HeaderType Workday_Common_Header, Put_Orientation_Offering_RequestType Put_Orientation_Offering_Request)
		{
			return ((Student_RecordsPort)this).Put_Orientation_Offering(new Put_Orientation_OfferingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Orientation_Offering_Request = Put_Orientation_Offering_Request
			}).Put_Orientation_Offering_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Orientation_OfferingOutput> Student_RecordsPort.Put_Orientation_OfferingAsync(Put_Orientation_OfferingInput request)
		{
			return base.Channel.Put_Orientation_OfferingAsync(request);
		}

		public Task<Put_Orientation_OfferingOutput> Put_Orientation_OfferingAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Orientation_Offering_RequestType Put_Orientation_Offering_Request)
		{
			return ((Student_RecordsPort)this).Put_Orientation_OfferingAsync(new Put_Orientation_OfferingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Orientation_Offering_Request = Put_Orientation_Offering_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Scheduled_AssessmentOutput Student_RecordsPort.Put_Scheduled_Assessment(Put_Scheduled_AssessmentInput request)
		{
			return base.Channel.Put_Scheduled_Assessment(request);
		}

		public Put_Scheduled_Assessment_ResponseType Put_Scheduled_Assessment(Workday_Common_HeaderType Workday_Common_Header, Put_Scheduled_Assessment_RequestType Put_Scheduled_Assessment_Request)
		{
			return ((Student_RecordsPort)this).Put_Scheduled_Assessment(new Put_Scheduled_AssessmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Scheduled_Assessment_Request = Put_Scheduled_Assessment_Request
			}).Put_Scheduled_Assessment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Scheduled_AssessmentOutput> Student_RecordsPort.Put_Scheduled_AssessmentAsync(Put_Scheduled_AssessmentInput request)
		{
			return base.Channel.Put_Scheduled_AssessmentAsync(request);
		}

		public Task<Put_Scheduled_AssessmentOutput> Put_Scheduled_AssessmentAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Scheduled_Assessment_RequestType Put_Scheduled_Assessment_Request)
		{
			return ((Student_RecordsPort)this).Put_Scheduled_AssessmentAsync(new Put_Scheduled_AssessmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Scheduled_Assessment_Request = Put_Scheduled_Assessment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Scheduled_AssessmentsOutput Student_RecordsPort.Get_Scheduled_Assessments(Get_Scheduled_AssessmentsInput request)
		{
			return base.Channel.Get_Scheduled_Assessments(request);
		}

		public Get_Scheduled_Assessments_ResponseType Get_Scheduled_Assessments(Workday_Common_HeaderType Workday_Common_Header, Get_Scheduled_Assessments_RequestType Get_Scheduled_Assessments_Request)
		{
			return ((Student_RecordsPort)this).Get_Scheduled_Assessments(new Get_Scheduled_AssessmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Scheduled_Assessments_Request = Get_Scheduled_Assessments_Request
			}).Get_Scheduled_Assessments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Scheduled_AssessmentsOutput> Student_RecordsPort.Get_Scheduled_AssessmentsAsync(Get_Scheduled_AssessmentsInput request)
		{
			return base.Channel.Get_Scheduled_AssessmentsAsync(request);
		}

		public Task<Get_Scheduled_AssessmentsOutput> Get_Scheduled_AssessmentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Scheduled_Assessments_RequestType Get_Scheduled_Assessments_Request)
		{
			return ((Student_RecordsPort)this).Get_Scheduled_AssessmentsAsync(new Get_Scheduled_AssessmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Scheduled_Assessments_Request = Get_Scheduled_Assessments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Course_Section_RelationshipOutput Student_RecordsPort.Get_Course_Section_Relationship(Get_Course_Section_RelationshipInput request)
		{
			return base.Channel.Get_Course_Section_Relationship(request);
		}

		public Get_Course_Section_Relationship_ResponseType Get_Course_Section_Relationship(Workday_Common_HeaderType Workday_Common_Header, Get_Course_Section_Relationship_RequestType Get_Course_Section_Relationship_Request)
		{
			return ((Student_RecordsPort)this).Get_Course_Section_Relationship(new Get_Course_Section_RelationshipInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Course_Section_Relationship_Request = Get_Course_Section_Relationship_Request
			}).Get_Course_Section_Relationship_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Course_Section_RelationshipOutput> Student_RecordsPort.Get_Course_Section_RelationshipAsync(Get_Course_Section_RelationshipInput request)
		{
			return base.Channel.Get_Course_Section_RelationshipAsync(request);
		}

		public Task<Get_Course_Section_RelationshipOutput> Get_Course_Section_RelationshipAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Course_Section_Relationship_RequestType Get_Course_Section_Relationship_Request)
		{
			return ((Student_RecordsPort)this).Get_Course_Section_RelationshipAsync(new Get_Course_Section_RelationshipInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Course_Section_Relationship_Request = Get_Course_Section_Relationship_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Course_Section_RelationshipOutput Student_RecordsPort.Put_Course_Section_Relationship(Put_Course_Section_RelationshipInput request)
		{
			return base.Channel.Put_Course_Section_Relationship(request);
		}

		public Put_Course_Section_Relationship_ResponseType Put_Course_Section_Relationship(Workday_Common_HeaderType Workday_Common_Header, Put_Course_Section_Relationship_RequestType Put_Course_Section_Relationship_Request)
		{
			return ((Student_RecordsPort)this).Put_Course_Section_Relationship(new Put_Course_Section_RelationshipInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Course_Section_Relationship_Request = Put_Course_Section_Relationship_Request
			}).Put_Course_Section_Relationship_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Course_Section_RelationshipOutput> Student_RecordsPort.Put_Course_Section_RelationshipAsync(Put_Course_Section_RelationshipInput request)
		{
			return base.Channel.Put_Course_Section_RelationshipAsync(request);
		}

		public Task<Put_Course_Section_RelationshipOutput> Put_Course_Section_RelationshipAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Course_Section_Relationship_RequestType Put_Course_Section_Relationship_Request)
		{
			return ((Student_RecordsPort)this).Put_Course_Section_RelationshipAsync(new Put_Course_Section_RelationshipInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Course_Section_Relationship_Request = Put_Course_Section_Relationship_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Course_Equivalency_GroupsOutput Student_RecordsPort.Get_Course_Equivalency_Groups(Get_Course_Equivalency_GroupsInput request)
		{
			return base.Channel.Get_Course_Equivalency_Groups(request);
		}

		public Get_Course_Equivalency_Groups_ResponseType Get_Course_Equivalency_Groups(Workday_Common_HeaderType Workday_Common_Header, Get_Course_Equivalency_Groups_RequestType Get_Course_Equivalency_Groups_Request)
		{
			return ((Student_RecordsPort)this).Get_Course_Equivalency_Groups(new Get_Course_Equivalency_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Course_Equivalency_Groups_Request = Get_Course_Equivalency_Groups_Request
			}).Get_Course_Equivalency_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Course_Equivalency_GroupsOutput> Student_RecordsPort.Get_Course_Equivalency_GroupsAsync(Get_Course_Equivalency_GroupsInput request)
		{
			return base.Channel.Get_Course_Equivalency_GroupsAsync(request);
		}

		public Task<Get_Course_Equivalency_GroupsOutput> Get_Course_Equivalency_GroupsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Course_Equivalency_Groups_RequestType Get_Course_Equivalency_Groups_Request)
		{
			return ((Student_RecordsPort)this).Get_Course_Equivalency_GroupsAsync(new Get_Course_Equivalency_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Course_Equivalency_Groups_Request = Get_Course_Equivalency_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Course_Equivalency_GroupOutput Student_RecordsPort.Put_Course_Equivalency_Group(Put_Course_Equivalency_GroupInput request)
		{
			return base.Channel.Put_Course_Equivalency_Group(request);
		}

		public Put_Course_Equivalency_Group_ResponseType Put_Course_Equivalency_Group(Workday_Common_HeaderType Workday_Common_Header, Put_Course_Equivalency_Group_RequestType Put_Course_Equivalency_Group_Request)
		{
			return ((Student_RecordsPort)this).Put_Course_Equivalency_Group(new Put_Course_Equivalency_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Course_Equivalency_Group_Request = Put_Course_Equivalency_Group_Request
			}).Put_Course_Equivalency_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Course_Equivalency_GroupOutput> Student_RecordsPort.Put_Course_Equivalency_GroupAsync(Put_Course_Equivalency_GroupInput request)
		{
			return base.Channel.Put_Course_Equivalency_GroupAsync(request);
		}

		public Task<Put_Course_Equivalency_GroupOutput> Put_Course_Equivalency_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Course_Equivalency_Group_RequestType Put_Course_Equivalency_Group_Request)
		{
			return ((Student_RecordsPort)this).Put_Course_Equivalency_GroupAsync(new Put_Course_Equivalency_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Course_Equivalency_Group_Request = Put_Course_Equivalency_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_OrientationsOutput Student_RecordsPort.Get_Orientations(Get_OrientationsInput request)
		{
			return base.Channel.Get_Orientations(request);
		}

		public Get_Orientations_ResponseType Get_Orientations(Workday_Common_HeaderType Workday_Common_Header, Get_Orientations_RequestType Get_Orientations_Request)
		{
			return ((Student_RecordsPort)this).Get_Orientations(new Get_OrientationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Orientations_Request = Get_Orientations_Request
			}).Get_Orientations_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_OrientationsOutput> Student_RecordsPort.Get_OrientationsAsync(Get_OrientationsInput request)
		{
			return base.Channel.Get_OrientationsAsync(request);
		}

		public Task<Get_OrientationsOutput> Get_OrientationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Orientations_RequestType Get_Orientations_Request)
		{
			return ((Student_RecordsPort)this).Get_OrientationsAsync(new Get_OrientationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Orientations_Request = Get_Orientations_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_OrientationOutput Student_RecordsPort.Put_Orientation(Put_OrientationInput request)
		{
			return base.Channel.Put_Orientation(request);
		}

		public Put_Orientation_ResponseType Put_Orientation(Workday_Common_HeaderType Workday_Common_Header, Put_Orientation_RequestType Put_Orientation_Request)
		{
			return ((Student_RecordsPort)this).Put_Orientation(new Put_OrientationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Orientation_Request = Put_Orientation_Request
			}).Put_Orientation_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_OrientationOutput> Student_RecordsPort.Put_OrientationAsync(Put_OrientationInput request)
		{
			return base.Channel.Put_OrientationAsync(request);
		}

		public Task<Put_OrientationOutput> Put_OrientationAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Orientation_RequestType Put_Orientation_Request)
		{
			return ((Student_RecordsPort)this).Put_OrientationAsync(new Put_OrientationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Orientation_Request = Put_Orientation_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Study_Abroad_OfferingsOutput Student_RecordsPort.Get_Study_Abroad_Offerings(Get_Study_Abroad_OfferingsInput request)
		{
			return base.Channel.Get_Study_Abroad_Offerings(request);
		}

		public Get_Study_Abroad_Offerings_ResponseType Get_Study_Abroad_Offerings(Workday_Common_HeaderType Workday_Common_Header, Get_Study_Abroad_Offerings_RequestType Get_Study_Abroad_Offerings_Request)
		{
			return ((Student_RecordsPort)this).Get_Study_Abroad_Offerings(new Get_Study_Abroad_OfferingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Study_Abroad_Offerings_Request = Get_Study_Abroad_Offerings_Request
			}).Get_Study_Abroad_Offerings_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Study_Abroad_OfferingsOutput> Student_RecordsPort.Get_Study_Abroad_OfferingsAsync(Get_Study_Abroad_OfferingsInput request)
		{
			return base.Channel.Get_Study_Abroad_OfferingsAsync(request);
		}

		public Task<Get_Study_Abroad_OfferingsOutput> Get_Study_Abroad_OfferingsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Study_Abroad_Offerings_RequestType Get_Study_Abroad_Offerings_Request)
		{
			return ((Student_RecordsPort)this).Get_Study_Abroad_OfferingsAsync(new Get_Study_Abroad_OfferingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Study_Abroad_Offerings_Request = Get_Study_Abroad_Offerings_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Study_Abroad_OfferingOutput Student_RecordsPort.Put_Study_Abroad_Offering(Put_Study_Abroad_OfferingInput request)
		{
			return base.Channel.Put_Study_Abroad_Offering(request);
		}

		public Put_Study_Abroad_Offering_ResponseType Put_Study_Abroad_Offering(Workday_Common_HeaderType Workday_Common_Header, Put_Study_Abroad_Offering_RequestType Put_Study_Abroad_Offering_Request)
		{
			return ((Student_RecordsPort)this).Put_Study_Abroad_Offering(new Put_Study_Abroad_OfferingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Study_Abroad_Offering_Request = Put_Study_Abroad_Offering_Request
			}).Put_Study_Abroad_Offering_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Study_Abroad_OfferingOutput> Student_RecordsPort.Put_Study_Abroad_OfferingAsync(Put_Study_Abroad_OfferingInput request)
		{
			return base.Channel.Put_Study_Abroad_OfferingAsync(request);
		}

		public Task<Put_Study_Abroad_OfferingOutput> Put_Study_Abroad_OfferingAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Study_Abroad_Offering_RequestType Put_Study_Abroad_Offering_Request)
		{
			return ((Student_RecordsPort)this).Put_Study_Abroad_OfferingAsync(new Put_Study_Abroad_OfferingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Study_Abroad_Offering_Request = Put_Study_Abroad_Offering_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Course_Offering_SetsOutput Student_RecordsPort.Get_Course_Offering_Sets(Get_Course_Offering_SetsInput request)
		{
			return base.Channel.Get_Course_Offering_Sets(request);
		}

		public Get_Course_Offering_Sets_ResponseType Get_Course_Offering_Sets(Workday_Common_HeaderType Workday_Common_Header, Get_Course_Offering_Sets_RequestType Get_Course_Offering_Sets_Request)
		{
			return ((Student_RecordsPort)this).Get_Course_Offering_Sets(new Get_Course_Offering_SetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Course_Offering_Sets_Request = Get_Course_Offering_Sets_Request
			}).Get_Course_Offering_Sets_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Course_Offering_SetsOutput> Student_RecordsPort.Get_Course_Offering_SetsAsync(Get_Course_Offering_SetsInput request)
		{
			return base.Channel.Get_Course_Offering_SetsAsync(request);
		}

		public Task<Get_Course_Offering_SetsOutput> Get_Course_Offering_SetsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Course_Offering_Sets_RequestType Get_Course_Offering_Sets_Request)
		{
			return ((Student_RecordsPort)this).Get_Course_Offering_SetsAsync(new Get_Course_Offering_SetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Course_Offering_Sets_Request = Get_Course_Offering_Sets_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Course_Offering_SetOutput Student_RecordsPort.Put_Course_Offering_Set(Put_Course_Offering_SetInput request)
		{
			return base.Channel.Put_Course_Offering_Set(request);
		}

		public Put_Course_Offering_Set_ResponseType Put_Course_Offering_Set(Workday_Common_HeaderType Workday_Common_Header, Put_Course_Offering_Set_RequestType Put_Course_Offering_Set_Request)
		{
			return ((Student_RecordsPort)this).Put_Course_Offering_Set(new Put_Course_Offering_SetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Course_Offering_Set_Request = Put_Course_Offering_Set_Request
			}).Put_Course_Offering_Set_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Course_Offering_SetOutput> Student_RecordsPort.Put_Course_Offering_SetAsync(Put_Course_Offering_SetInput request)
		{
			return base.Channel.Put_Course_Offering_SetAsync(request);
		}

		public Task<Put_Course_Offering_SetOutput> Put_Course_Offering_SetAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Course_Offering_Set_RequestType Put_Course_Offering_Set_Request)
		{
			return ((Student_RecordsPort)this).Put_Course_Offering_SetAsync(new Put_Course_Offering_SetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Course_Offering_Set_Request = Put_Course_Offering_Set_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Course_MaterialsOutput Student_RecordsPort.Get_Student_Course_Materials(Get_Student_Course_MaterialsInput request)
		{
			return base.Channel.Get_Student_Course_Materials(request);
		}

		public Get_Student_Course_Materials_ResponseType Get_Student_Course_Materials(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Course_Materials_RequestType Get_Student_Course_Materials_Request)
		{
			return ((Student_RecordsPort)this).Get_Student_Course_Materials(new Get_Student_Course_MaterialsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Course_Materials_Request = Get_Student_Course_Materials_Request
			}).Get_Student_Course_Materials_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Course_MaterialsOutput> Student_RecordsPort.Get_Student_Course_MaterialsAsync(Get_Student_Course_MaterialsInput request)
		{
			return base.Channel.Get_Student_Course_MaterialsAsync(request);
		}

		public Task<Get_Student_Course_MaterialsOutput> Get_Student_Course_MaterialsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Course_Materials_RequestType Get_Student_Course_Materials_Request)
		{
			return ((Student_RecordsPort)this).Get_Student_Course_MaterialsAsync(new Get_Student_Course_MaterialsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Course_Materials_Request = Get_Student_Course_Materials_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Course_MaterialOutput Student_RecordsPort.Put_Student_Course_Material(Put_Student_Course_MaterialInput request)
		{
			return base.Channel.Put_Student_Course_Material(request);
		}

		public Put_Student_Course_Material_ResponseType Put_Student_Course_Material(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Course_Material_RequestType Put_Student_Course_Material_Request)
		{
			return ((Student_RecordsPort)this).Put_Student_Course_Material(new Put_Student_Course_MaterialInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Course_Material_Request = Put_Student_Course_Material_Request
			}).Put_Student_Course_Material_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Course_MaterialOutput> Student_RecordsPort.Put_Student_Course_MaterialAsync(Put_Student_Course_MaterialInput request)
		{
			return base.Channel.Put_Student_Course_MaterialAsync(request);
		}

		public Task<Put_Student_Course_MaterialOutput> Put_Student_Course_MaterialAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Course_Material_RequestType Put_Student_Course_Material_Request)
		{
			return ((Student_RecordsPort)this).Put_Student_Course_MaterialAsync(new Put_Student_Course_MaterialInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Course_Material_Request = Put_Student_Course_Material_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Course_RegistrationOutput Student_RecordsPort.Put_Student_Course_Registration(Put_Student_Course_RegistrationInput request)
		{
			return base.Channel.Put_Student_Course_Registration(request);
		}

		public Put_Student_Course_Registration_ResponseType Put_Student_Course_Registration(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Course_Registration_RequestType Put_Student_Course_Registration_Request)
		{
			return ((Student_RecordsPort)this).Put_Student_Course_Registration(new Put_Student_Course_RegistrationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Course_Registration_Request = Put_Student_Course_Registration_Request
			}).Put_Student_Course_Registration_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Course_RegistrationOutput> Student_RecordsPort.Put_Student_Course_RegistrationAsync(Put_Student_Course_RegistrationInput request)
		{
			return base.Channel.Put_Student_Course_RegistrationAsync(request);
		}

		public Task<Put_Student_Course_RegistrationOutput> Put_Student_Course_RegistrationAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Course_Registration_RequestType Put_Student_Course_Registration_Request)
		{
			return ((Student_RecordsPort)this).Put_Student_Course_RegistrationAsync(new Put_Student_Course_RegistrationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Course_Registration_Request = Put_Student_Course_Registration_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Course_RegistrationsOutput Student_RecordsPort.Get_Student_Course_Registrations(Get_Student_Course_RegistrationsInput request)
		{
			return base.Channel.Get_Student_Course_Registrations(request);
		}

		public Get_Student_Course_Registrations_ResponseType Get_Student_Course_Registrations(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Course_Registrations_RequestType Get_Student_Course_Registrations_Request)
		{
			return ((Student_RecordsPort)this).Get_Student_Course_Registrations(new Get_Student_Course_RegistrationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Course_Registrations_Request = Get_Student_Course_Registrations_Request
			}).Get_Student_Course_Registrations_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Course_RegistrationsOutput> Student_RecordsPort.Get_Student_Course_RegistrationsAsync(Get_Student_Course_RegistrationsInput request)
		{
			return base.Channel.Get_Student_Course_RegistrationsAsync(request);
		}

		public Task<Get_Student_Course_RegistrationsOutput> Get_Student_Course_RegistrationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Course_Registrations_RequestType Get_Student_Course_Registrations_Request)
		{
			return ((Student_RecordsPort)this).Get_Student_Course_RegistrationsAsync(new Get_Student_Course_RegistrationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Course_Registrations_Request = Get_Student_Course_Registrations_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_CompetenciesOutput Student_RecordsPort.Get_Student_Competencies(Get_Student_CompetenciesInput request)
		{
			return base.Channel.Get_Student_Competencies(request);
		}

		public Get_Student_Competencies_ResponseType Get_Student_Competencies(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Competencies_RequestType Get_Student_Competencies_Request)
		{
			return ((Student_RecordsPort)this).Get_Student_Competencies(new Get_Student_CompetenciesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Competencies_Request = Get_Student_Competencies_Request
			}).Get_Student_Competencies_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_CompetenciesOutput> Student_RecordsPort.Get_Student_CompetenciesAsync(Get_Student_CompetenciesInput request)
		{
			return base.Channel.Get_Student_CompetenciesAsync(request);
		}

		public Task<Get_Student_CompetenciesOutput> Get_Student_CompetenciesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Competencies_RequestType Get_Student_Competencies_Request)
		{
			return ((Student_RecordsPort)this).Get_Student_CompetenciesAsync(new Get_Student_CompetenciesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Competencies_Request = Get_Student_Competencies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_CompetencyOutput Student_RecordsPort.Put_Student_Competency(Put_Student_CompetencyInput request)
		{
			return base.Channel.Put_Student_Competency(request);
		}

		public Put_Student_Competency_ResponseType Put_Student_Competency(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Competency_RequestType Put_Student_Competency_Request)
		{
			return ((Student_RecordsPort)this).Put_Student_Competency(new Put_Student_CompetencyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Competency_Request = Put_Student_Competency_Request
			}).Put_Student_Competency_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_CompetencyOutput> Student_RecordsPort.Put_Student_CompetencyAsync(Put_Student_CompetencyInput request)
		{
			return base.Channel.Put_Student_CompetencyAsync(request);
		}

		public Task<Put_Student_CompetencyOutput> Put_Student_CompetencyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Competency_RequestType Put_Student_Competency_Request)
		{
			return ((Student_RecordsPort)this).Put_Student_CompetencyAsync(new Put_Student_CompetencyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Competency_Request = Put_Student_Competency_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Activity_Registration_RecordsOutput Student_RecordsPort.Get_Student_Activity_Registration_Records(Get_Student_Activity_Registration_RecordsInput request)
		{
			return base.Channel.Get_Student_Activity_Registration_Records(request);
		}

		public Get_Student_Activity_Registration_Records_ResponseType Get_Student_Activity_Registration_Records(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Activity_Registration_Records_RequestType Get_Student_Activity_Registration_Records_Request)
		{
			return ((Student_RecordsPort)this).Get_Student_Activity_Registration_Records(new Get_Student_Activity_Registration_RecordsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Activity_Registration_Records_Request = Get_Student_Activity_Registration_Records_Request
			}).Get_Student_Activity_Registration_Records_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Activity_Registration_RecordsOutput> Student_RecordsPort.Get_Student_Activity_Registration_RecordsAsync(Get_Student_Activity_Registration_RecordsInput request)
		{
			return base.Channel.Get_Student_Activity_Registration_RecordsAsync(request);
		}

		public Task<Get_Student_Activity_Registration_RecordsOutput> Get_Student_Activity_Registration_RecordsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Activity_Registration_Records_RequestType Get_Student_Activity_Registration_Records_Request)
		{
			return ((Student_RecordsPort)this).Get_Student_Activity_Registration_RecordsAsync(new Get_Student_Activity_Registration_RecordsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Activity_Registration_Records_Request = Get_Student_Activity_Registration_Records_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Activity_Registration_RecordOutput Student_RecordsPort.Put_Student_Activity_Registration_Record(Put_Student_Activity_Registration_RecordInput request)
		{
			return base.Channel.Put_Student_Activity_Registration_Record(request);
		}

		public Put_Student_Activity_Registration_Record_ResponseType Put_Student_Activity_Registration_Record(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Activity_Registration_Record_RequestType Put_Student_Activity_Registration_Record_Request)
		{
			return ((Student_RecordsPort)this).Put_Student_Activity_Registration_Record(new Put_Student_Activity_Registration_RecordInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Activity_Registration_Record_Request = Put_Student_Activity_Registration_Record_Request
			}).Put_Student_Activity_Registration_Record_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Activity_Registration_RecordOutput> Student_RecordsPort.Put_Student_Activity_Registration_RecordAsync(Put_Student_Activity_Registration_RecordInput request)
		{
			return base.Channel.Put_Student_Activity_Registration_RecordAsync(request);
		}

		public Task<Put_Student_Activity_Registration_RecordOutput> Put_Student_Activity_Registration_RecordAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Activity_Registration_Record_RequestType Put_Student_Activity_Registration_Record_Request)
		{
			return ((Student_RecordsPort)this).Put_Student_Activity_Registration_RecordAsync(new Put_Student_Activity_Registration_RecordInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Activity_Registration_Record_Request = Put_Student_Activity_Registration_Record_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Practical_LearningOutput Student_RecordsPort.Put_Practical_Learning(Put_Practical_LearningInput request)
		{
			return base.Channel.Put_Practical_Learning(request);
		}

		public Put_Practical_Learning_ResponseType Put_Practical_Learning(Workday_Common_HeaderType Workday_Common_Header, Put_Practical_Learning_RequestType Put_Practical_Learning_Request)
		{
			return ((Student_RecordsPort)this).Put_Practical_Learning(new Put_Practical_LearningInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Practical_Learning_Request = Put_Practical_Learning_Request
			}).Put_Practical_Learning_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Practical_LearningOutput> Student_RecordsPort.Put_Practical_LearningAsync(Put_Practical_LearningInput request)
		{
			return base.Channel.Put_Practical_LearningAsync(request);
		}

		public Task<Put_Practical_LearningOutput> Put_Practical_LearningAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Practical_Learning_RequestType Put_Practical_Learning_Request)
		{
			return ((Student_RecordsPort)this).Put_Practical_LearningAsync(new Put_Practical_LearningInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Practical_Learning_Request = Put_Practical_Learning_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Practical_LearningsOutput Student_RecordsPort.Get_Practical_Learnings(Get_Practical_LearningsInput request)
		{
			return base.Channel.Get_Practical_Learnings(request);
		}

		public Get_Practical_Learnings_ResponseType Get_Practical_Learnings(Workday_Common_HeaderType Workday_Common_Header, Get_Practical_Learnings_RequestType Get_Practical_Learnings_Request)
		{
			return ((Student_RecordsPort)this).Get_Practical_Learnings(new Get_Practical_LearningsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Practical_Learnings_Request = Get_Practical_Learnings_Request
			}).Get_Practical_Learnings_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Practical_LearningsOutput> Student_RecordsPort.Get_Practical_LearningsAsync(Get_Practical_LearningsInput request)
		{
			return base.Channel.Get_Practical_LearningsAsync(request);
		}

		public Task<Get_Practical_LearningsOutput> Get_Practical_LearningsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Practical_Learnings_RequestType Get_Practical_Learnings_Request)
		{
			return ((Student_RecordsPort)this).Get_Practical_LearningsAsync(new Get_Practical_LearningsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Practical_Learnings_Request = Get_Practical_Learnings_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_AccomplishmentsOutput Student_RecordsPort.Get_Student_Accomplishments(Get_Student_AccomplishmentsInput request)
		{
			return base.Channel.Get_Student_Accomplishments(request);
		}

		public Get_Student_Accomplishments_ResponseType Get_Student_Accomplishments(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Accomplishments_RequestType Get_Student_Accomplishments_Request)
		{
			return ((Student_RecordsPort)this).Get_Student_Accomplishments(new Get_Student_AccomplishmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Accomplishments_Request = Get_Student_Accomplishments_Request
			}).Get_Student_Accomplishments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_AccomplishmentsOutput> Student_RecordsPort.Get_Student_AccomplishmentsAsync(Get_Student_AccomplishmentsInput request)
		{
			return base.Channel.Get_Student_AccomplishmentsAsync(request);
		}

		public Task<Get_Student_AccomplishmentsOutput> Get_Student_AccomplishmentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Accomplishments_RequestType Get_Student_Accomplishments_Request)
		{
			return ((Student_RecordsPort)this).Get_Student_AccomplishmentsAsync(new Get_Student_AccomplishmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Accomplishments_Request = Get_Student_Accomplishments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_AccomplishmentOutput Student_RecordsPort.Put_Student_Accomplishment(Put_Student_AccomplishmentInput request)
		{
			return base.Channel.Put_Student_Accomplishment(request);
		}

		public Put_Student_Accomplishment_ResponseType Put_Student_Accomplishment(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Accomplishment_RequestType Put_Student_Accomplishment_Request)
		{
			return ((Student_RecordsPort)this).Put_Student_Accomplishment(new Put_Student_AccomplishmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Accomplishment_Request = Put_Student_Accomplishment_Request
			}).Put_Student_Accomplishment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_AccomplishmentOutput> Student_RecordsPort.Put_Student_AccomplishmentAsync(Put_Student_AccomplishmentInput request)
		{
			return base.Channel.Put_Student_AccomplishmentAsync(request);
		}

		public Task<Put_Student_AccomplishmentOutput> Put_Student_AccomplishmentAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Accomplishment_RequestType Put_Student_Accomplishment_Request)
		{
			return ((Student_RecordsPort)this).Put_Student_AccomplishmentAsync(new Put_Student_AccomplishmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Accomplishment_Request = Put_Student_Accomplishment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Practical_Learning_OfferingsOutput Student_RecordsPort.Get_Practical_Learning_Offerings(Get_Practical_Learning_OfferingsInput request)
		{
			return base.Channel.Get_Practical_Learning_Offerings(request);
		}

		public Get_Practical_Learning_Offerings_ResponseType Get_Practical_Learning_Offerings(Workday_Common_HeaderType Workday_Common_Header, Get_Practical_Learning_Offerings_RequestType Get_Practical_Learning_Offerings_Request)
		{
			return ((Student_RecordsPort)this).Get_Practical_Learning_Offerings(new Get_Practical_Learning_OfferingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Practical_Learning_Offerings_Request = Get_Practical_Learning_Offerings_Request
			}).Get_Practical_Learning_Offerings_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Practical_Learning_OfferingsOutput> Student_RecordsPort.Get_Practical_Learning_OfferingsAsync(Get_Practical_Learning_OfferingsInput request)
		{
			return base.Channel.Get_Practical_Learning_OfferingsAsync(request);
		}

		public Task<Get_Practical_Learning_OfferingsOutput> Get_Practical_Learning_OfferingsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Practical_Learning_Offerings_RequestType Get_Practical_Learning_Offerings_Request)
		{
			return ((Student_RecordsPort)this).Get_Practical_Learning_OfferingsAsync(new Get_Practical_Learning_OfferingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Practical_Learning_Offerings_Request = Get_Practical_Learning_Offerings_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Practical_Learning_OfferingOutput Student_RecordsPort.Put_Practical_Learning_Offering(Put_Practical_Learning_OfferingInput request)
		{
			return base.Channel.Put_Practical_Learning_Offering(request);
		}

		public Put_Practical_Learning_Offering_ResponseType Put_Practical_Learning_Offering(Workday_Common_HeaderType Workday_Common_Header, Put_Practical_Learning_Offering_RequestType Put_Practical_Learning_Offering_Request)
		{
			return ((Student_RecordsPort)this).Put_Practical_Learning_Offering(new Put_Practical_Learning_OfferingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Practical_Learning_Offering_Request = Put_Practical_Learning_Offering_Request
			}).Put_Practical_Learning_Offering_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Practical_Learning_OfferingOutput> Student_RecordsPort.Put_Practical_Learning_OfferingAsync(Put_Practical_Learning_OfferingInput request)
		{
			return base.Channel.Put_Practical_Learning_OfferingAsync(request);
		}

		public Task<Put_Practical_Learning_OfferingOutput> Put_Practical_Learning_OfferingAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Practical_Learning_Offering_RequestType Put_Practical_Learning_Offering_Request)
		{
			return ((Student_RecordsPort)this).Put_Practical_Learning_OfferingAsync(new Put_Practical_Learning_OfferingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Practical_Learning_Offering_Request = Put_Practical_Learning_Offering_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Grades_for_RegistrationsOutput Student_RecordsPort.Submit_Grades_for_Registrations(Submit_Grades_for_RegistrationsInput request)
		{
			return base.Channel.Submit_Grades_for_Registrations(request);
		}

		public Submit_Grades_for_Registrations_ResponseType Submit_Grades_for_Registrations(Workday_Common_HeaderType Workday_Common_Header, Submit_Grades_for_Registrations_RequestType Submit_Grades_for_Registrations_Request)
		{
			return ((Student_RecordsPort)this).Submit_Grades_for_Registrations(new Submit_Grades_for_RegistrationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Grades_for_Registrations_Request = Submit_Grades_for_Registrations_Request
			}).Submit_Grades_for_Registrations_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Grades_for_RegistrationsOutput> Student_RecordsPort.Submit_Grades_for_RegistrationsAsync(Submit_Grades_for_RegistrationsInput request)
		{
			return base.Channel.Submit_Grades_for_RegistrationsAsync(request);
		}

		public Task<Submit_Grades_for_RegistrationsOutput> Submit_Grades_for_RegistrationsAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Grades_for_Registrations_RequestType Submit_Grades_for_Registrations_Request)
		{
			return ((Student_RecordsPort)this).Submit_Grades_for_RegistrationsAsync(new Submit_Grades_for_RegistrationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Grades_for_Registrations_Request = Submit_Grades_for_Registrations_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Transcript_OrderOutput Student_RecordsPort.Put_Transcript_Order(Put_Transcript_OrderInput request)
		{
			return base.Channel.Put_Transcript_Order(request);
		}

		public Put_Transcript_Order_ResponseType Put_Transcript_Order(Workday_Common_HeaderType Workday_Common_Header, Put_Transcript_Order_RequestType Put_Transcript_Order_Request)
		{
			return ((Student_RecordsPort)this).Put_Transcript_Order(new Put_Transcript_OrderInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Transcript_Order_Request = Put_Transcript_Order_Request
			}).Put_Transcript_Order_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Transcript_OrderOutput> Student_RecordsPort.Put_Transcript_OrderAsync(Put_Transcript_OrderInput request)
		{
			return base.Channel.Put_Transcript_OrderAsync(request);
		}

		public Task<Put_Transcript_OrderOutput> Put_Transcript_OrderAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Transcript_Order_RequestType Put_Transcript_Order_Request)
		{
			return ((Student_RecordsPort)this).Put_Transcript_OrderAsync(new Put_Transcript_OrderInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Transcript_Order_Request = Put_Transcript_Order_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Transcript_OrdersOutput Student_RecordsPort.Get_Transcript_Orders(Get_Transcript_OrdersInput request)
		{
			return base.Channel.Get_Transcript_Orders(request);
		}

		public Get_Transcript_Orders_ResponseType Get_Transcript_Orders(Workday_Common_HeaderType Workday_Common_Header, Get_Transcript_Orders_RequestType Get_Transcript_Orders_Request)
		{
			return ((Student_RecordsPort)this).Get_Transcript_Orders(new Get_Transcript_OrdersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Transcript_Orders_Request = Get_Transcript_Orders_Request
			}).Get_Transcript_Orders_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Transcript_OrdersOutput> Student_RecordsPort.Get_Transcript_OrdersAsync(Get_Transcript_OrdersInput request)
		{
			return base.Channel.Get_Transcript_OrdersAsync(request);
		}

		public Task<Get_Transcript_OrdersOutput> Get_Transcript_OrdersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Transcript_Orders_RequestType Get_Transcript_Orders_Request)
		{
			return ((Student_RecordsPort)this).Get_Transcript_OrdersAsync(new Get_Transcript_OrdersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Transcript_Orders_Request = Get_Transcript_Orders_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Course_Registered_RegistrationOutput Student_RecordsPort.Put_Student_Course_Registered_Registration(Put_Student_Course_Registered_RegistrationInput request)
		{
			return base.Channel.Put_Student_Course_Registered_Registration(request);
		}

		public Put_Student_Course_Registered_Registration_ResponseType Put_Student_Course_Registered_Registration(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Course_Registered_Registration_RequestType Put_Student_Course_Registered_Registration_Request)
		{
			return ((Student_RecordsPort)this).Put_Student_Course_Registered_Registration(new Put_Student_Course_Registered_RegistrationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Course_Registered_Registration_Request = Put_Student_Course_Registered_Registration_Request
			}).Put_Student_Course_Registered_Registration_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Course_Registered_RegistrationOutput> Student_RecordsPort.Put_Student_Course_Registered_RegistrationAsync(Put_Student_Course_Registered_RegistrationInput request)
		{
			return base.Channel.Put_Student_Course_Registered_RegistrationAsync(request);
		}

		public Task<Put_Student_Course_Registered_RegistrationOutput> Put_Student_Course_Registered_RegistrationAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Course_Registered_Registration_RequestType Put_Student_Course_Registered_Registration_Request)
		{
			return ((Student_RecordsPort)this).Put_Student_Course_Registered_RegistrationAsync(new Put_Student_Course_Registered_RegistrationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Course_Registered_Registration_Request = Put_Student_Course_Registered_Registration_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Course_Dropped_RegistrationOutput Student_RecordsPort.Put_Student_Course_Dropped_Registration(Put_Student_Course_Dropped_RegistrationInput request)
		{
			return base.Channel.Put_Student_Course_Dropped_Registration(request);
		}

		public Put_Student_Course_Dropped_Registration_ResponseType Put_Student_Course_Dropped_Registration(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Course_Dropped_Registration_RequestType Put_Student_Course_Dropped_Registration_Request)
		{
			return ((Student_RecordsPort)this).Put_Student_Course_Dropped_Registration(new Put_Student_Course_Dropped_RegistrationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Course_Dropped_Registration_Request = Put_Student_Course_Dropped_Registration_Request
			}).Put_Student_Course_Dropped_Registration_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Course_Dropped_RegistrationOutput> Student_RecordsPort.Put_Student_Course_Dropped_RegistrationAsync(Put_Student_Course_Dropped_RegistrationInput request)
		{
			return base.Channel.Put_Student_Course_Dropped_RegistrationAsync(request);
		}

		public Task<Put_Student_Course_Dropped_RegistrationOutput> Put_Student_Course_Dropped_RegistrationAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Course_Dropped_Registration_RequestType Put_Student_Course_Dropped_Registration_Request)
		{
			return ((Student_RecordsPort)this).Put_Student_Course_Dropped_RegistrationAsync(new Put_Student_Course_Dropped_RegistrationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Course_Dropped_Registration_Request = Put_Student_Course_Dropped_Registration_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Student_Course_Withdraw_RegistrationOutput Student_RecordsPort.Submit_Student_Course_Withdraw_Registration(Submit_Student_Course_Withdraw_RegistrationInput request)
		{
			return base.Channel.Submit_Student_Course_Withdraw_Registration(request);
		}

		public Submit_Student_Course_Withdraw_Registration_ResponseType Submit_Student_Course_Withdraw_Registration(Workday_Common_HeaderType Workday_Common_Header, Submit_Student_Course_Withdraw_Registration_RequestType Submit_Student_Course_Withdraw_Registration_Request)
		{
			return ((Student_RecordsPort)this).Submit_Student_Course_Withdraw_Registration(new Submit_Student_Course_Withdraw_RegistrationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Student_Course_Withdraw_Registration_Request = Submit_Student_Course_Withdraw_Registration_Request
			}).Submit_Student_Course_Withdraw_Registration_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Student_Course_Withdraw_RegistrationOutput> Student_RecordsPort.Submit_Student_Course_Withdraw_RegistrationAsync(Submit_Student_Course_Withdraw_RegistrationInput request)
		{
			return base.Channel.Submit_Student_Course_Withdraw_RegistrationAsync(request);
		}

		public Task<Submit_Student_Course_Withdraw_RegistrationOutput> Submit_Student_Course_Withdraw_RegistrationAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Student_Course_Withdraw_Registration_RequestType Submit_Student_Course_Withdraw_Registration_Request)
		{
			return ((Student_RecordsPort)this).Submit_Student_Course_Withdraw_RegistrationAsync(new Submit_Student_Course_Withdraw_RegistrationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Student_Course_Withdraw_Registration_Request = Submit_Student_Course_Withdraw_Registration_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Change_Program_of_StudyOutput Student_RecordsPort.Submit_Change_Program_of_Study(Submit_Change_Program_of_StudyInput request)
		{
			return base.Channel.Submit_Change_Program_of_Study(request);
		}

		public Submit_Change_Program_of_Study_ResponseType Submit_Change_Program_of_Study(Workday_Common_HeaderType Workday_Common_Header, Submit_Change_Program_of_Study_RequestType Submit_Change_Program_of_Study_Request)
		{
			return ((Student_RecordsPort)this).Submit_Change_Program_of_Study(new Submit_Change_Program_of_StudyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Change_Program_of_Study_Request = Submit_Change_Program_of_Study_Request
			}).Submit_Change_Program_of_Study_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Change_Program_of_StudyOutput> Student_RecordsPort.Submit_Change_Program_of_StudyAsync(Submit_Change_Program_of_StudyInput request)
		{
			return base.Channel.Submit_Change_Program_of_StudyAsync(request);
		}

		public Task<Submit_Change_Program_of_StudyOutput> Submit_Change_Program_of_StudyAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Change_Program_of_Study_RequestType Submit_Change_Program_of_Study_Request)
		{
			return ((Student_RecordsPort)this).Submit_Change_Program_of_StudyAsync(new Submit_Change_Program_of_StudyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Change_Program_of_Study_Request = Submit_Change_Program_of_Study_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Add_Program_of_StudyOutput Student_RecordsPort.Submit_Add_Program_of_Study(Submit_Add_Program_of_StudyInput request)
		{
			return base.Channel.Submit_Add_Program_of_Study(request);
		}

		public Submit_Add_Program_of_Study_ResponseType Submit_Add_Program_of_Study(Workday_Common_HeaderType Workday_Common_Header, Submit_Add_Program_of_Study_RequestType Submit_Add_Program_of_Study_Request)
		{
			return ((Student_RecordsPort)this).Submit_Add_Program_of_Study(new Submit_Add_Program_of_StudyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Add_Program_of_Study_Request = Submit_Add_Program_of_Study_Request
			}).Submit_Add_Program_of_Study_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Add_Program_of_StudyOutput> Student_RecordsPort.Submit_Add_Program_of_StudyAsync(Submit_Add_Program_of_StudyInput request)
		{
			return base.Channel.Submit_Add_Program_of_StudyAsync(request);
		}

		public Task<Submit_Add_Program_of_StudyOutput> Submit_Add_Program_of_StudyAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Add_Program_of_Study_RequestType Submit_Add_Program_of_Study_Request)
		{
			return ((Student_RecordsPort)this).Submit_Add_Program_of_StudyAsync(new Submit_Add_Program_of_StudyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Add_Program_of_Study_Request = Submit_Add_Program_of_Study_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Remove_Program_of_StudyOutput Student_RecordsPort.Submit_Remove_Program_of_Study(Submit_Remove_Program_of_StudyInput request)
		{
			return base.Channel.Submit_Remove_Program_of_Study(request);
		}

		public Submit_Remove_Program_of_Study_ResponseType Submit_Remove_Program_of_Study(Workday_Common_HeaderType Workday_Common_Header, Submit_Remove_Program_of_Study_RequestType Submit_Remove_Program_of_Study_Request)
		{
			return ((Student_RecordsPort)this).Submit_Remove_Program_of_Study(new Submit_Remove_Program_of_StudyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Remove_Program_of_Study_Request = Submit_Remove_Program_of_Study_Request
			}).Submit_Remove_Program_of_Study_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Remove_Program_of_StudyOutput> Student_RecordsPort.Submit_Remove_Program_of_StudyAsync(Submit_Remove_Program_of_StudyInput request)
		{
			return base.Channel.Submit_Remove_Program_of_StudyAsync(request);
		}

		public Task<Submit_Remove_Program_of_StudyOutput> Submit_Remove_Program_of_StudyAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Remove_Program_of_Study_RequestType Submit_Remove_Program_of_Study_Request)
		{
			return ((Student_RecordsPort)this).Submit_Remove_Program_of_StudyAsync(new Submit_Remove_Program_of_StudyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Remove_Program_of_Study_Request = Submit_Remove_Program_of_Study_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Courses_without_DependenciesOutput Student_RecordsPort.Get_Student_Courses_without_Dependencies(Get_Student_Courses_without_DependenciesInput request)
		{
			return base.Channel.Get_Student_Courses_without_Dependencies(request);
		}

		public Get_Student_Courses_without_Dependencies_ResponseType Get_Student_Courses_without_Dependencies(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Courses_without_Dependencies_RequestType Get_Student_Courses_without_Dependencies_Request)
		{
			return ((Student_RecordsPort)this).Get_Student_Courses_without_Dependencies(new Get_Student_Courses_without_DependenciesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Courses_without_Dependencies_Request = Get_Student_Courses_without_Dependencies_Request
			}).Get_Student_Courses_without_Dependencies_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Courses_without_DependenciesOutput> Student_RecordsPort.Get_Student_Courses_without_DependenciesAsync(Get_Student_Courses_without_DependenciesInput request)
		{
			return base.Channel.Get_Student_Courses_without_DependenciesAsync(request);
		}

		public Task<Get_Student_Courses_without_DependenciesOutput> Get_Student_Courses_without_DependenciesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Courses_without_Dependencies_RequestType Get_Student_Courses_without_Dependencies_Request)
		{
			return ((Student_RecordsPort)this).Get_Student_Courses_without_DependenciesAsync(new Get_Student_Courses_without_DependenciesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Courses_without_Dependencies_Request = Get_Student_Courses_without_Dependencies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Student_Course_RegistrationsOutput Student_RecordsPort.Import_Student_Course_Registrations(Import_Student_Course_RegistrationsInput request)
		{
			return base.Channel.Import_Student_Course_Registrations(request);
		}

		public Put_Import_Process_ResponseType Import_Student_Course_Registrations(Workday_Common_HeaderType Workday_Common_Header, Import_Student_Course_Registration_RequestType Import_Student_Course_Registration_Request)
		{
			return ((Student_RecordsPort)this).Import_Student_Course_Registrations(new Import_Student_Course_RegistrationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Student_Course_Registration_Request = Import_Student_Course_Registration_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Student_Course_RegistrationsOutput> Student_RecordsPort.Import_Student_Course_RegistrationsAsync(Import_Student_Course_RegistrationsInput request)
		{
			return base.Channel.Import_Student_Course_RegistrationsAsync(request);
		}

		public Task<Import_Student_Course_RegistrationsOutput> Import_Student_Course_RegistrationsAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Student_Course_Registration_RequestType Import_Student_Course_Registration_Request)
		{
			return ((Student_RecordsPort)this).Import_Student_Course_RegistrationsAsync(new Import_Student_Course_RegistrationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Student_Course_Registration_Request = Import_Student_Course_Registration_Request
			});
		}
	}
}
