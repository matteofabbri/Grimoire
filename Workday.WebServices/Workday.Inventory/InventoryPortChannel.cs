using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public interface InventoryPortChannel : InventoryPort, IClientChannel, IContextChannel, IChannel, ICommunicationObject, IExtensibleObject<IContextChannel>, IDisposable
	{
	}
}
