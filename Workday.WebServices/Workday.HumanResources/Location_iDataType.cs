using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Location_iDataType : INotifyPropertyChanged
	{
		private string location_IDField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private string location_NameField;

		private Location_UsageObjectType[] location_Usage_ReferenceField;

		private Location_TypeObjectType[] location_Type_ReferenceField;

		private Location_AttributeObjectType[] location_Attribute_ReferenceField;

		private LocationObjectType superior_Location_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private decimal latitudeField;

		private bool latitudeFieldSpecified;

		private decimal longitudeField;

		private bool longitudeFieldSpecified;

		private decimal altitudeField;

		private bool altitudeFieldSpecified;

		private Time_ProfileObjectType time_Profile_ReferenceField;

		private LocaleObjectType locale_ReferenceField;

		private User_LanguageObjectType display_Language_ReferenceField;

		private Time_ZoneObjectType time_Zone_ReferenceField;

		private CurrencyObjectType default_Currency_ReferenceField;

		private string external_NameField;

		private LocationObjectType default_Job_Posting_Location_ReferenceField;

		private string trade_NameField;

		private string worksite_ID_CodeField;

		private string global_Location_NumberField;

		private string location_IdentifierField;

		private Location_Instructional_Site_DataType instructional_Site_DataField;

		private Contact_Information_DataType contact_DataField;

		private IDType[] integration_ID_DataField;

		private Location_HierarchyObjectType[] location_Hierarchy_ReferenceField;

		private Document_Field_Result_DataType[] integration_Field_Override_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Location_ID
		{
			get
			{
				return this.location_IDField;
			}
			set
			{
				this.location_IDField = value;
				this.RaisePropertyChanged("Location_ID");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string Location_Name
		{
			get
			{
				return this.location_NameField;
			}
			set
			{
				this.location_NameField = value;
				this.RaisePropertyChanged("Location_Name");
			}
		}

		[XmlElement("Location_Usage_Reference", Order = 3)]
		public Location_UsageObjectType[] Location_Usage_Reference
		{
			get
			{
				return this.location_Usage_ReferenceField;
			}
			set
			{
				this.location_Usage_ReferenceField = value;
				this.RaisePropertyChanged("Location_Usage_Reference");
			}
		}

		[XmlElement("Location_Type_Reference", Order = 4)]
		public Location_TypeObjectType[] Location_Type_Reference
		{
			get
			{
				return this.location_Type_ReferenceField;
			}
			set
			{
				this.location_Type_ReferenceField = value;
				this.RaisePropertyChanged("Location_Type_Reference");
			}
		}

		[XmlElement("Location_Attribute_Reference", Order = 5)]
		public Location_AttributeObjectType[] Location_Attribute_Reference
		{
			get
			{
				return this.location_Attribute_ReferenceField;
			}
			set
			{
				this.location_Attribute_ReferenceField = value;
				this.RaisePropertyChanged("Location_Attribute_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public LocationObjectType Superior_Location_Reference
		{
			get
			{
				return this.superior_Location_ReferenceField;
			}
			set
			{
				this.superior_Location_ReferenceField = value;
				this.RaisePropertyChanged("Superior_Location_Reference");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
		public decimal Latitude
		{
			get
			{
				return this.latitudeField;
			}
			set
			{
				this.latitudeField = value;
				this.RaisePropertyChanged("Latitude");
			}
		}

		[XmlIgnore]
		public bool LatitudeSpecified
		{
			get
			{
				return this.latitudeFieldSpecified;
			}
			set
			{
				this.latitudeFieldSpecified = value;
				this.RaisePropertyChanged("LatitudeSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Longitude
		{
			get
			{
				return this.longitudeField;
			}
			set
			{
				this.longitudeField = value;
				this.RaisePropertyChanged("Longitude");
			}
		}

		[XmlIgnore]
		public bool LongitudeSpecified
		{
			get
			{
				return this.longitudeFieldSpecified;
			}
			set
			{
				this.longitudeFieldSpecified = value;
				this.RaisePropertyChanged("LongitudeSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Altitude
		{
			get
			{
				return this.altitudeField;
			}
			set
			{
				this.altitudeField = value;
				this.RaisePropertyChanged("Altitude");
			}
		}

		[XmlIgnore]
		public bool AltitudeSpecified
		{
			get
			{
				return this.altitudeFieldSpecified;
			}
			set
			{
				this.altitudeFieldSpecified = value;
				this.RaisePropertyChanged("AltitudeSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public Time_ProfileObjectType Time_Profile_Reference
		{
			get
			{
				return this.time_Profile_ReferenceField;
			}
			set
			{
				this.time_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Time_Profile_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public LocaleObjectType Locale_Reference
		{
			get
			{
				return this.locale_ReferenceField;
			}
			set
			{
				this.locale_ReferenceField = value;
				this.RaisePropertyChanged("Locale_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public User_LanguageObjectType Display_Language_Reference
		{
			get
			{
				return this.display_Language_ReferenceField;
			}
			set
			{
				this.display_Language_ReferenceField = value;
				this.RaisePropertyChanged("Display_Language_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public Time_ZoneObjectType Time_Zone_Reference
		{
			get
			{
				return this.time_Zone_ReferenceField;
			}
			set
			{
				this.time_Zone_ReferenceField = value;
				this.RaisePropertyChanged("Time_Zone_Reference");
			}
		}

		[XmlElement(Order = 15)]
		public CurrencyObjectType Default_Currency_Reference
		{
			get
			{
				return this.default_Currency_ReferenceField;
			}
			set
			{
				this.default_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Default_Currency_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public string External_Name
		{
			get
			{
				return this.external_NameField;
			}
			set
			{
				this.external_NameField = value;
				this.RaisePropertyChanged("External_Name");
			}
		}

		[XmlElement(Order = 17)]
		public LocationObjectType Default_Job_Posting_Location_Reference
		{
			get
			{
				return this.default_Job_Posting_Location_ReferenceField;
			}
			set
			{
				this.default_Job_Posting_Location_ReferenceField = value;
				this.RaisePropertyChanged("Default_Job_Posting_Location_Reference");
			}
		}

		[XmlElement(Order = 18)]
		public string Trade_Name
		{
			get
			{
				return this.trade_NameField;
			}
			set
			{
				this.trade_NameField = value;
				this.RaisePropertyChanged("Trade_Name");
			}
		}

		[XmlElement(Order = 19)]
		public string Worksite_ID_Code
		{
			get
			{
				return this.worksite_ID_CodeField;
			}
			set
			{
				this.worksite_ID_CodeField = value;
				this.RaisePropertyChanged("Worksite_ID_Code");
			}
		}

		[XmlElement(Order = 20)]
		public string Global_Location_Number
		{
			get
			{
				return this.global_Location_NumberField;
			}
			set
			{
				this.global_Location_NumberField = value;
				this.RaisePropertyChanged("Global_Location_Number");
			}
		}

		[XmlElement(Order = 21)]
		public string Location_Identifier
		{
			get
			{
				return this.location_IdentifierField;
			}
			set
			{
				this.location_IdentifierField = value;
				this.RaisePropertyChanged("Location_Identifier");
			}
		}

		[XmlElement(Order = 22)]
		public Location_Instructional_Site_DataType Instructional_Site_Data
		{
			get
			{
				return this.instructional_Site_DataField;
			}
			set
			{
				this.instructional_Site_DataField = value;
				this.RaisePropertyChanged("Instructional_Site_Data");
			}
		}

		[XmlElement(Order = 23)]
		public Contact_Information_DataType Contact_Data
		{
			get
			{
				return this.contact_DataField;
			}
			set
			{
				this.contact_DataField = value;
				this.RaisePropertyChanged("Contact_Data");
			}
		}

		[XmlArray(Order = 24), XmlArrayItem("ID", IsNullable = false)]
		public IDType[] Integration_ID_Data
		{
			get
			{
				return this.integration_ID_DataField;
			}
			set
			{
				this.integration_ID_DataField = value;
				this.RaisePropertyChanged("Integration_ID_Data");
			}
		}

		[XmlElement("Location_Hierarchy_Reference", Order = 25)]
		public Location_HierarchyObjectType[] Location_Hierarchy_Reference
		{
			get
			{
				return this.location_Hierarchy_ReferenceField;
			}
			set
			{
				this.location_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Location_Hierarchy_Reference");
			}
		}

		[XmlElement("Integration_Field_Override_Data", Order = 26)]
		public Document_Field_Result_DataType[] Integration_Field_Override_Data
		{
			get
			{
				return this.integration_Field_Override_DataField;
			}
			set
			{
				this.integration_Field_Override_DataField = value;
				this.RaisePropertyChanged("Integration_Field_Override_Data");
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
