using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Location_Summary_DataType : INotifyPropertyChanged
	{
		private LocationObjectType location_ReferenceField;

		private string nameField;

		private Location_TypeObjectType[] location_Type_ReferenceField;

		private LocaleObjectType local_ReferenceField;

		private User_LanguageObjectType display_Language_ReferenceField;

		private Time_ProfileObjectType time_Profile_ReferenceField;

		private decimal scheduled_Weekly_HoursField;

		private bool scheduled_Weekly_HoursFieldSpecified;

		private Address_Information_DataType[] address_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement("Location_Type_Reference", Order = 2)]
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

		[XmlElement(Order = 3)]
		public LocaleObjectType Local_Reference
		{
			get
			{
				return this.local_ReferenceField;
			}
			set
			{
				this.local_ReferenceField = value;
				this.RaisePropertyChanged("Local_Reference");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
		public decimal Scheduled_Weekly_Hours
		{
			get
			{
				return this.scheduled_Weekly_HoursField;
			}
			set
			{
				this.scheduled_Weekly_HoursField = value;
				this.RaisePropertyChanged("Scheduled_Weekly_Hours");
			}
		}

		[XmlIgnore]
		public bool Scheduled_Weekly_HoursSpecified
		{
			get
			{
				return this.scheduled_Weekly_HoursFieldSpecified;
			}
			set
			{
				this.scheduled_Weekly_HoursFieldSpecified = value;
				this.RaisePropertyChanged("Scheduled_Weekly_HoursSpecified");
			}
		}

		[XmlElement("Address_Data", Order = 7)]
		public Address_Information_DataType[] Address_Data
		{
			get
			{
				return this.address_DataField;
			}
			set
			{
				this.address_DataField = value;
				this.RaisePropertyChanged("Address_Data");
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
