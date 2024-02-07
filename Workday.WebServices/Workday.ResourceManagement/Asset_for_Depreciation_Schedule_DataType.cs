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
	public class Asset_for_Depreciation_Schedule_DataType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private string asset_NameField;

		private Spend_CategoryObjectType spend_Category_ReferenceField;

		private Asset_ClassObjectType asset_Class_ReferenceField;

		private Asset_TypeObjectType asset_Type_ReferenceField;

		private LocationObjectType location_ReferenceField;

		private Acquisition_MethodObjectType acquisition_Method_ReferenceField;

		private DateTime date_AcquiredField;

		private bool date_AcquiredFieldSpecified;

		private DateTime first_Issue_DateField;

		private bool first_Issue_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 2)]
		public Spend_CategoryObjectType Spend_Category_Reference
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

		[XmlElement(Order = 3)]
		public Asset_ClassObjectType Asset_Class_Reference
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

		[XmlElement(Order = 4)]
		public Asset_TypeObjectType Asset_Type_Reference
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

		[XmlElement(Order = 5)]
		public LocationObjectType Location_Reference
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

		[XmlElement(Order = 6)]
		public Acquisition_MethodObjectType Acquisition_Method_Reference
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

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Date_Acquired
		{
			get
			{
				return this.date_AcquiredField;
			}
			set
			{
				this.date_AcquiredField = value;
				this.RaisePropertyChanged("Date_Acquired");
			}
		}

		[XmlIgnore]
		public bool Date_AcquiredSpecified
		{
			get
			{
				return this.date_AcquiredFieldSpecified;
			}
			set
			{
				this.date_AcquiredFieldSpecified = value;
				this.RaisePropertyChanged("Date_AcquiredSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime First_Issue_Date
		{
			get
			{
				return this.first_Issue_DateField;
			}
			set
			{
				this.first_Issue_DateField = value;
				this.RaisePropertyChanged("First_Issue_Date");
			}
		}

		[XmlIgnore]
		public bool First_Issue_DateSpecified
		{
			get
			{
				return this.first_Issue_DateFieldSpecified;
			}
			set
			{
				this.first_Issue_DateFieldSpecified = value;
				this.RaisePropertyChanged("First_Issue_DateSpecified");
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
