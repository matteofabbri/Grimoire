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
	public class Establishment_DataType : INotifyPropertyChanged
	{
		private string establishment_NumberField;

		private string idField;

		private CountryObjectType country_ReferenceField;

		private DateTime effective_DateField;

		private string establishment_NameField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private LocationObjectType[] location_ReferenceField;

		private Establishment_Legal_EntityObjectType[] establishment_Legal_Entity_ReferenceField;

		private string dUNS_TextField;

		private string eEO_TextField;

		private string industry_Code_TextField;

		private string sIRET_TextField;

		private string vETS_TextField;

		private bool establishment_HeadquartersField;

		private bool establishment_HeadquartersFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Establishment_Number
		{
			get
			{
				return this.establishment_NumberField;
			}
			set
			{
				this.establishment_NumberField = value;
				this.RaisePropertyChanged("Establishment_Number");
			}
		}

		[XmlElement(Order = 1)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(DataType = "date", Order = 3)]
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

		[XmlElement(Order = 4)]
		public string Establishment_Name
		{
			get
			{
				return this.establishment_NameField;
			}
			set
			{
				this.establishment_NameField = value;
				this.RaisePropertyChanged("Establishment_Name");
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

		[XmlElement("Establishment_Legal_Entity_Reference", Order = 7)]
		public Establishment_Legal_EntityObjectType[] Establishment_Legal_Entity_Reference
		{
			get
			{
				return this.establishment_Legal_Entity_ReferenceField;
			}
			set
			{
				this.establishment_Legal_Entity_ReferenceField = value;
				this.RaisePropertyChanged("Establishment_Legal_Entity_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public string DUNS_Text
		{
			get
			{
				return this.dUNS_TextField;
			}
			set
			{
				this.dUNS_TextField = value;
				this.RaisePropertyChanged("DUNS_Text");
			}
		}

		[XmlElement(Order = 9)]
		public string EEO_Text
		{
			get
			{
				return this.eEO_TextField;
			}
			set
			{
				this.eEO_TextField = value;
				this.RaisePropertyChanged("EEO_Text");
			}
		}

		[XmlElement(Order = 10)]
		public string Industry_Code_Text
		{
			get
			{
				return this.industry_Code_TextField;
			}
			set
			{
				this.industry_Code_TextField = value;
				this.RaisePropertyChanged("Industry_Code_Text");
			}
		}

		[XmlElement(Order = 11)]
		public string SIRET_Text
		{
			get
			{
				return this.sIRET_TextField;
			}
			set
			{
				this.sIRET_TextField = value;
				this.RaisePropertyChanged("SIRET_Text");
			}
		}

		[XmlElement(Order = 12)]
		public string VETS_Text
		{
			get
			{
				return this.vETS_TextField;
			}
			set
			{
				this.vETS_TextField = value;
				this.RaisePropertyChanged("VETS_Text");
			}
		}

		[XmlElement(Order = 13)]
		public bool Establishment_Headquarters
		{
			get
			{
				return this.establishment_HeadquartersField;
			}
			set
			{
				this.establishment_HeadquartersField = value;
				this.RaisePropertyChanged("Establishment_Headquarters");
			}
		}

		[XmlIgnore]
		public bool Establishment_HeadquartersSpecified
		{
			get
			{
				return this.establishment_HeadquartersFieldSpecified;
			}
			set
			{
				this.establishment_HeadquartersFieldSpecified = value;
				this.RaisePropertyChanged("Establishment_HeadquartersSpecified");
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
