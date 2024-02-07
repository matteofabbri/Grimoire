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
	public class Travel_City_DataType : INotifyPropertyChanged
	{
		private string spend_Data_IDField;

		private string travel_City_ValueField;

		private Country_RegionObjectType travel_Region_ReferenceField;

		private CountryObjectType country_ReferenceField;

		private Travel_City_Alternate_Name_DataType[] alternate_Travel_City_NameField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Spend_Data_ID
		{
			get
			{
				return this.spend_Data_IDField;
			}
			set
			{
				this.spend_Data_IDField = value;
				this.RaisePropertyChanged("Spend_Data_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Travel_City_Value
		{
			get
			{
				return this.travel_City_ValueField;
			}
			set
			{
				this.travel_City_ValueField = value;
				this.RaisePropertyChanged("Travel_City_Value");
			}
		}

		[XmlElement(Order = 2)]
		public Country_RegionObjectType Travel_Region_Reference
		{
			get
			{
				return this.travel_Region_ReferenceField;
			}
			set
			{
				this.travel_Region_ReferenceField = value;
				this.RaisePropertyChanged("Travel_Region_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public CountryObjectType Country_Reference
		{
			get
			{
				return this.country_ReferenceField;
			}
			set
			{
				this.country_ReferenceField = value;
				this.RaisePropertyChanged("Country_Reference");
			}
		}

		[XmlElement("Alternate_Travel_City_Name", Order = 4)]
		public Travel_City_Alternate_Name_DataType[] Alternate_Travel_City_Name
		{
			get
			{
				return this.alternate_Travel_City_NameField;
			}
			set
			{
				this.alternate_Travel_City_NameField = value;
				this.RaisePropertyChanged("Alternate_Travel_City_Name");
			}
		}

		[XmlElement(Order = 5)]
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
