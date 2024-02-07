using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Demographic_DataType : INotifyPropertyChanged
	{
		private Marital_Status_ReferenceType marital_Status_ReferenceField;

		private bool hispanic_or_LatinoField;

		private bool hispanic_or_LatinoFieldSpecified;

		private Ethnicity_ReferenceType[] ethnicity_ReferenceField;

		private Citizenship_Status_ReferenceType[] citizenship_Status_ReferenceField;

		private CountryObjectType nationality_ReferenceField;

		private Country_RegionObjectType hukou_Region_ReferenceField;

		private Country_SubregionObjectType hukou_Subregion_ReferenceField;

		private string hukou_LocalityField;

		private string hukou_Postal_CodeField;

		private Hukou_TypeObjectType hukou_Type_ReferenceField;

		private Country_RegionObjectType native_Region_ReferenceField;

		private string personnel_File_AgencyField;

		private Military_Service_DataType[] military_Service_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Marital_Status_ReferenceType Marital_Status_Reference
		{
			get
			{
				return this.marital_Status_ReferenceField;
			}
			set
			{
				this.marital_Status_ReferenceField = value;
				this.RaisePropertyChanged("Marital_Status_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Hispanic_or_Latino
		{
			get
			{
				return this.hispanic_or_LatinoField;
			}
			set
			{
				this.hispanic_or_LatinoField = value;
				this.RaisePropertyChanged("Hispanic_or_Latino");
			}
		}

		[XmlIgnore]
		public bool Hispanic_or_LatinoSpecified
		{
			get
			{
				return this.hispanic_or_LatinoFieldSpecified;
			}
			set
			{
				this.hispanic_or_LatinoFieldSpecified = value;
				this.RaisePropertyChanged("Hispanic_or_LatinoSpecified");
			}
		}

		[XmlElement("Ethnicity_Reference", Order = 2)]
		public Ethnicity_ReferenceType[] Ethnicity_Reference
		{
			get
			{
				return this.ethnicity_ReferenceField;
			}
			set
			{
				this.ethnicity_ReferenceField = value;
				this.RaisePropertyChanged("Ethnicity_Reference");
			}
		}

		[XmlElement("Citizenship_Status_Reference", Order = 3)]
		public Citizenship_Status_ReferenceType[] Citizenship_Status_Reference
		{
			get
			{
				return this.citizenship_Status_ReferenceField;
			}
			set
			{
				this.citizenship_Status_ReferenceField = value;
				this.RaisePropertyChanged("Citizenship_Status_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public CountryObjectType Nationality_Reference
		{
			get
			{
				return this.nationality_ReferenceField;
			}
			set
			{
				this.nationality_ReferenceField = value;
				this.RaisePropertyChanged("Nationality_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Country_RegionObjectType Hukou_Region_Reference
		{
			get
			{
				return this.hukou_Region_ReferenceField;
			}
			set
			{
				this.hukou_Region_ReferenceField = value;
				this.RaisePropertyChanged("Hukou_Region_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Country_SubregionObjectType Hukou_Subregion_Reference
		{
			get
			{
				return this.hukou_Subregion_ReferenceField;
			}
			set
			{
				this.hukou_Subregion_ReferenceField = value;
				this.RaisePropertyChanged("Hukou_Subregion_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public string Hukou_Locality
		{
			get
			{
				return this.hukou_LocalityField;
			}
			set
			{
				this.hukou_LocalityField = value;
				this.RaisePropertyChanged("Hukou_Locality");
			}
		}

		[XmlElement(Order = 8)]
		public string Hukou_Postal_Code
		{
			get
			{
				return this.hukou_Postal_CodeField;
			}
			set
			{
				this.hukou_Postal_CodeField = value;
				this.RaisePropertyChanged("Hukou_Postal_Code");
			}
		}

		[XmlElement(Order = 9)]
		public Hukou_TypeObjectType Hukou_Type_Reference
		{
			get
			{
				return this.hukou_Type_ReferenceField;
			}
			set
			{
				this.hukou_Type_ReferenceField = value;
				this.RaisePropertyChanged("Hukou_Type_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public Country_RegionObjectType Native_Region_Reference
		{
			get
			{
				return this.native_Region_ReferenceField;
			}
			set
			{
				this.native_Region_ReferenceField = value;
				this.RaisePropertyChanged("Native_Region_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public string Personnel_File_Agency
		{
			get
			{
				return this.personnel_File_AgencyField;
			}
			set
			{
				this.personnel_File_AgencyField = value;
				this.RaisePropertyChanged("Personnel_File_Agency");
			}
		}

		[XmlElement("Military_Service_Data", Order = 12)]
		public Military_Service_DataType[] Military_Service_Data
		{
			get
			{
				return this.military_Service_DataField;
			}
			set
			{
				this.military_Service_DataField = value;
				this.RaisePropertyChanged("Military_Service_Data");
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
