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
	public class Submit_Return_DataType : INotifyPropertyChanged
	{
		private string return_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private Return_to_Supplier_ReasonObjectType return_Reason_ReferenceField;

		private DateTime return_DateField;

		private Supplier_InvoiceObjectType supplier_Invoice_ReferenceField;

		private string supplier_RMAField;

		private string memoField;

		private Item_Return_Line_Replacement_DataType[] item_Return_Line_Replacement_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Return_ID
		{
			get
			{
				return this.return_IDField;
			}
			set
			{
				this.return_IDField = value;
				this.RaisePropertyChanged("Return_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Submit
		{
			get
			{
				return this.submitField;
			}
			set
			{
				this.submitField = value;
				this.RaisePropertyChanged("Submit");
			}
		}

		[XmlIgnore]
		public bool SubmitSpecified
		{
			get
			{
				return this.submitFieldSpecified;
			}
			set
			{
				this.submitFieldSpecified = value;
				this.RaisePropertyChanged("SubmitSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Return_to_Supplier_ReasonObjectType Return_Reason_Reference
		{
			get
			{
				return this.return_Reason_ReferenceField;
			}
			set
			{
				this.return_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Return_Reason_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Return_Date
		{
			get
			{
				return this.return_DateField;
			}
			set
			{
				this.return_DateField = value;
				this.RaisePropertyChanged("Return_Date");
			}
		}

		[XmlElement(Order = 4)]
		public Supplier_InvoiceObjectType Supplier_Invoice_Reference
		{
			get
			{
				return this.supplier_Invoice_ReferenceField;
			}
			set
			{
				this.supplier_Invoice_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Supplier_RMA
		{
			get
			{
				return this.supplier_RMAField;
			}
			set
			{
				this.supplier_RMAField = value;
				this.RaisePropertyChanged("Supplier_RMA");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement("Item_Return_Line_Replacement_Data", Order = 7)]
		public Item_Return_Line_Replacement_DataType[] Item_Return_Line_Replacement_Data
		{
			get
			{
				return this.item_Return_Line_Replacement_DataField;
			}
			set
			{
				this.item_Return_Line_Replacement_DataField = value;
				this.RaisePropertyChanged("Item_Return_Line_Replacement_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 8)]
		public Financials_Attachment_DataType[] Attachment_Data
		{
			get
			{
				return this.attachment_DataField;
			}
			set
			{
				this.attachment_DataField = value;
				this.RaisePropertyChanged("Attachment_Data");
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
