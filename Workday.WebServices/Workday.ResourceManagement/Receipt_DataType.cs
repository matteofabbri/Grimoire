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
	public class Receipt_DataType : INotifyPropertyChanged
	{
		private string receipt_NumberField;

		private bool submitField;

		private bool submitFieldSpecified;

		private CompanyObjectType company_ReferenceField;

		private Resource_ProviderObjectType supplier_ReferenceField;

		private DateTime document_DateField;

		private bool document_DateFieldSpecified;

		private WorkerObjectType created_for_Worker_ReferenceField;

		private string memoField;

		private Item_Receipt_Line_Replacement_DataType[] item_Receipt_Line_Replacement_DataField;

		private Contingent_Worker_Receipt_Line_Replacement_DataType contingent_Worker_Receipt_Line_Replacement_DataField;

		private Receipt_Service_Line_Replacement_DataType[] receipt_Service_Line_Replacement_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Receipt_Number
		{
			get
			{
				return this.receipt_NumberField;
			}
			set
			{
				this.receipt_NumberField = value;
				this.RaisePropertyChanged("Receipt_Number");
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

		[XmlElement(Order = 3)]
		public Resource_ProviderObjectType Supplier_Reference
		{
			get
			{
				return this.supplier_ReferenceField;
			}
			set
			{
				this.supplier_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Document_Date
		{
			get
			{
				return this.document_DateField;
			}
			set
			{
				this.document_DateField = value;
				this.RaisePropertyChanged("Document_Date");
			}
		}

		[XmlIgnore]
		public bool Document_DateSpecified
		{
			get
			{
				return this.document_DateFieldSpecified;
			}
			set
			{
				this.document_DateFieldSpecified = value;
				this.RaisePropertyChanged("Document_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public WorkerObjectType Created_for_Worker_Reference
		{
			get
			{
				return this.created_for_Worker_ReferenceField;
			}
			set
			{
				this.created_for_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Created_for_Worker_Reference");
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

		[XmlElement("Item_Receipt_Line_Replacement_Data", Order = 7)]
		public Item_Receipt_Line_Replacement_DataType[] Item_Receipt_Line_Replacement_Data
		{
			get
			{
				return this.item_Receipt_Line_Replacement_DataField;
			}
			set
			{
				this.item_Receipt_Line_Replacement_DataField = value;
				this.RaisePropertyChanged("Item_Receipt_Line_Replacement_Data");
			}
		}

		[XmlElement(Order = 8)]
		public Contingent_Worker_Receipt_Line_Replacement_DataType Contingent_Worker_Receipt_Line_Replacement_Data
		{
			get
			{
				return this.contingent_Worker_Receipt_Line_Replacement_DataField;
			}
			set
			{
				this.contingent_Worker_Receipt_Line_Replacement_DataField = value;
				this.RaisePropertyChanged("Contingent_Worker_Receipt_Line_Replacement_Data");
			}
		}

		[XmlElement("Receipt_Service_Line_Replacement_Data", Order = 9)]
		public Receipt_Service_Line_Replacement_DataType[] Receipt_Service_Line_Replacement_Data
		{
			get
			{
				return this.receipt_Service_Line_Replacement_DataField;
			}
			set
			{
				this.receipt_Service_Line_Replacement_DataField = value;
				this.RaisePropertyChanged("Receipt_Service_Line_Replacement_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 10)]
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
