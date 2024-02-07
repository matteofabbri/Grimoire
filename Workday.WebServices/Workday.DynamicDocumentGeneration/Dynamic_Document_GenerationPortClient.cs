using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.DynamicDocumentGeneration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Dynamic_Document_GenerationPortClient : ClientBase<Dynamic_Document_GenerationPort>, Dynamic_Document_GenerationPort
	{
		public Dynamic_Document_GenerationPortClient()
		{
		}

		public Dynamic_Document_GenerationPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Dynamic_Document_GenerationPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Dynamic_Document_GenerationPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Dynamic_Document_GenerationPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Text_Block_CategoriesOutput Dynamic_Document_GenerationPort.Get_Text_Block_Categories(Get_Text_Block_CategoriesInput request)
		{
			return base.Channel.Get_Text_Block_Categories(request);
		}

		public Get_Text_Block_Categories_ResponseType Get_Text_Block_Categories(Workday_Common_HeaderType Workday_Common_Header, Get_Text_Block_Categories_RequestType Get_Text_Block_Categories_Request)
		{
			return ((Dynamic_Document_GenerationPort)this).Get_Text_Block_Categories(new Get_Text_Block_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Text_Block_Categories_Request = Get_Text_Block_Categories_Request
			}).Get_Text_Block_Categories_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Text_Block_CategoriesOutput> Dynamic_Document_GenerationPort.Get_Text_Block_CategoriesAsync(Get_Text_Block_CategoriesInput request)
		{
			return base.Channel.Get_Text_Block_CategoriesAsync(request);
		}

		public Task<Get_Text_Block_CategoriesOutput> Get_Text_Block_CategoriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Text_Block_Categories_RequestType Get_Text_Block_Categories_Request)
		{
			return ((Dynamic_Document_GenerationPort)this).Get_Text_Block_CategoriesAsync(new Get_Text_Block_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Text_Block_Categories_Request = Get_Text_Block_Categories_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Text_Block_CategoryOutput Dynamic_Document_GenerationPort.Put_Text_Block_Category(Put_Text_Block_CategoryInput request)
		{
			return base.Channel.Put_Text_Block_Category(request);
		}

		public Put_Text_Block_Category_ResponseType Put_Text_Block_Category(Workday_Common_HeaderType Workday_Common_Header, Put_Text_Block_Category_RequestType Put_Text_Block_Category_Request)
		{
			return ((Dynamic_Document_GenerationPort)this).Put_Text_Block_Category(new Put_Text_Block_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Text_Block_Category_Request = Put_Text_Block_Category_Request
			}).Put_Text_Block_Category_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Text_Block_CategoryOutput> Dynamic_Document_GenerationPort.Put_Text_Block_CategoryAsync(Put_Text_Block_CategoryInput request)
		{
			return base.Channel.Put_Text_Block_CategoryAsync(request);
		}

		public Task<Put_Text_Block_CategoryOutput> Put_Text_Block_CategoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Text_Block_Category_RequestType Put_Text_Block_Category_Request)
		{
			return ((Dynamic_Document_GenerationPort)this).Put_Text_Block_CategoryAsync(new Put_Text_Block_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Text_Block_Category_Request = Put_Text_Block_Category_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Text_BlocksOutput Dynamic_Document_GenerationPort.Get_Text_Blocks(Get_Text_BlocksInput request)
		{
			return base.Channel.Get_Text_Blocks(request);
		}

		public Get_Text_Blocks_ResponseType Get_Text_Blocks(Workday_Common_HeaderType Workday_Common_Header, Get_Text_Blocks_RequestType Get_Text_Blocks_Request)
		{
			return ((Dynamic_Document_GenerationPort)this).Get_Text_Blocks(new Get_Text_BlocksInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Text_Blocks_Request = Get_Text_Blocks_Request
			}).Get_Text_Blocks_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Text_BlocksOutput> Dynamic_Document_GenerationPort.Get_Text_BlocksAsync(Get_Text_BlocksInput request)
		{
			return base.Channel.Get_Text_BlocksAsync(request);
		}

		public Task<Get_Text_BlocksOutput> Get_Text_BlocksAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Text_Blocks_RequestType Get_Text_Blocks_Request)
		{
			return ((Dynamic_Document_GenerationPort)this).Get_Text_BlocksAsync(new Get_Text_BlocksInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Text_Blocks_Request = Get_Text_Blocks_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Text_BlockOutput Dynamic_Document_GenerationPort.Put_Text_Block(Put_Text_BlockInput request)
		{
			return base.Channel.Put_Text_Block(request);
		}

		public Put_Text_Block_ResponseType Put_Text_Block(Workday_Common_HeaderType Workday_Common_Header, Put_Text_Block_RequestType Put_Text_Block_Request)
		{
			return ((Dynamic_Document_GenerationPort)this).Put_Text_Block(new Put_Text_BlockInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Text_Block_Request = Put_Text_Block_Request
			}).Put_Text_Block_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Text_BlockOutput> Dynamic_Document_GenerationPort.Put_Text_BlockAsync(Put_Text_BlockInput request)
		{
			return base.Channel.Put_Text_BlockAsync(request);
		}

		public Task<Put_Text_BlockOutput> Put_Text_BlockAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Text_Block_RequestType Put_Text_Block_Request)
		{
			return ((Dynamic_Document_GenerationPort)this).Put_Text_BlockAsync(new Put_Text_BlockInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Text_Block_Request = Put_Text_Block_Request
			});
		}
	}
}
