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
	public class Location_DataType : INotifyPropertyChanged
	{
		private IDType[] integration_ID_DataField;

		private string location_NameField;

		private Time_Profile_Reference_DataType time_Profile_Reference_DataField;

		private Location_Type_Reference_DataType[] location_Type_Reference_DataField;

		private CurrencyObjectType default_Currency_ReferenceField;

		private string trade_NameField;

		private string worksite_ID_CodeField;

		private Contact_DataType contact_DataField;

		private Container_Organization_Reference_DataType[] container_Organization_Reference_DataField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlArray(Order = 0), XmlArrayItem("ID", IsNullable = false)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Time_Profile_Reference_DataType Time_Profile_Reference_Data
		{
			get
			{
				return this.time_Profile_Reference_DataField;
			}
			set
			{
				this.time_Profile_Reference_DataField = value;
				this.RaisePropertyChanged("Time_Profile_Reference_Data");
			}
		}

		[XmlElement("Location_Type_Reference_Data", Order = 3)]
		public Location_Type_Reference_DataType[] Location_Type_Reference_Data
		{
			get
			{
				return this.location_Type_Reference_DataField;
			}
			set
			{
				this.location_Type_Reference_DataField = value;
				this.RaisePropertyChanged("Location_Type_Reference_Data");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public Contact_DataType Contact_Data
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

		[XmlElement("Container_Organization_Reference_Data", Order = 8)]
		public Container_Organization_Reference_DataType[] Container_Organization_Reference_Data
		{
			get
			{
				return this.container_Organization_Reference_DataField;
			}
			set
			{
				this.container_Organization_Reference_DataField = value;
				this.RaisePropertyChanged("Container_Organization_Reference_Data");
			}
		}

		[XmlElement(Order = 9)]
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
