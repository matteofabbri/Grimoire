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
	public class Capture_Goods_Delivery_Run_Request_CriteriaType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private string goods_Delivery_Run_IDField;

		private DateTime delivery_Ticket_Created_On_or_AfterField;

		private bool delivery_Ticket_Created_On_or_AfterFieldSpecified;

		private DateTime delivery_Ticket_Created_On_or_BeforeField;

		private bool delivery_Ticket_Created_On_or_BeforeFieldSpecified;

		private Document_StatusObjectType[] delivery_Run_Status_ReferenceField;

		private LocationObjectType[] deliver_To_Location_ReferenceField;

		private WorkerObjectType[] created_By_Worker_ReferenceField;

		private WorkerObjectType requester_Worker_ReferenceField;

		private WorkerObjectType[] assigned_To_Worker_ReferenceField;

		private Inventory_Stock_Request_OriginObjectType delivery_Run_Origin_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Goods_Delivery_Run_ID
		{
			get
			{
				return this.goods_Delivery_Run_IDField;
			}
			set
			{
				this.goods_Delivery_Run_IDField = value;
				this.RaisePropertyChanged("Goods_Delivery_Run_ID");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Delivery_Ticket_Created_On_or_After
		{
			get
			{
				return this.delivery_Ticket_Created_On_or_AfterField;
			}
			set
			{
				this.delivery_Ticket_Created_On_or_AfterField = value;
				this.RaisePropertyChanged("Delivery_Ticket_Created_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Delivery_Ticket_Created_On_or_AfterSpecified
		{
			get
			{
				return this.delivery_Ticket_Created_On_or_AfterFieldSpecified;
			}
			set
			{
				this.delivery_Ticket_Created_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Delivery_Ticket_Created_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Delivery_Ticket_Created_On_or_Before
		{
			get
			{
				return this.delivery_Ticket_Created_On_or_BeforeField;
			}
			set
			{
				this.delivery_Ticket_Created_On_or_BeforeField = value;
				this.RaisePropertyChanged("Delivery_Ticket_Created_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Delivery_Ticket_Created_On_or_BeforeSpecified
		{
			get
			{
				return this.delivery_Ticket_Created_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.delivery_Ticket_Created_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Delivery_Ticket_Created_On_or_BeforeSpecified");
			}
		}

		[XmlElement("Delivery_Run_Status_Reference", Order = 4)]
		public Document_StatusObjectType[] Delivery_Run_Status_Reference
		{
			get
			{
				return this.delivery_Run_Status_ReferenceField;
			}
			set
			{
				this.delivery_Run_Status_ReferenceField = value;
				this.RaisePropertyChanged("Delivery_Run_Status_Reference");
			}
		}

		[XmlElement("Deliver_To_Location_Reference", Order = 5)]
		public LocationObjectType[] Deliver_To_Location_Reference
		{
			get
			{
				return this.deliver_To_Location_ReferenceField;
			}
			set
			{
				this.deliver_To_Location_ReferenceField = value;
				this.RaisePropertyChanged("Deliver_To_Location_Reference");
			}
		}

		[XmlElement("Created_By_Worker_Reference", Order = 6)]
		public WorkerObjectType[] Created_By_Worker_Reference
		{
			get
			{
				return this.created_By_Worker_ReferenceField;
			}
			set
			{
				this.created_By_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Created_By_Worker_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public WorkerObjectType Requester_Worker_Reference
		{
			get
			{
				return this.requester_Worker_ReferenceField;
			}
			set
			{
				this.requester_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Requester_Worker_Reference");
			}
		}

		[XmlElement("Assigned_To_Worker_Reference", Order = 8)]
		public WorkerObjectType[] Assigned_To_Worker_Reference
		{
			get
			{
				return this.assigned_To_Worker_ReferenceField;
			}
			set
			{
				this.assigned_To_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Assigned_To_Worker_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Inventory_Stock_Request_OriginObjectType Delivery_Run_Origin_Reference
		{
			get
			{
				return this.delivery_Run_Origin_ReferenceField;
			}
			set
			{
				this.delivery_Run_Origin_ReferenceField = value;
				this.RaisePropertyChanged("Delivery_Run_Origin_Reference");
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
