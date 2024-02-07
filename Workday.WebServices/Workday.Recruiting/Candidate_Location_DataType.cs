using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Candidate_Location_DataType : INotifyPropertyChanged
	{
		private CountryObjectType country_ReferenceField;

		private string address_Line_1Field;

		private string address_Line_2Field;

		private string address_Line_3Field;

		private string address_Line_1__LocalField;

		private string address_Line_5__LocalField;

		private string cityField;

		private string city__LocalField;

		private string city_Subdivision_1Field;

		private string city_Subdivision_1__LocalField;

		private Country_RegionObjectType country_Region_ReferenceField;

		private string region_Subdivision_1Field;

		private string region_Subdivision_2Field;

		private string postal_CodeField;

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
		public string Address_Line_1
		{
			get
			{
				return this.address_Line_1Field;
			}
			set
			{
				this.address_Line_1Field = value;
				this.RaisePropertyChanged("Address_Line_1");
			}
		}

		[XmlElement(Order = 2)]
		public string Address_Line_2
		{
			get
			{
				return this.address_Line_2Field;
			}
			set
			{
				this.address_Line_2Field = value;
				this.RaisePropertyChanged("Address_Line_2");
			}
		}

		[XmlElement(Order = 3)]
		public string Address_Line_3
		{
			get
			{
				return this.address_Line_3Field;
			}
			set
			{
				this.address_Line_3Field = value;
				this.RaisePropertyChanged("Address_Line_3");
			}
		}

		[XmlElement("Address_Line_1_-_Local", Order = 4)]
		public string Address_Line_1__Local
		{
			get
			{
				return this.address_Line_1__LocalField;
			}
			set
			{
				this.address_Line_1__LocalField = value;
				this.RaisePropertyChanged("Address_Line_1__Local");
			}
		}

		[XmlElement("Address_Line_5_-_Local", Order = 5)]
		public string Address_Line_5__Local
		{
			get
			{
				return this.address_Line_5__LocalField;
			}
			set
			{
				this.address_Line_5__LocalField = value;
				this.RaisePropertyChanged("Address_Line_5__Local");
			}
		}

		[XmlElement(Order = 6)]
		public string City
		{
			get
			{
				return this.cityField;
			}
			set
			{
				this.cityField = value;
				this.RaisePropertyChanged("City");
			}
		}

		[XmlElement("City_-_Local", Order = 7)]
		public string City__Local
		{
			get
			{
				return this.city__LocalField;
			}
			set
			{
				this.city__LocalField = value;
				this.RaisePropertyChanged("City__Local");
			}
		}

		[XmlElement(Order = 8)]
		public string City_Subdivision_1
		{
			get
			{
				return this.city_Subdivision_1Field;
			}
			set
			{
				this.city_Subdivision_1Field = value;
				this.RaisePropertyChanged("City_Subdivision_1");
			}
		}

		[XmlElement("City_Subdivision_1_-_Local", Order = 9)]
		public string City_Subdivision_1__Local
		{
			get
			{
				return this.city_Subdivision_1__LocalField;
			}
			set
			{
				this.city_Subdivision_1__LocalField = value;
				this.RaisePropertyChanged("City_Subdivision_1__Local");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
		public string Region_Subdivision_1
		{
			get
			{
				return this.region_Subdivision_1Field;
			}
			set
			{
				this.region_Subdivision_1Field = value;
				this.RaisePropertyChanged("Region_Subdivision_1");
			}
		}

		[XmlElement(Order = 12)]
		public string Region_Subdivision_2
		{
			get
			{
				return this.region_Subdivision_2Field;
			}
			set
			{
				this.region_Subdivision_2Field = value;
				this.RaisePropertyChanged("Region_Subdivision_2");
			}
		}

		[XmlElement(Order = 13)]
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
