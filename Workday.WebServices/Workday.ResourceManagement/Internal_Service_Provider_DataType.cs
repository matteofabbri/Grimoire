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
	public class Internal_Service_Provider_DataType : INotifyPropertyChanged
	{
		private string internal_Service_Provider_Reference_IDField;

		private string internal_Service_Provider_NameField;

		private string internal_Service_Provider_IDField;

		private CurrencyObjectType currency_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Abstract_Procurement_CatalogObjectType[] internal_Catalog_ReferenceField;

		private OrganizationObjectType[] company_or_Company_Hierarchy_ReferenceField;

		private DateTime review_DateField;

		private bool review_DateFieldSpecified;

		private DateTime next_Review_DateField;

		private bool next_Review_DateFieldSpecified;

		private string descriptionField;

		private Revenue_CategoryObjectType revenue_Category_ReferenceField;

		private Accounting_WorktagObjectType[] internal_Service_Provider_Worktag_ReferenceField;

		private Financials_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Internal_Service_Provider_Reference_ID
		{
			get
			{
				return this.internal_Service_Provider_Reference_IDField;
			}
			set
			{
				this.internal_Service_Provider_Reference_IDField = value;
				this.RaisePropertyChanged("Internal_Service_Provider_Reference_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Internal_Service_Provider_Name
		{
			get
			{
				return this.internal_Service_Provider_NameField;
			}
			set
			{
				this.internal_Service_Provider_NameField = value;
				this.RaisePropertyChanged("Internal_Service_Provider_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Internal_Service_Provider_ID
		{
			get
			{
				return this.internal_Service_Provider_IDField;
			}
			set
			{
				this.internal_Service_Provider_IDField = value;
				this.RaisePropertyChanged("Internal_Service_Provider_ID");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement("Internal_Catalog_Reference", Order = 5)]
		public Abstract_Procurement_CatalogObjectType[] Internal_Catalog_Reference
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

		[XmlElement("Company_or_Company_Hierarchy_Reference", Order = 6)]
		public OrganizationObjectType[] Company_or_Company_Hierarchy_Reference
		{
			get
			{
				return this.company_or_Company_Hierarchy_ReferenceField;
			}
			set
			{
				this.company_or_Company_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Company_or_Company_Hierarchy_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Review_Date
		{
			get
			{
				return this.review_DateField;
			}
			set
			{
				this.review_DateField = value;
				this.RaisePropertyChanged("Review_Date");
			}
		}

		[XmlIgnore]
		public bool Review_DateSpecified
		{
			get
			{
				return this.review_DateFieldSpecified;
			}
			set
			{
				this.review_DateFieldSpecified = value;
				this.RaisePropertyChanged("Review_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Next_Review_Date
		{
			get
			{
				return this.next_Review_DateField;
			}
			set
			{
				this.next_Review_DateField = value;
				this.RaisePropertyChanged("Next_Review_Date");
			}
		}

		[XmlIgnore]
		public bool Next_Review_DateSpecified
		{
			get
			{
				return this.next_Review_DateFieldSpecified;
			}
			set
			{
				this.next_Review_DateFieldSpecified = value;
				this.RaisePropertyChanged("Next_Review_DateSpecified");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public Revenue_CategoryObjectType Revenue_Category_Reference
		{
			get
			{
				return this.revenue_Category_ReferenceField;
			}
			set
			{
				this.revenue_Category_ReferenceField = value;
				this.RaisePropertyChanged("Revenue_Category_Reference");
			}
		}

		[XmlElement("Internal_Service_Provider_Worktag_Reference", Order = 11)]
		public Accounting_WorktagObjectType[] Internal_Service_Provider_Worktag_Reference
		{
			get
			{
				return this.internal_Service_Provider_Worktag_ReferenceField;
			}
			set
			{
				this.internal_Service_Provider_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Internal_Service_Provider_Worktag_Reference");
			}
		}

		[XmlElement("Attachment_Data", Order = 12)]
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
