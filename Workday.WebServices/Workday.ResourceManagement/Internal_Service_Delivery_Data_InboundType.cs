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
	public class Internal_Service_Delivery_Data_InboundType : INotifyPropertyChanged
	{
		private string internal_Service_Delivery_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private CompanyObjectType company_ReferenceField;

		private Internal_Service_ProviderObjectType internal_Service_Provider_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private DateTime document_DateField;

		private DateTime delivery_DateField;

		private bool delivery_DateFieldSpecified;

		private string memoField;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private Internal_Service_Delivery_Line_Data_InboundType[] internal_Service_Delivery_Line_DataField;

		private Business_Document_Attachment_with_External_Option_DataType[] business_Document_Attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Internal_Service_Delivery_ID
		{
			get
			{
				return this.internal_Service_Delivery_IDField;
			}
			set
			{
				this.internal_Service_Delivery_IDField = value;
				this.RaisePropertyChanged("Internal_Service_Delivery_ID");
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
		public Internal_Service_ProviderObjectType Internal_Service_Provider_Reference
		{
			get
			{
				return this.internal_Service_Provider_ReferenceField;
			}
			set
			{
				this.internal_Service_Provider_ReferenceField = value;
				this.RaisePropertyChanged("Internal_Service_Provider_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
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

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Delivery_Date
		{
			get
			{
				return this.delivery_DateField;
			}
			set
			{
				this.delivery_DateField = value;
				this.RaisePropertyChanged("Delivery_Date");
			}
		}

		[XmlIgnore]
		public bool Delivery_DateSpecified
		{
			get
			{
				return this.delivery_DateFieldSpecified;
			}
			set
			{
				this.delivery_DateFieldSpecified = value;
				this.RaisePropertyChanged("Delivery_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement("Worktags_Reference", Order = 8)]
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

		[XmlElement("Internal_Service_Delivery_Line_Data", Order = 9)]
		public Internal_Service_Delivery_Line_Data_InboundType[] Internal_Service_Delivery_Line_Data
		{
			get
			{
				return this.internal_Service_Delivery_Line_DataField;
			}
			set
			{
				this.internal_Service_Delivery_Line_DataField = value;
				this.RaisePropertyChanged("Internal_Service_Delivery_Line_Data");
			}
		}

		[XmlElement("Business_Document_Attachment_Data", Order = 10)]
		public Business_Document_Attachment_with_External_Option_DataType[] Business_Document_Attachment_Data
		{
			get
			{
				return this.business_Document_Attachment_DataField;
			}
			set
			{
				this.business_Document_Attachment_DataField = value;
				this.RaisePropertyChanged("Business_Document_Attachment_Data");
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
