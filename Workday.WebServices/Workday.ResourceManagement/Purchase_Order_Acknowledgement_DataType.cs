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
	public class Purchase_Order_Acknowledgement_DataType : INotifyPropertyChanged
	{
		private string purchase_Order_Acknowledgement_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private string document_NumberField;

		private Purchase_OrderObjectType purchase_Order_ReferenceField;

		private PO_Acknowledgement_StatusObjectType pO_Acknowledgement_Status_ReferenceField;

		private string memoField;

		private PO_Acknowledgement_Line_DataType[] pO_Acknowledgement_Line_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Purchase_Order_Acknowledgement_ID
		{
			get
			{
				return this.purchase_Order_Acknowledgement_IDField;
			}
			set
			{
				this.purchase_Order_Acknowledgement_IDField = value;
				this.RaisePropertyChanged("Purchase_Order_Acknowledgement_ID");
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
		public string Document_Number
		{
			get
			{
				return this.document_NumberField;
			}
			set
			{
				this.document_NumberField = value;
				this.RaisePropertyChanged("Document_Number");
			}
		}

		[XmlElement(Order = 3)]
		public Purchase_OrderObjectType Purchase_Order_Reference
		{
			get
			{
				return this.purchase_Order_ReferenceField;
			}
			set
			{
				this.purchase_Order_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Order_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public PO_Acknowledgement_StatusObjectType PO_Acknowledgement_Status_Reference
		{
			get
			{
				return this.pO_Acknowledgement_Status_ReferenceField;
			}
			set
			{
				this.pO_Acknowledgement_Status_ReferenceField = value;
				this.RaisePropertyChanged("PO_Acknowledgement_Status_Reference");
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

		[XmlElement("PO_Acknowledgement_Line_Data", Order = 6)]
		public PO_Acknowledgement_Line_DataType[] PO_Acknowledgement_Line_Data
		{
			get
			{
				return this.pO_Acknowledgement_Line_DataField;
			}
			set
			{
				this.pO_Acknowledgement_Line_DataField = value;
				this.RaisePropertyChanged("PO_Acknowledgement_Line_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 7)]
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
