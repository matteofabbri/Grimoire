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
	public class Asset_Request_CriteriaType : INotifyPropertyChanged
	{
		private CompanyObjectType[] company_ReferenceField;

		private WorkerObjectType[] issued_To_Worker_ReferenceField;

		private Spend_CategoryObjectType[] spend_Category_ReferenceField;

		private Purchase_ItemObjectType[] item_ReferenceField;

		private LocationObjectType[] location_ReferenceField;

		private string asset_IdentifierField;

		private string serial_NumberField;

		private Accounting_WorktagObjectType[] worktag_ReferenceField;

		private Document_StatusObjectType[] asset_Status_ReferenceField;

		private Acquisition_MethodObjectType[] acquisition_Method_ReferenceField;

		private Business_Asset_Disposal_MethodObjectType[] disposal_Method_ReferenceField;

		private DateTime acquired_From_DateField;

		private bool acquired_From_DateFieldSpecified;

		private DateTime acquired_To_DateField;

		private bool acquired_To_DateFieldSpecified;

		private DateTime updated_From_DateField;

		private bool updated_From_DateFieldSpecified;

		private DateTime updated_To_DateField;

		private bool updated_To_DateFieldSpecified;

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

		[XmlElement("Issued_To_Worker_Reference", Order = 1)]
		public WorkerObjectType[] Issued_To_Worker_Reference
		{
			get
			{
				return this.issued_To_Worker_ReferenceField;
			}
			set
			{
				this.issued_To_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Issued_To_Worker_Reference");
			}
		}

		[XmlElement("Spend_Category_Reference", Order = 2)]
		public Spend_CategoryObjectType[] Spend_Category_Reference
		{
			get
			{
				return this.spend_Category_ReferenceField;
			}
			set
			{
				this.spend_Category_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_Reference");
			}
		}

		[XmlElement("Item_Reference", Order = 3)]
		public Purchase_ItemObjectType[] Item_Reference
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

		[XmlElement("Location_Reference", Order = 4)]
		public LocationObjectType[] Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Asset_Identifier
		{
			get
			{
				return this.asset_IdentifierField;
			}
			set
			{
				this.asset_IdentifierField = value;
				this.RaisePropertyChanged("Asset_Identifier");
			}
		}

		[XmlElement(Order = 6)]
		public string Serial_Number
		{
			get
			{
				return this.serial_NumberField;
			}
			set
			{
				this.serial_NumberField = value;
				this.RaisePropertyChanged("Serial_Number");
			}
		}

		[XmlElement("Worktag_Reference", Order = 7)]
		public Accounting_WorktagObjectType[] Worktag_Reference
		{
			get
			{
				return this.worktag_ReferenceField;
			}
			set
			{
				this.worktag_ReferenceField = value;
				this.RaisePropertyChanged("Worktag_Reference");
			}
		}

		[XmlElement("Asset_Status_Reference", Order = 8)]
		public Document_StatusObjectType[] Asset_Status_Reference
		{
			get
			{
				return this.asset_Status_ReferenceField;
			}
			set
			{
				this.asset_Status_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Status_Reference");
			}
		}

		[XmlElement("Acquisition_Method_Reference", Order = 9)]
		public Acquisition_MethodObjectType[] Acquisition_Method_Reference
		{
			get
			{
				return this.acquisition_Method_ReferenceField;
			}
			set
			{
				this.acquisition_Method_ReferenceField = value;
				this.RaisePropertyChanged("Acquisition_Method_Reference");
			}
		}

		[XmlElement("Disposal_Method_Reference", Order = 10)]
		public Business_Asset_Disposal_MethodObjectType[] Disposal_Method_Reference
		{
			get
			{
				return this.disposal_Method_ReferenceField;
			}
			set
			{
				this.disposal_Method_ReferenceField = value;
				this.RaisePropertyChanged("Disposal_Method_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 11)]
		public DateTime Acquired_From_Date
		{
			get
			{
				return this.acquired_From_DateField;
			}
			set
			{
				this.acquired_From_DateField = value;
				this.RaisePropertyChanged("Acquired_From_Date");
			}
		}

		[XmlIgnore]
		public bool Acquired_From_DateSpecified
		{
			get
			{
				return this.acquired_From_DateFieldSpecified;
			}
			set
			{
				this.acquired_From_DateFieldSpecified = value;
				this.RaisePropertyChanged("Acquired_From_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 12)]
		public DateTime Acquired_To_Date
		{
			get
			{
				return this.acquired_To_DateField;
			}
			set
			{
				this.acquired_To_DateField = value;
				this.RaisePropertyChanged("Acquired_To_Date");
			}
		}

		[XmlIgnore]
		public bool Acquired_To_DateSpecified
		{
			get
			{
				return this.acquired_To_DateFieldSpecified;
			}
			set
			{
				this.acquired_To_DateFieldSpecified = value;
				this.RaisePropertyChanged("Acquired_To_DateSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public DateTime Updated_From_Date
		{
			get
			{
				return this.updated_From_DateField;
			}
			set
			{
				this.updated_From_DateField = value;
				this.RaisePropertyChanged("Updated_From_Date");
			}
		}

		[XmlIgnore]
		public bool Updated_From_DateSpecified
		{
			get
			{
				return this.updated_From_DateFieldSpecified;
			}
			set
			{
				this.updated_From_DateFieldSpecified = value;
				this.RaisePropertyChanged("Updated_From_DateSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public DateTime Updated_To_Date
		{
			get
			{
				return this.updated_To_DateField;
			}
			set
			{
				this.updated_To_DateField = value;
				this.RaisePropertyChanged("Updated_To_Date");
			}
		}

		[XmlIgnore]
		public bool Updated_To_DateSpecified
		{
			get
			{
				return this.updated_To_DateFieldSpecified;
			}
			set
			{
				this.updated_To_DateFieldSpecified = value;
				this.RaisePropertyChanged("Updated_To_DateSpecified");
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
