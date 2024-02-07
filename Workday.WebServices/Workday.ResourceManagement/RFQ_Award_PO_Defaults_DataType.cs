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
	public class RFQ_Award_PO_Defaults_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType shipTo_Contact_ReferenceField;

		private string shipTo_Contact_DetailField;

		private Unique_IdentifierObjectType ship_To_Address_ReferenceField;

		private WorkerObjectType billTo_Contact_ReferenceField;

		private string billTo_Contact_DetailField;

		private Unique_IdentifierObjectType bill_To_Address_ReferenceField;

		private Payment_TermsObjectType payment_Terms_ReferenceField;

		private Purchase_Order_Issue_OptionObjectType issue_Option_ReferenceField;

		private WorkerObjectType buyer_ReferenceField;

		private Shipping_TermsObjectType shipping_Terms_ReferenceField;

		private Shipping_MethodObjectType shipping_Method_ReferenceField;

		private string shipping_InstructionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Ship-To_Contact_Reference", Order = 0)]
		public WorkerObjectType ShipTo_Contact_Reference
		{
			get
			{
				return this.shipTo_Contact_ReferenceField;
			}
			set
			{
				this.shipTo_Contact_ReferenceField = value;
				this.RaisePropertyChanged("ShipTo_Contact_Reference");
			}
		}

		[XmlElement("Ship-To_Contact_Detail", Order = 1)]
		public string ShipTo_Contact_Detail
		{
			get
			{
				return this.shipTo_Contact_DetailField;
			}
			set
			{
				this.shipTo_Contact_DetailField = value;
				this.RaisePropertyChanged("ShipTo_Contact_Detail");
			}
		}

		[XmlElement(Order = 2)]
		public Unique_IdentifierObjectType Ship_To_Address_Reference
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

		[XmlElement("Bill-To_Contact_Reference", Order = 3)]
		public WorkerObjectType BillTo_Contact_Reference
		{
			get
			{
				return this.billTo_Contact_ReferenceField;
			}
			set
			{
				this.billTo_Contact_ReferenceField = value;
				this.RaisePropertyChanged("BillTo_Contact_Reference");
			}
		}

		[XmlElement("Bill-To_Contact_Detail", Order = 4)]
		public string BillTo_Contact_Detail
		{
			get
			{
				return this.billTo_Contact_DetailField;
			}
			set
			{
				this.billTo_Contact_DetailField = value;
				this.RaisePropertyChanged("BillTo_Contact_Detail");
			}
		}

		[XmlElement(Order = 5)]
		public Unique_IdentifierObjectType Bill_To_Address_Reference
		{
			get
			{
				return this.bill_To_Address_ReferenceField;
			}
			set
			{
				this.bill_To_Address_ReferenceField = value;
				this.RaisePropertyChanged("Bill_To_Address_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Payment_TermsObjectType Payment_Terms_Reference
		{
			get
			{
				return this.payment_Terms_ReferenceField;
			}
			set
			{
				this.payment_Terms_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Terms_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Purchase_Order_Issue_OptionObjectType Issue_Option_Reference
		{
			get
			{
				return this.issue_Option_ReferenceField;
			}
			set
			{
				this.issue_Option_ReferenceField = value;
				this.RaisePropertyChanged("Issue_Option_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public WorkerObjectType Buyer_Reference
		{
			get
			{
				return this.buyer_ReferenceField;
			}
			set
			{
				this.buyer_ReferenceField = value;
				this.RaisePropertyChanged("Buyer_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Shipping_TermsObjectType Shipping_Terms_Reference
		{
			get
			{
				return this.shipping_Terms_ReferenceField;
			}
			set
			{
				this.shipping_Terms_ReferenceField = value;
				this.RaisePropertyChanged("Shipping_Terms_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public Shipping_MethodObjectType Shipping_Method_Reference
		{
			get
			{
				return this.shipping_Method_ReferenceField;
			}
			set
			{
				this.shipping_Method_ReferenceField = value;
				this.RaisePropertyChanged("Shipping_Method_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public string Shipping_Instruction
		{
			get
			{
				return this.shipping_InstructionField;
			}
			set
			{
				this.shipping_InstructionField = value;
				this.RaisePropertyChanged("Shipping_Instruction");
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
