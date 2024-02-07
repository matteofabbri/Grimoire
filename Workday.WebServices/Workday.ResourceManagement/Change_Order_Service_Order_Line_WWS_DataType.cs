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
	public class Change_Order_Service_Order_Line_WWS_DataType : INotifyPropertyChanged
	{
		private Order_Service_LineObjectType purchase_Order_Line_ReferenceField;

		private string change_Order_Line_Reference_IDField;

		private bool cancel_PO_LineField;

		private bool cancel_PO_LineFieldSpecified;

		private string service_Order_Line_IDField;

		private decimal line_NumberField;

		private bool line_NumberFieldSpecified;

		private Procurement_ItemObjectType item_ReferenceField;

		private string descriptionField;

		private Spend_CategoryObjectType resource_Category_ReferenceField;

		private Tax_ApplicabilityObjectType tax_Applicability_ReferenceField;

		private Tax_CodeObjectType tax_Code_ReferenceField;

		private decimal extended_AmountField;

		private bool extended_AmountFieldSpecified;

		private DateTime due_DateField;

		private bool due_DateFieldSpecified;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private bool retention_LineField;

		private bool retention_LineFieldSpecified;

		private bool prepaidField;

		private bool prepaidFieldSpecified;

		private string memoField;

		private Address_ReferenceObjectType ship_To_Address_ReferenceField;

		private WorkerObjectType ship_To_Contact_ReferenceField;

		private LocationObjectType deliver_To_Location_ReferenceField;

		private LocationObjectType storage_Location_ReferenceField;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private bool remove_Line_SplitsField;

		private bool remove_Line_SplitsFieldSpecified;

		private Change_Order_Line_Split_WWS_DataType[] change_Order_Service_Line_Split_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Order_Service_LineObjectType Purchase_Order_Line_Reference
		{
			get
			{
				return this.purchase_Order_Line_ReferenceField;
			}
			set
			{
				this.purchase_Order_Line_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Order_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Change_Order_Line_Reference_ID
		{
			get
			{
				return this.change_Order_Line_Reference_IDField;
			}
			set
			{
				this.change_Order_Line_Reference_IDField = value;
				this.RaisePropertyChanged("Change_Order_Line_Reference_ID");
			}
		}

		[XmlElement(Order = 2)]
		public bool Cancel_PO_Line
		{
			get
			{
				return this.cancel_PO_LineField;
			}
			set
			{
				this.cancel_PO_LineField = value;
				this.RaisePropertyChanged("Cancel_PO_Line");
			}
		}

		[XmlIgnore]
		public bool Cancel_PO_LineSpecified
		{
			get
			{
				return this.cancel_PO_LineFieldSpecified;
			}
			set
			{
				this.cancel_PO_LineFieldSpecified = value;
				this.RaisePropertyChanged("Cancel_PO_LineSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Service_Order_Line_ID
		{
			get
			{
				return this.service_Order_Line_IDField;
			}
			set
			{
				this.service_Order_Line_IDField = value;
				this.RaisePropertyChanged("Service_Order_Line_ID");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Line_Number
		{
			get
			{
				return this.line_NumberField;
			}
			set
			{
				this.line_NumberField = value;
				this.RaisePropertyChanged("Line_Number");
			}
		}

		[XmlIgnore]
		public bool Line_NumberSpecified
		{
			get
			{
				return this.line_NumberFieldSpecified;
			}
			set
			{
				this.line_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Line_NumberSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Procurement_ItemObjectType Item_Reference
		{
			get
			{
				return this.item_ReferenceField;
			}
			set
			{
				this.item_ReferenceField = value;
				this.RaisePropertyChanged("Item_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 7)]
		public Spend_CategoryObjectType Resource_Category_Reference
		{
			get
			{
				return this.resource_Category_ReferenceField;
			}
			set
			{
				this.resource_Category_ReferenceField = value;
				this.RaisePropertyChanged("Resource_Category_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Tax_ApplicabilityObjectType Tax_Applicability_Reference
		{
			get
			{
				return this.tax_Applicability_ReferenceField;
			}
			set
			{
				this.tax_Applicability_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Applicability_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Tax_CodeObjectType Tax_Code_Reference
		{
			get
			{
				return this.tax_Code_ReferenceField;
			}
			set
			{
				this.tax_Code_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Code_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Extended_Amount
		{
			get
			{
				return this.extended_AmountField;
			}
			set
			{
				this.extended_AmountField = value;
				this.RaisePropertyChanged("Extended_Amount");
			}
		}

		[XmlIgnore]
		public bool Extended_AmountSpecified
		{
			get
			{
				return this.extended_AmountFieldSpecified;
			}
			set
			{
				this.extended_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Extended_AmountSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 11)]
		public DateTime Due_Date
		{
			get
			{
				return this.due_DateField;
			}
			set
			{
				this.due_DateField = value;
				this.RaisePropertyChanged("Due_Date");
			}
		}

		[XmlIgnore]
		public bool Due_DateSpecified
		{
			get
			{
				return this.due_DateFieldSpecified;
			}
			set
			{
				this.due_DateFieldSpecified = value;
				this.RaisePropertyChanged("Due_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 12)]
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

		[XmlElement(DataType = "date", Order = 13)]
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

		[XmlElement(Order = 14)]
		public bool Retention_Line
		{
			get
			{
				return this.retention_LineField;
			}
			set
			{
				this.retention_LineField = value;
				this.RaisePropertyChanged("Retention_Line");
			}
		}

		[XmlIgnore]
		public bool Retention_LineSpecified
		{
			get
			{
				return this.retention_LineFieldSpecified;
			}
			set
			{
				this.retention_LineFieldSpecified = value;
				this.RaisePropertyChanged("Retention_LineSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public bool Prepaid
		{
			get
			{
				return this.prepaidField;
			}
			set
			{
				this.prepaidField = value;
				this.RaisePropertyChanged("Prepaid");
			}
		}

		[XmlIgnore]
		public bool PrepaidSpecified
		{
			get
			{
				return this.prepaidFieldSpecified;
			}
			set
			{
				this.prepaidFieldSpecified = value;
				this.RaisePropertyChanged("PrepaidSpecified");
			}
		}

		[XmlElement(Order = 16)]
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

		[XmlElement(Order = 17)]
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

		[XmlElement(Order = 18)]
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

		[XmlElement(Order = 19)]
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

		[XmlElement(Order = 20)]
		public LocationObjectType Storage_Location_Reference
		{
			get
			{
				return this.storage_Location_ReferenceField;
			}
			set
			{
				this.storage_Location_ReferenceField = value;
				this.RaisePropertyChanged("Storage_Location_Reference");
			}
		}

		[XmlElement("Worktags_Reference", Order = 21)]
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

		[XmlElement(Order = 22)]
		public bool Remove_Line_Splits
		{
			get
			{
				return this.remove_Line_SplitsField;
			}
			set
			{
				this.remove_Line_SplitsField = value;
				this.RaisePropertyChanged("Remove_Line_Splits");
			}
		}

		[XmlIgnore]
		public bool Remove_Line_SplitsSpecified
		{
			get
			{
				return this.remove_Line_SplitsFieldSpecified;
			}
			set
			{
				this.remove_Line_SplitsFieldSpecified = value;
				this.RaisePropertyChanged("Remove_Line_SplitsSpecified");
			}
		}

		[XmlElement("Change_Order_Service_Line_Split_Data", Order = 23)]
		public Change_Order_Line_Split_WWS_DataType[] Change_Order_Service_Line_Split_Data
		{
			get
			{
				return this.change_Order_Service_Line_Split_DataField;
			}
			set
			{
				this.change_Order_Service_Line_Split_DataField = value;
				this.RaisePropertyChanged("Change_Order_Service_Line_Split_Data");
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
