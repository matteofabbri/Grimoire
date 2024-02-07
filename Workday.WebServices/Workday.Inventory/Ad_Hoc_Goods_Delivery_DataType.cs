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
	public class Ad_Hoc_Goods_Delivery_DataType : INotifyPropertyChanged
	{
		private string goods_Delivery_IDField;

		private CompanyObjectType company_for_Goods_Delivery_Ticket_ReferenceField;

		private WorkerObjectType requester_ReferenceField;

		private LocationObjectType delivery_To_ReferenceField;

		private string tracking_IDField;

		private string memoField;

		private Ad_Hoc_Goods_Delivery_Line_DataType[] goods_Delivery_Ticket_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Goods_Delivery_ID
		{
			get
			{
				return this.goods_Delivery_IDField;
			}
			set
			{
				this.goods_Delivery_IDField = value;
				this.RaisePropertyChanged("Goods_Delivery_ID");
			}
		}

		[XmlElement(Order = 1)]
		public CompanyObjectType Company_for_Goods_Delivery_Ticket_Reference
		{
			get
			{
				return this.company_for_Goods_Delivery_Ticket_ReferenceField;
			}
			set
			{
				this.company_for_Goods_Delivery_Ticket_ReferenceField = value;
				this.RaisePropertyChanged("Company_for_Goods_Delivery_Ticket_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public WorkerObjectType Requester_Reference
		{
			get
			{
				return this.requester_ReferenceField;
			}
			set
			{
				this.requester_ReferenceField = value;
				this.RaisePropertyChanged("Requester_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public LocationObjectType Delivery_To_Reference
		{
			get
			{
				return this.delivery_To_ReferenceField;
			}
			set
			{
				this.delivery_To_ReferenceField = value;
				this.RaisePropertyChanged("Delivery_To_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public string Tracking_ID
		{
			get
			{
				return this.tracking_IDField;
			}
			set
			{
				this.tracking_IDField = value;
				this.RaisePropertyChanged("Tracking_ID");
			}
		}

		[XmlElement(Order = 5)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
			}
		}

		[XmlElement("Goods_Delivery_Ticket_Line_Data", Order = 6)]
		public Ad_Hoc_Goods_Delivery_Line_DataType[] Goods_Delivery_Ticket_Line_Data
		{
			get
			{
				return this.goods_Delivery_Ticket_Line_DataField;
			}
			set
			{
				this.goods_Delivery_Ticket_Line_DataField = value;
				this.RaisePropertyChanged("Goods_Delivery_Ticket_Line_Data");
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
