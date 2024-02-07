using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.CompensationReview
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Compensation_ReviewPortClient : ClientBase<Compensation_ReviewPort>, Compensation_ReviewPort
	{
		public Compensation_ReviewPortClient()
		{
		}

		public Compensation_ReviewPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Compensation_ReviewPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Compensation_ReviewPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Compensation_ReviewPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Budget_PoolsOutput Compensation_ReviewPort.Get_Budget_Pools(Get_Budget_PoolsInput request)
		{
			return base.Channel.Get_Budget_Pools(request);
		}

		public Get_Budget_Pools_ResponseType Get_Budget_Pools(Workday_Common_HeaderType Workday_Common_Header, Get_Budget_Pools_RequestType Get_Budget_Pools_Request)
		{
			return ((Compensation_ReviewPort)this).Get_Budget_Pools(new Get_Budget_PoolsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Budget_Pools_Request = Get_Budget_Pools_Request
			}).Get_Budget_Pools_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Budget_PoolsOutput> Compensation_ReviewPort.Get_Budget_PoolsAsync(Get_Budget_PoolsInput request)
		{
			return base.Channel.Get_Budget_PoolsAsync(request);
		}

		public Task<Get_Budget_PoolsOutput> Get_Budget_PoolsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Budget_Pools_RequestType Get_Budget_Pools_Request)
		{
			return ((Compensation_ReviewPort)this).Get_Budget_PoolsAsync(new Get_Budget_PoolsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Budget_Pools_Request = Get_Budget_Pools_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Employee_AwardsOutput Compensation_ReviewPort.Get_Employee_Awards(Get_Employee_AwardsInput request)
		{
			return base.Channel.Get_Employee_Awards(request);
		}

		public Get_Employee_Awards_ResponseType Get_Employee_Awards(Workday_Common_HeaderType Workday_Common_Header, Get_Employee_Awards_RequestType Get_Employee_Awards_Request)
		{
			return ((Compensation_ReviewPort)this).Get_Employee_Awards(new Get_Employee_AwardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Employee_Awards_Request = Get_Employee_Awards_Request
			}).Get_Employee_Awards_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Employee_AwardsOutput> Compensation_ReviewPort.Get_Employee_AwardsAsync(Get_Employee_AwardsInput request)
		{
			return base.Channel.Get_Employee_AwardsAsync(request);
		}

		public Task<Get_Employee_AwardsOutput> Get_Employee_AwardsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Employee_Awards_RequestType Get_Employee_Awards_Request)
		{
			return ((Compensation_ReviewPort)this).Get_Employee_AwardsAsync(new Get_Employee_AwardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Employee_Awards_Request = Get_Employee_Awards_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Budget_PoolsOutput Compensation_ReviewPort.Import_Budget_Pools(Import_Budget_PoolsInput request)
		{
			return base.Channel.Import_Budget_Pools(request);
		}

		public Put_Import_Process_ResponseType Import_Budget_Pools(Workday_Common_HeaderType Workday_Common_Header, Import_Budget_Pool_RequestType Import_Budget_Pool_Request)
		{
			return ((Compensation_ReviewPort)this).Import_Budget_Pools(new Import_Budget_PoolsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Budget_Pool_Request = Import_Budget_Pool_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Budget_PoolsOutput> Compensation_ReviewPort.Import_Budget_PoolsAsync(Import_Budget_PoolsInput request)
		{
			return base.Channel.Import_Budget_PoolsAsync(request);
		}

		public Task<Import_Budget_PoolsOutput> Import_Budget_PoolsAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Budget_Pool_RequestType Import_Budget_Pool_Request)
		{
			return ((Compensation_ReviewPort)this).Import_Budget_PoolsAsync(new Import_Budget_PoolsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Budget_Pool_Request = Import_Budget_Pool_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Budget_PoolsOutput Compensation_ReviewPort.Import_Employee_Awards(Import_Employee_AwardsInput request)
		{
			return base.Channel.Import_Employee_Awards(request);
		}

		public Put_Import_Process_ResponseType Import_Employee_Awards(Workday_Common_HeaderType Workday_Common_Header, Import_Employee_Awards_RequestType Import_Employee_Awards_Request)
		{
			return ((Compensation_ReviewPort)this).Import_Employee_Awards(new Import_Employee_AwardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Employee_Awards_Request = Import_Employee_Awards_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Budget_PoolsOutput> Compensation_ReviewPort.Import_Employee_AwardsAsync(Import_Employee_AwardsInput request)
		{
			return base.Channel.Import_Employee_AwardsAsync(request);
		}

		public Task<Import_Budget_PoolsOutput> Import_Employee_AwardsAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Employee_Awards_RequestType Import_Employee_Awards_Request)
		{
			return ((Compensation_ReviewPort)this).Import_Employee_AwardsAsync(new Import_Employee_AwardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Employee_Awards_Request = Import_Employee_Awards_Request
			});
		}
	}
}
