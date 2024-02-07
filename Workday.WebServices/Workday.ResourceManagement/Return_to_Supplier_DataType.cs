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
	public class Return_to_Supplier_DataType : INotifyPropertyChanged
	{
		private string return_NumberField;

		private Document_StatusObjectType document_Status_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private Resource_ProviderObjectType supplier_ReferenceField;

		private Return_to_Supplier_ReasonObjectType return_Reason_ReferenceField;

		private DateTime return_DateField;

		private bool return_DateFieldSpecified;

		private Supplier_InvoiceObjectType supplier_Invoice_ReferenceField;

		private string supplier_RMAField;

		private string memoField;

		private Unique_IdentifierObjectType created_by_Person_ReferenceField;

		private Return_to_Supplier_Line_DataType[] return_Line_DataField;

		private Financials_Attachment_DataType[] attachement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Return_Number
		{
			get
			{
				return this.return_NumberField;
			}
			set
			{
				this.return_NumberField = value;
				this.RaisePropertyChanged("Return_Number");
			}
		}

		[XmlElement(Order = 1)]
		public Document_StatusObjectType Document_Status_Reference
		{
			get
			{
				return this.document_Status_ReferenceField;
			}
			set
			{
				this.document_Status_ReferenceField = value;
				this.RaisePropertyChanged("Document_Status_Reference");
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

		[XmlElement(Order = 4)]
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

		[XmlElement(DataType = "date", Order = 5)]
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

		[XmlIgnore]
		public bool Return_DateSpecified
		{
			get
			{
				return this.return_DateFieldSpecified;
			}
			set
			{
				this.return_DateFieldSpecified = value;
				this.RaisePropertyChanged("Return_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
		public Unique_IdentifierObjectType Created_by_Person_Reference
		{
			get
			{
				return this.created_by_Person_ReferenceField;
			}
			set
			{
				this.created_by_Person_ReferenceField = value;
				this.RaisePropertyChanged("Created_by_Person_Reference");
			}
		}

		[XmlElement("Return_Line_Data", Order = 10)]
		public Return_to_Supplier_Line_DataType[] Return_Line_Data
		{
			get
			{
				return this.return_Line_DataField;
			}
			set
			{
				this.return_Line_DataField = value;
				this.RaisePropertyChanged("Return_Line_Data");
			}
		}

		[XmlElement("Attachement_Data", Order = 11)]
		public Financials_Attachment_DataType[] Attachement_Data
		{
			get
			{
				return this.attachement_DataField;
			}
			set
			{
				this.attachement_DataField = value;
				this.RaisePropertyChanged("Attachement_Data");
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
