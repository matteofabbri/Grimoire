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
	public class Procurement_Card_Transaction_Verification_DataType : INotifyPropertyChanged
	{
		private string procurement_Card_Transaction_Verification_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private WorkerObjectType worker_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private DateTime document_DateField;

		private bool document_DateFieldSpecified;

		private Document_StatusObjectType verification_Status_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private decimal total_Verification_AmountField;

		private bool total_Verification_AmountFieldSpecified;

		private Procurement_Card_Transaction_Verification_Summary_DataType[] procurement_Card_Transaction_Verification_Summary_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Procurement_Card_Transaction_Verification_ID
		{
			get
			{
				return this.procurement_Card_Transaction_Verification_IDField;
			}
			set
			{
				this.procurement_Card_Transaction_Verification_IDField = value;
				this.RaisePropertyChanged("Procurement_Card_Transaction_Verification_ID");
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
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(Order = 3)]
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
		public Document_StatusObjectType Verification_Status_Reference
		{
			get
			{
				return this.verification_Status_ReferenceField;
			}
			set
			{
				this.verification_Status_ReferenceField = value;
				this.RaisePropertyChanged("Verification_Status_Reference");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public decimal Total_Verification_Amount
		{
			get
			{
				return this.total_Verification_AmountField;
			}
			set
			{
				this.total_Verification_AmountField = value;
				this.RaisePropertyChanged("Total_Verification_Amount");
			}
		}

		[XmlIgnore]
		public bool Total_Verification_AmountSpecified
		{
			get
			{
				return this.total_Verification_AmountFieldSpecified;
			}
			set
			{
				this.total_Verification_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Total_Verification_AmountSpecified");
			}
		}

		[XmlElement("Procurement_Card_Transaction_Verification_Summary_Data", Order = 8)]
		public Procurement_Card_Transaction_Verification_Summary_DataType[] Procurement_Card_Transaction_Verification_Summary_Data
		{
			get
			{
				return this.procurement_Card_Transaction_Verification_Summary_DataField;
			}
			set
			{
				this.procurement_Card_Transaction_Verification_Summary_DataField = value;
				this.RaisePropertyChanged("Procurement_Card_Transaction_Verification_Summary_Data");
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
