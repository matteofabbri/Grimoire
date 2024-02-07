using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.WorkforcePlanning
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Workforce_PlanningPortClient : ClientBase<Workforce_PlanningPort>, Workforce_PlanningPort
	{
		public Workforce_PlanningPortClient()
		{
		}

		public Workforce_PlanningPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Workforce_PlanningPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Workforce_PlanningPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Workforce_PlanningPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Headcount_Plan_StructuresOutput Workforce_PlanningPort.Get_Headcount_Plan_Structures(Get_Headcount_Plan_StructuresInput request)
		{
			return base.Channel.Get_Headcount_Plan_Structures(request);
		}

		public Get_Headcount_Plan_Structures_ResponseType Get_Headcount_Plan_Structures(Workday_Common_HeaderType Workday_Common_Header, Get_Headcount_Plan_Structures_RequestType Get_Headcount_Plan_Structures_Request)
		{
			return ((Workforce_PlanningPort)this).Get_Headcount_Plan_Structures(new Get_Headcount_Plan_StructuresInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Headcount_Plan_Structures_Request = Get_Headcount_Plan_Structures_Request
			}).Get_Headcount_Plan_Structures_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Headcount_Plan_StructuresOutput> Workforce_PlanningPort.Get_Headcount_Plan_StructuresAsync(Get_Headcount_Plan_StructuresInput request)
		{
			return base.Channel.Get_Headcount_Plan_StructuresAsync(request);
		}

		public Task<Get_Headcount_Plan_StructuresOutput> Get_Headcount_Plan_StructuresAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Headcount_Plan_Structures_RequestType Get_Headcount_Plan_Structures_Request)
		{
			return ((Workforce_PlanningPort)this).Get_Headcount_Plan_StructuresAsync(new Get_Headcount_Plan_StructuresInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Headcount_Plan_Structures_Request = Get_Headcount_Plan_Structures_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Headcount_Plan_StructureOutput Workforce_PlanningPort.Put_Headcount_Plan_Structure(Put_Headcount_Plan_StructureInput request)
		{
			return base.Channel.Put_Headcount_Plan_Structure(request);
		}

		public Put_Headcount_Plan_Structure_ResponseType Put_Headcount_Plan_Structure(Workday_Common_HeaderType Workday_Common_Header, Put_Headcount_Plan_Structure_RequestType Put_Headcount_Plan_Structure_Request)
		{
			return ((Workforce_PlanningPort)this).Put_Headcount_Plan_Structure(new Put_Headcount_Plan_StructureInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Headcount_Plan_Structure_Request = Put_Headcount_Plan_Structure_Request
			}).Put_Headcount_Plan_Structure_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Headcount_Plan_StructureOutput> Workforce_PlanningPort.Put_Headcount_Plan_StructureAsync(Put_Headcount_Plan_StructureInput request)
		{
			return base.Channel.Put_Headcount_Plan_StructureAsync(request);
		}

		public Task<Put_Headcount_Plan_StructureOutput> Put_Headcount_Plan_StructureAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Headcount_Plan_Structure_RequestType Put_Headcount_Plan_Structure_Request)
		{
			return ((Workforce_PlanningPort)this).Put_Headcount_Plan_StructureAsync(new Put_Headcount_Plan_StructureInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Headcount_Plan_Structure_Request = Put_Headcount_Plan_Structure_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Maintain_Headcount_PlanOutput Workforce_PlanningPort.Maintain_Headcount_Plan(Maintain_Headcount_PlanInput request)
		{
			return base.Channel.Maintain_Headcount_Plan(request);
		}

		public Maintain_Headcount_Plan_ResponseType Maintain_Headcount_Plan(Workday_Common_HeaderType Workday_Common_Header, Maintain_Headcount_Plan_RequestType Maintain_Headcount_Plan_Request)
		{
			return ((Workforce_PlanningPort)this).Maintain_Headcount_Plan(new Maintain_Headcount_PlanInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Maintain_Headcount_Plan_Request = Maintain_Headcount_Plan_Request
			}).Maintain_Headcount_Plan_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Maintain_Headcount_PlanOutput> Workforce_PlanningPort.Maintain_Headcount_PlanAsync(Maintain_Headcount_PlanInput request)
		{
			return base.Channel.Maintain_Headcount_PlanAsync(request);
		}

		public Task<Maintain_Headcount_PlanOutput> Maintain_Headcount_PlanAsync(Workday_Common_HeaderType Workday_Common_Header, Maintain_Headcount_Plan_RequestType Maintain_Headcount_Plan_Request)
		{
			return ((Workforce_PlanningPort)this).Maintain_Headcount_PlanAsync(new Maintain_Headcount_PlanInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Maintain_Headcount_Plan_Request = Maintain_Headcount_Plan_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Headcount_Plan_TemplatesOutput Workforce_PlanningPort.Get_Headcount_Plan_Templates(Get_Headcount_Plan_TemplatesInput request)
		{
			return base.Channel.Get_Headcount_Plan_Templates(request);
		}

		public Get_Headcount_Plan_Templates_ResponseType Get_Headcount_Plan_Templates(Workday_Common_HeaderType Workday_Common_Header, Get_Headcount_Plan_Templates_RequestType Get_Headcount_Plan_Templates_Request)
		{
			return ((Workforce_PlanningPort)this).Get_Headcount_Plan_Templates(new Get_Headcount_Plan_TemplatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Headcount_Plan_Templates_Request = Get_Headcount_Plan_Templates_Request
			}).Get_Headcount_Plan_Templates_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Headcount_Plan_TemplatesOutput> Workforce_PlanningPort.Get_Headcount_Plan_TemplatesAsync(Get_Headcount_Plan_TemplatesInput request)
		{
			return base.Channel.Get_Headcount_Plan_TemplatesAsync(request);
		}

		public Task<Get_Headcount_Plan_TemplatesOutput> Get_Headcount_Plan_TemplatesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Headcount_Plan_Templates_RequestType Get_Headcount_Plan_Templates_Request)
		{
			return ((Workforce_PlanningPort)this).Get_Headcount_Plan_TemplatesAsync(new Get_Headcount_Plan_TemplatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Headcount_Plan_Templates_Request = Get_Headcount_Plan_Templates_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Headcount_Plan_TemplateOutput Workforce_PlanningPort.Put_Headcount_Plan_Template(Put_Headcount_Plan_TemplateInput request)
		{
			return base.Channel.Put_Headcount_Plan_Template(request);
		}

		public Put_Headcount_Plan_Template_ResponseType Put_Headcount_Plan_Template(Workday_Common_HeaderType Workday_Common_Header, Put_Headcount_Plan_Template_RequestType Put_Headcount_Plan_Template_Request)
		{
			return ((Workforce_PlanningPort)this).Put_Headcount_Plan_Template(new Put_Headcount_Plan_TemplateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Headcount_Plan_Template_Request = Put_Headcount_Plan_Template_Request
			}).Put_Headcount_Plan_Template_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Headcount_Plan_TemplateOutput> Workforce_PlanningPort.Put_Headcount_Plan_TemplateAsync(Put_Headcount_Plan_TemplateInput request)
		{
			return base.Channel.Put_Headcount_Plan_TemplateAsync(request);
		}

		public Task<Put_Headcount_Plan_TemplateOutput> Put_Headcount_Plan_TemplateAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Headcount_Plan_Template_RequestType Put_Headcount_Plan_Template_Request)
		{
			return ((Workforce_PlanningPort)this).Put_Headcount_Plan_TemplateAsync(new Put_Headcount_Plan_TemplateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Headcount_Plan_Template_Request = Put_Headcount_Plan_Template_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Headcount_PlansOutput Workforce_PlanningPort.Get_Headcount_Plans(Get_Headcount_PlansInput request)
		{
			return base.Channel.Get_Headcount_Plans(request);
		}

		public Get_Headcount_Plans_ResponseType Get_Headcount_Plans(Workday_Common_HeaderType Workday_Common_Header, Get_Headcount_Plans_RequestType Get_Headcount_Plans_Request)
		{
			return ((Workforce_PlanningPort)this).Get_Headcount_Plans(new Get_Headcount_PlansInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Headcount_Plans_Request = Get_Headcount_Plans_Request
			}).Get_Headcount_Plans_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Headcount_PlansOutput> Workforce_PlanningPort.Get_Headcount_PlansAsync(Get_Headcount_PlansInput request)
		{
			return base.Channel.Get_Headcount_PlansAsync(request);
		}

		public Task<Get_Headcount_PlansOutput> Get_Headcount_PlansAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Headcount_Plans_RequestType Get_Headcount_Plans_Request)
		{
			return ((Workforce_PlanningPort)this).Get_Headcount_PlansAsync(new Get_Headcount_PlansInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Headcount_Plans_Request = Get_Headcount_Plans_Request
			});
		}
	}
}
