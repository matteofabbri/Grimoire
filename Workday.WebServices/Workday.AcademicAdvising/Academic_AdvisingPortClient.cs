using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.AcademicAdvising
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Academic_AdvisingPortClient : ClientBase<Academic_AdvisingPort>, Academic_AdvisingPort
	{
		public Academic_AdvisingPortClient()
		{
		}

		public Academic_AdvisingPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Academic_AdvisingPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Academic_AdvisingPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Academic_AdvisingPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Academic_Progress_for_StudentOutput Academic_AdvisingPort.Get_Academic_Progress_for_Student(Get_Academic_Progress_for_StudentInput request)
		{
			return base.Channel.Get_Academic_Progress_for_Student(request);
		}

		public Get_Academic_Progress_for_Student_ResponseType Get_Academic_Progress_for_Student(Workday_Common_HeaderType Workday_Common_Header, Get_Academic_Progress_for_Student_RequestType Get_Academic_Progress_for_Student_Request)
		{
			return ((Academic_AdvisingPort)this).Get_Academic_Progress_for_Student(new Get_Academic_Progress_for_StudentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Academic_Progress_for_Student_Request = Get_Academic_Progress_for_Student_Request
			}).Get_Academic_Progress_for_Student_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Academic_Progress_for_StudentOutput> Academic_AdvisingPort.Get_Academic_Progress_for_StudentAsync(Get_Academic_Progress_for_StudentInput request)
		{
			return base.Channel.Get_Academic_Progress_for_StudentAsync(request);
		}

		public Task<Get_Academic_Progress_for_StudentOutput> Get_Academic_Progress_for_StudentAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Academic_Progress_for_Student_RequestType Get_Academic_Progress_for_Student_Request)
		{
			return ((Academic_AdvisingPort)this).Get_Academic_Progress_for_StudentAsync(new Get_Academic_Progress_for_StudentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Academic_Progress_for_Student_Request = Get_Academic_Progress_for_Student_Request
			});
		}
	}
}
