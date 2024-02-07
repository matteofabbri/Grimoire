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
	public class Asset_Book_Configurations_Request_CriteriaType : INotifyPropertyChanged
	{
		private CompanyObjectType[] company_ReferenceField;

		private string asset_NameField;

		private Asset_BookObjectType[] asset_Book_ReferenceField;

		private Spend_CategoryObjectType[] spend_Category_ReferenceField;

		private Asset_ClassObjectType[] asset_Class_ReferenceField;

		private Asset_TypeObjectType[] asset_Type_ReferenceField;

		private LocationObjectType[] location_ReferenceField;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private DateTime acquired_From_DateField;

		private bool acquired_From_DateFieldSpecified;

		private DateTime acquired_To_DateField;

		private bool acquired_To_DateFieldSpecified;

		private DateTime in_Service_From_DateField;

		private bool in_Service_From_DateFieldSpecified;

		private DateTime in_Service_To_DateField;

		private bool in_Service_To_DateFieldSpecified;

		private Document_StatusObjectType[] asset_Depreciation_Schedule_Status_ReferenceField;

		private Acquisition_MethodObjectType[] acquisition_Method_ReferenceField;

		private Accounting_TreatmentObjectType[] accounting_Treatment_ReferenceField;

		private bool exclude_Schedules_with_Historical_InformationField;

		private bool exclude_Schedules_with_Historical_InformationFieldSpecified;

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

		[XmlElement(Order = 1)]
		public string Asset_Name
		{
			get
			{
				return this.asset_NameField;
			}
			set
			{
				this.asset_NameField = value;
				this.RaisePropertyChanged("Asset_Name");
			}
		}

		[XmlElement("Asset_Book_Reference", Order = 2)]
		public Asset_BookObjectType[] Asset_Book_Reference
		{
			get
			{
				return this.asset_Book_ReferenceField;
			}
			set
			{
				this.asset_Book_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Book_Reference");
			}
		}

		[XmlElement("Spend_Category_Reference", Order = 3)]
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

		[XmlElement("Asset_Class_Reference", Order = 4)]
		public Asset_ClassObjectType[] Asset_Class_Reference
		{
			get
			{
				return this.asset_Class_ReferenceField;
			}
			set
			{
				this.asset_Class_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Class_Reference");
			}
		}

		[XmlElement("Asset_Type_Reference", Order = 5)]
		public Asset_TypeObjectType[] Asset_Type_Reference
		{
			get
			{
				return this.asset_Type_ReferenceField;
			}
			set
			{
				this.asset_Type_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Type_Reference");
			}
		}

		[XmlElement("Location_Reference", Order = 6)]
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

		[XmlElement("Worktags_Reference", Order = 7)]
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

		[XmlElement(DataType = "date", Order = 8)]
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

		[XmlElement(DataType = "date", Order = 9)]
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

		[XmlElement(DataType = "date", Order = 10)]
		public DateTime In_Service_From_Date
		{
			get
			{
				return this.in_Service_From_DateField;
			}
			set
			{
				this.in_Service_From_DateField = value;
				this.RaisePropertyChanged("In_Service_From_Date");
			}
		}

		[XmlIgnore]
		public bool In_Service_From_DateSpecified
		{
			get
			{
				return this.in_Service_From_DateFieldSpecified;
			}
			set
			{
				this.in_Service_From_DateFieldSpecified = value;
				this.RaisePropertyChanged("In_Service_From_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 11)]
		public DateTime In_Service_To_Date
		{
			get
			{
				return this.in_Service_To_DateField;
			}
			set
			{
				this.in_Service_To_DateField = value;
				this.RaisePropertyChanged("In_Service_To_Date");
			}
		}

		[XmlIgnore]
		public bool In_Service_To_DateSpecified
		{
			get
			{
				return this.in_Service_To_DateFieldSpecified;
			}
			set
			{
				this.in_Service_To_DateFieldSpecified = value;
				this.RaisePropertyChanged("In_Service_To_DateSpecified");
			}
		}

		[XmlElement("Asset_Depreciation_Schedule_Status_Reference", Order = 12)]
		public Document_StatusObjectType[] Asset_Depreciation_Schedule_Status_Reference
		{
			get
			{
				return this.asset_Depreciation_Schedule_Status_ReferenceField;
			}
			set
			{
				this.asset_Depreciation_Schedule_Status_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Depreciation_Schedule_Status_Reference");
			}
		}

		[XmlElement("Acquisition_Method_Reference", Order = 13)]
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

		[XmlElement("Accounting_Treatment_Reference", Order = 14)]
		public Accounting_TreatmentObjectType[] Accounting_Treatment_Reference
		{
			get
			{
				return this.accounting_Treatment_ReferenceField;
			}
			set
			{
				this.accounting_Treatment_ReferenceField = value;
				this.RaisePropertyChanged("Accounting_Treatment_Reference");
			}
		}

		[XmlElement(Order = 15)]
		public bool Exclude_Schedules_with_Historical_Information
		{
			get
			{
				return this.exclude_Schedules_with_Historical_InformationField;
			}
			set
			{
				this.exclude_Schedules_with_Historical_InformationField = value;
				this.RaisePropertyChanged("Exclude_Schedules_with_Historical_Information");
			}
		}

		[XmlIgnore]
		public bool Exclude_Schedules_with_Historical_InformationSpecified
		{
			get
			{
				return this.exclude_Schedules_with_Historical_InformationFieldSpecified;
			}
			set
			{
				this.exclude_Schedules_with_Historical_InformationFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Schedules_with_Historical_InformationSpecified");
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
