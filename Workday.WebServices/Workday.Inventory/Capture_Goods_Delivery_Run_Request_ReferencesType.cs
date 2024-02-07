using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Capture_Goods_Delivery_Run_Request_ReferencesType : INotifyPropertyChanged
	{
		private Goods_Delivery_RunObjectType[] capture_Goods_Delivery_Run_Request_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Capture_Goods_Delivery_Run_Request_Reference", Order = 0)]
		public Goods_Delivery_RunObjectType[] Capture_Goods_Delivery_Run_Request_Reference
		{
			get
			{
				return this.capture_Goods_Delivery_Run_Request_ReferenceField;
			}
			set
			{
				this.capture_Goods_Delivery_Run_Request_ReferenceField = value;
				this.RaisePropertyChanged("Capture_Goods_Delivery_Run_Request_Reference");
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
