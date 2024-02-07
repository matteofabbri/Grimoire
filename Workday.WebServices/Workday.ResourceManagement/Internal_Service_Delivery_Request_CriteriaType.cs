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
	public class Internal_Service_Delivery_Request_CriteriaType : INotifyPropertyChanged
	{
		private CompanyObjectType[] company_ReferenceField;

		private Internal_Service_ProviderObjectType[] internal_Service_Provider_ReferenceField;

		private Document_StatusObjectType[] document_Status_ReferenceField;

		private DateTime document_Date_On_or_BeforeField;

		private bool document_Date_On_or_BeforeFieldSpecified;

		private DateTime document_Date_On_or_AfterField;

		private bool document_Date_On_or_AfterFieldSpecified;

		private bool intercompany_Internal_Service_DeliveryField;

		private bool intercompany_Internal_Service_DeliveryFieldSpecified;

		private WorkerObjectType[] created_by_Workers_ReferenceField;

		private WorkerObjectType[] approved_by_Workers_ReferenceField;

		private Internal_Service_CatalogObjectType[] internal_Catalog_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Company_Reference", Order = 0)]
		public CompanyObjectType[] Company_Reference
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

		[XmlElement("Internal_Service_Provider_Reference", Order = 1)]
		public Internal_Service_ProviderObjectType[] Internal_Service_Provider_Reference
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

		[XmlElement("Document_Status_Reference", Order = 2)]
		public Document_StatusObjectType[] Document_Status_Reference
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

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Document_Date_On_or_Before
		{
			get
			{
				return this.document_Date_On_or_BeforeField;
			}
			set
			{
				this.document_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Document_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Document_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.document_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.document_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Document_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Document_Date_On_or_After
		{
			get
			{
				return this.document_Date_On_or_AfterField;
			}
			set
			{
				this.document_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Document_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Document_Date_On_or_AfterSpecified
		{
			get
			{
				return this.document_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.document_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Document_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Intercompany_Internal_Service_Delivery
		{
			get
			{
				return this.intercompany_Internal_Service_DeliveryField;
			}
			set
			{
				this.intercompany_Internal_Service_DeliveryField = value;
				this.RaisePropertyChanged("Intercompany_Internal_Service_Delivery");
			}
		}

		[XmlIgnore]
		public bool Intercompany_Internal_Service_DeliverySpecified
		{
			get
			{
				return this.intercompany_Internal_Service_DeliveryFieldSpecified;
			}
			set
			{
				this.intercompany_Internal_Service_DeliveryFieldSpecified = value;
				this.RaisePropertyChanged("Intercompany_Internal_Service_DeliverySpecified");
			}
		}

		[XmlElement("Created_by_Workers_Reference", Order = 6)]
		public WorkerObjectType[] Created_by_Workers_Reference
		{
			get
			{
				return this.created_by_Workers_ReferenceField;
			}
			set
			{
				this.created_by_Workers_ReferenceField = value;
				this.RaisePropertyChanged("Created_by_Workers_Reference");
			}
		}

		[XmlElement("Approved_by_Workers_Reference", Order = 7)]
		public WorkerObjectType[] Approved_by_Workers_Reference
		{
			get
			{
				return this.approved_by_Workers_ReferenceField;
			}
			set
			{
				this.approved_by_Workers_ReferenceField = value;
				this.RaisePropertyChanged("Approved_by_Workers_Reference");
			}
		}

		[XmlElement("Internal_Catalog_Reference", Order = 8)]
		public Internal_Service_CatalogObjectType[] Internal_Catalog_Reference
		{
			get
			{
				return this.internal_Catalog_ReferenceField;
			}
			set
			{
				this.internal_Catalog_ReferenceField = value;
				this.RaisePropertyChanged("Internal_Catalog_Reference");
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
