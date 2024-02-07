using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Address_Information_DataType : INotifyPropertyChanged
	{
		private CountryObjectType country_ReferenceField;

		private DateTime last_ModifiedField;

		private bool last_ModifiedFieldSpecified;

		private Address_Line_Information_DataType[] address_Line_DataField;

		private string municipalityField;

		private Country_CityObjectType country_City_ReferenceField;

		private Submunicipality_Information_DataType[] submunicipality_DataField;

		private Country_RegionObjectType country_Region_ReferenceField;

		private string country_Region_DescriptorField;

		private Subregion_Information_DataType[] subregion_DataField;

		private string postal_CodeField;

		private Communication_Method_Usage_Information_DataType[] usage_DataField;

		private string municipality_LocalField;

		private Address_ReferenceObjectType address_ReferenceField;

		private string address_IDField;

		private string formatted_AddressField;

		private string address_Format_TypeField;

		private bool defaulted_Business_Site_AddressField;

		private bool defaulted_Business_Site_AddressFieldSpecified;

		private bool deleteField;

		private bool deleteFieldSpecified;

		private bool do_Not_Replace_AllField;

		private bool do_Not_Replace_AllFieldSpecified;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public DateTime Last_Modified
		{
			get
			{
				return this.last_ModifiedField;
			}
			set
			{
				this.last_ModifiedField = value;
				this.RaisePropertyChanged("Last_Modified");
			}
		}

		[XmlIgnore]
		public bool Last_ModifiedSpecified
		{
			get
			{
				return this.last_ModifiedFieldSpecified;
			}
			set
			{
				this.last_ModifiedFieldSpecified = value;
				this.RaisePropertyChanged("Last_ModifiedSpecified");
			}
		}

		[XmlElement("Address_Line_Data", Order = 2)]
		public Address_Line_Information_DataType[] Address_Line_Data
		{
			get
			{
				return this.address_Line_DataField;
			}
			set
			{
				this.address_Line_DataField = value;
				this.RaisePropertyChanged("Address_Line_Data");
			}
		}

		[XmlElement(Order = 3)]
		public string Municipality
		{
			get
			{
				return this.municipalityField;
			}
			set
			{
				this.municipalityField = value;
				this.RaisePropertyChanged("Municipality");
			}
		}

		[XmlElement(Order = 4)]
		public Country_CityObjectType Country_City_Reference
		{
			get
			{
				return this.country_City_ReferenceField;
			}
			set
			{
				this.country_City_ReferenceField = value;
				this.RaisePropertyChanged("Country_City_Reference");
			}
		}

		[XmlElement("Submunicipality_Data", Order = 5)]
		public Submunicipality_Information_DataType[] Submunicipality_Data
		{
			get
			{
				return this.submunicipality_DataField;
			}
			set
			{
				this.submunicipality_DataField = value;
				this.RaisePropertyChanged("Submunicipality_Data");
			}
		}

		[XmlElement(Order = 6)]
		public Country_RegionObjectType Country_Region_Reference
		{
			get
			{
				return this.country_Region_ReferenceField;
			}
			set
			{
				this.country_Region_ReferenceField = value;
				this.RaisePropertyChanged("Country_Region_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public string Country_Region_Descriptor
		{
			get
			{
				return this.country_Region_DescriptorField;
			}
			set
			{
				this.country_Region_DescriptorField = value;
				this.RaisePropertyChanged("Country_Region_Descriptor");
			}
		}

		[XmlElement("Subregion_Data", Order = 8)]
		public Subregion_Information_DataType[] Subregion_Data
		{
			get
			{
				return this.subregion_DataField;
			}
			set
			{
				this.subregion_DataField = value;
				this.RaisePropertyChanged("Subregion_Data");
			}
		}

		[XmlElement(Order = 9)]
		public string Postal_Code
		{
			get
			{
				return this.postal_CodeField;
			}
			set
			{
				this.postal_CodeField = value;
				this.RaisePropertyChanged("Postal_Code");
			}
		}

		[XmlElement("Usage_Data", Order = 10)]
		public Communication_Method_Usage_Information_DataType[] Usage_Data
		{
			get
			{
				return this.usage_DataField;
			}
			set
			{
				this.usage_DataField = value;
				this.RaisePropertyChanged("Usage_Data");
			}
		}

		[XmlElement(Order = 11)]
		public string Municipality_Local
		{
			get
			{
				return this.municipality_LocalField;
			}
			set
			{
				this.municipality_LocalField = value;
				this.RaisePropertyChanged("Municipality_Local");
			}
		}

		[XmlElement(Order = 12)]
		public Address_ReferenceObjectType Address_Reference
		{
			get
			{
				return this.address_ReferenceField;
			}
			set
			{
				this.address_ReferenceField = value;
				this.RaisePropertyChanged("Address_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public string Address_ID
		{
			get
			{
				return this.address_IDField;
			}
			set
			{
				this.address_IDField = value;
				this.RaisePropertyChanged("Address_ID");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Formatted_Address
		{
			get
			{
				return this.formatted_AddressField;
			}
			set
			{
				this.formatted_AddressField = value;
				this.RaisePropertyChanged("Formatted_Address");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Address_Format_Type
		{
			get
			{
				return this.address_Format_TypeField;
			}
			set
			{
				this.address_Format_TypeField = value;
				this.RaisePropertyChanged("Address_Format_Type");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Defaulted_Business_Site_Address
		{
			get
			{
				return this.defaulted_Business_Site_AddressField;
			}
			set
			{
				this.defaulted_Business_Site_AddressField = value;
				this.RaisePropertyChanged("Defaulted_Business_Site_Address");
			}
		}

		[XmlIgnore]
		public bool Defaulted_Business_Site_AddressSpecified
		{
			get
			{
				return this.defaulted_Business_Site_AddressFieldSpecified;
			}
			set
			{
				this.defaulted_Business_Site_AddressFieldSpecified = value;
				this.RaisePropertyChanged("Defaulted_Business_Site_AddressSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
				this.RaisePropertyChanged("Delete");
			}
		}

		[XmlIgnore]
		public bool DeleteSpecified
		{
			get
			{
				return this.deleteFieldSpecified;
			}
			set
			{
				this.deleteFieldSpecified = value;
				this.RaisePropertyChanged("DeleteSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Do_Not_Replace_All
		{
			get
			{
				return this.do_Not_Replace_AllField;
			}
			set
			{
				this.do_Not_Replace_AllField = value;
				this.RaisePropertyChanged("Do_Not_Replace_All");
			}
		}

		[XmlIgnore]
		public bool Do_Not_Replace_AllSpecified
		{
			get
			{
				return this.do_Not_Replace_AllFieldSpecified;
			}
			set
			{
				this.do_Not_Replace_AllFieldSpecified = value;
				this.RaisePropertyChanged("Do_Not_Replace_AllSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified, DataType = "date")]
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
