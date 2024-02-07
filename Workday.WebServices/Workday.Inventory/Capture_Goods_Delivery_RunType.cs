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
	public class Capture_Goods_Delivery_RunType : INotifyPropertyChanged
	{
		private Goods_Delivery_RunObjectType capture_Goods_Delivery_Run_ReferenceField;

		private Capture_Goods_Delivery_Run_Outbound_DataType[] capture_Goods_Delivery_Run_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Goods_Delivery_RunObjectType Capture_Goods_Delivery_Run_Reference
		{
			get
			{
				return this.capture_Goods_Delivery_Run_ReferenceField;
			}
			set
			{
				this.capture_Goods_Delivery_Run_ReferenceField = value;
				this.RaisePropertyChanged("Capture_Goods_Delivery_Run_Reference");
			}
		}

		[XmlElement("Capture_Goods_Delivery_Run_Data", Order = 1)]
		public Capture_Goods_Delivery_Run_Outbound_DataType[] Capture_Goods_Delivery_Run_Data
		{
			get
			{
				return this.capture_Goods_Delivery_Run_DataField;
			}
			set
			{
				this.capture_Goods_Delivery_Run_DataField = value;
				this.RaisePropertyChanged("Capture_Goods_Delivery_Run_Data");
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
