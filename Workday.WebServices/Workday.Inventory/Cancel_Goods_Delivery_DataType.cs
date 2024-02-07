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
	public class Cancel_Goods_Delivery_DataType : INotifyPropertyChanged
	{
		private string goods_Delivery_Ticket_Cancellation_MemoField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Goods_Delivery_Ticket_Cancellation_Memo
		{
			get
			{
				return this.goods_Delivery_Ticket_Cancellation_MemoField;
			}
			set
			{
				this.goods_Delivery_Ticket_Cancellation_MemoField = value;
				this.RaisePropertyChanged("Goods_Delivery_Ticket_Cancellation_Memo");
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
