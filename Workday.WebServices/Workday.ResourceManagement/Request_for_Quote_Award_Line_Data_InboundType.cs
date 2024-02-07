using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Request_for_Quote_Award_Line_Data_InboundType : INotifyPropertyChanged
	{
		private Request_for_Quote_LineObjectType rFQ_Line_ReferenceField;

		private string award_Line_DescriptionField;

		private decimal award_QuantityField;

		private bool award_QuantityFieldSpecified;

		private decimal award_AmountField;

		private bool award_AmountFieldSpecified;

		private DateTime requested_Delivery_DateField;

		private bool requested_Delivery_DateFieldSpecified;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private Address_ReferenceObjectType ship_To_Address_ReferenceField;

		private WorkerObjectType ship_To_Contact_ReferenceField;

		private LocationObjectType deliver_To_Location_ReferenceField;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private string memoField;

		private Business_Document_Attachment_with_External_Option_DataType[] business_Document_Line_Attachment_DataField;

		private Request_for_Quote_Award_Line_Splits_Data_InboundType[] request_for_Quote_Award_Line_Splits_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Request_for_Quote_LineObjectType RFQ_Line_Reference
		{
			get
			{
				return this.rFQ_Line_ReferenceField;
			}
			set
			{
				this.rFQ_Line_ReferenceField = value;
				this.RaisePropertyChanged("RFQ_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Award_Line_Description
		{
			get
			{
				return this.award_Line_DescriptionField;
			}
			set
			{
				this.award_Line_DescriptionField = value;
				this.RaisePropertyChanged("Award_Line_Description");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Award_Quantity
		{
			get
			{
				return this.award_QuantityField;
			}
			set
			{
				this.award_QuantityField = value;
				this.RaisePropertyChanged("Award_Quantity");
			}
		}

		[XmlIgnore]
		public bool Award_QuantitySpecified
		{
			get
			{
				return this.award_QuantityFieldSpecified;
			}
			set
			{
				this.award_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Award_QuantitySpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Award_Amount
		{
			get
			{
				return this.award_AmountField;
			}
			set
			{
				this.award_AmountField = value;
				this.RaisePropertyChanged("Award_Amount");
			}
		}

		[XmlIgnore]
		public bool Award_AmountSpecified
		{
			get
			{
				return this.award_AmountFieldSpecified;
			}
			set
			{
				this.award_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Award_AmountSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Requested_Delivery_Date
		{
			get
			{
				return this.requested_Delivery_DateField;
			}
			set
			{
				this.requested_Delivery_DateField = value;
				this.RaisePropertyChanged("Requested_Delivery_Date");
			}
		}

		[XmlIgnore]
		public bool Requested_Delivery_DateSpecified
		{
			get
			{
				return this.requested_Delivery_DateFieldSpecified;
			}
			set
			{
				this.requested_Delivery_DateFieldSpecified = value;
				this.RaisePropertyChanged("Requested_Delivery_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlIgnore]
		public bool Start_DateSpecified
		{
			get
			{
				return this.start_DateFieldSpecified;
			}
			set
			{
				this.start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public Address_ReferenceObjectType Ship_To_Address_Reference
		{
			get
			{
				return this.ship_To_Address_ReferenceField;
			}
			set
			{
				this.ship_To_Address_ReferenceField = value;
				this.RaisePropertyChanged("Ship_To_Address_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public WorkerObjectType Ship_To_Contact_Reference
		{
			get
			{
				return this.ship_To_Contact_ReferenceField;
			}
			set
			{
				this.ship_To_Contact_ReferenceField = value;
				this.RaisePropertyChanged("Ship_To_Contact_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public LocationObjectType Deliver_To_Location_Reference
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

		[XmlElement("Worktags_Reference", Order = 10)]
		public Accounting_WorktagObjectType[] Worktags_Reference
		{
			get
			{
				return this.worktags_ReferenceField;
			}
			set
			{
				this.worktags_ReferenceField = value;
				this.RaisePropertyChanged("Worktags_Reference");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement("Business_Document_Line_Attachment_Data", Order = 12)]
		public Business_Document_Attachment_with_External_Option_DataType[] Business_Document_Line_Attachment_Data
		{
			get
			{
				return this.business_Document_Line_Attachment_DataField;
			}
			set
			{
				this.business_Document_Line_Attachment_DataField = value;
				this.RaisePropertyChanged("Business_Document_Line_Attachment_Data");
			}
		}

		[XmlElement("Request_for_Quote_Award_Line_Splits_Data", Order = 13)]
		public Request_for_Quote_Award_Line_Splits_Data_InboundType[] Request_for_Quote_Award_Line_Splits_Data
		{
			get
			{
				return this.request_for_Quote_Award_Line_Splits_DataField;
			}
			set
			{
				this.request_for_Quote_Award_Line_Splits_DataField = value;
				this.RaisePropertyChanged("Request_for_Quote_Award_Line_Splits_Data");
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
