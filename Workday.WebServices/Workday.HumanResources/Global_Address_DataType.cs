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
	public class Global_Address_DataType : INotifyPropertyChanged
	{
		private string address_Line_1Field;

		private string address_Line_2Field;

		private string address_Line_3Field;

		private string address_Line_4Field;

		private string address_Line_5Field;

		private string address_Line_6Field;

		private string address_Line_7Field;

		private string address_Line_8Field;

		private string address_Line_9Field;

		private string cityField;

		private string city_Subdivision_1Field;

		private string city_Subdivision_2Field;

		private Country_RegionObjectType country_Region_ReferenceField;

		private string region_Subdivision_1Field;

		private string region_Subdivision_2Field;

		private string postal_CodeField;

		private CountryObjectType country_ReferenceField;

		private string address_Line_1__LocalField;

		private string address_Line_2__LocalField;

		private string address_Line_3__LocalField;

		private string address_Line_4__LocalField;

		private string address_Line_5__LocalField;

		private string address_Line_6__LocalField;

		private string address_Line_7__LocalField;

		private string address_Line_8__LocalField;

		private string address_Line_9__LocalField;

		private string city__LocalField;

		private string city_Subdivision_1__LocalField;

		private string city_Subdivision_2__LocalField;

		private string region_Subdivision_1__LocalField;

		private string region_Subdivision_2__LocalField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public string Address_Line_4
		{
			get
			{
				return this.address_Line_4Field;
			}
			set
			{
				this.address_Line_4Field = value;
				this.RaisePropertyChanged("Address_Line_4");
			}
		}

		[XmlElement(Order = 4)]
		public string Address_Line_5
		{
			get
			{
				return this.address_Line_5Field;
			}
			set
			{
				this.address_Line_5Field = value;
				this.RaisePropertyChanged("Address_Line_5");
			}
		}

		[XmlElement(Order = 5)]
		public string Address_Line_6
		{
			get
			{
				return this.address_Line_6Field;
			}
			set
			{
				this.address_Line_6Field = value;
				this.RaisePropertyChanged("Address_Line_6");
			}
		}

		[XmlElement(Order = 6)]
		public string Address_Line_7
		{
			get
			{
				return this.address_Line_7Field;
			}
			set
			{
				this.address_Line_7Field = value;
				this.RaisePropertyChanged("Address_Line_7");
			}
		}

		[XmlElement(Order = 7)]
		public string Address_Line_8
		{
			get
			{
				return this.address_Line_8Field;
			}
			set
			{
				this.address_Line_8Field = value;
				this.RaisePropertyChanged("Address_Line_8");
			}
		}

		[XmlElement(Order = 8)]
		public string Address_Line_9
		{
			get
			{
				return this.address_Line_9Field;
			}
			set
			{
				this.address_Line_9Field = value;
				this.RaisePropertyChanged("Address_Line_9");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
		public string City_Subdivision_2
		{
			get
			{
				return this.city_Subdivision_2Field;
			}
			set
			{
				this.city_Subdivision_2Field = value;
				this.RaisePropertyChanged("City_Subdivision_2");
			}
		}

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
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

		[XmlElement(Order = 15)]
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

		[XmlElement(Order = 16)]
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

		[XmlElement("Address_Line_1_-_Local", Order = 17)]
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

		[XmlElement("Address_Line_2_-_Local", Order = 18)]
		public string Address_Line_2__Local
		{
			get
			{
				return this.address_Line_2__LocalField;
			}
			set
			{
				this.address_Line_2__LocalField = value;
				this.RaisePropertyChanged("Address_Line_2__Local");
			}
		}

		[XmlElement("Address_Line_3_-_Local", Order = 19)]
		public string Address_Line_3__Local
		{
			get
			{
				return this.address_Line_3__LocalField;
			}
			set
			{
				this.address_Line_3__LocalField = value;
				this.RaisePropertyChanged("Address_Line_3__Local");
			}
		}

		[XmlElement("Address_Line_4_-_Local", Order = 20)]
		public string Address_Line_4__Local
		{
			get
			{
				return this.address_Line_4__LocalField;
			}
			set
			{
				this.address_Line_4__LocalField = value;
				this.RaisePropertyChanged("Address_Line_4__Local");
			}
		}

		[XmlElement("Address_Line_5_-_Local", Order = 21)]
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

		[XmlElement("Address_Line_6_-_Local", Order = 22)]
		public string Address_Line_6__Local
		{
			get
			{
				return this.address_Line_6__LocalField;
			}
			set
			{
				this.address_Line_6__LocalField = value;
				this.RaisePropertyChanged("Address_Line_6__Local");
			}
		}

		[XmlElement("Address_Line_7_-_Local", Order = 23)]
		public string Address_Line_7__Local
		{
			get
			{
				return this.address_Line_7__LocalField;
			}
			set
			{
				this.address_Line_7__LocalField = value;
				this.RaisePropertyChanged("Address_Line_7__Local");
			}
		}

		[XmlElement("Address_Line_8_-_Local", Order = 24)]
		public string Address_Line_8__Local
		{
			get
			{
				return this.address_Line_8__LocalField;
			}
			set
			{
				this.address_Line_8__LocalField = value;
				this.RaisePropertyChanged("Address_Line_8__Local");
			}
		}

		[XmlElement("Address_Line_9_-_Local", Order = 25)]
		public string Address_Line_9__Local
		{
			get
			{
				return this.address_Line_9__LocalField;
			}
			set
			{
				this.address_Line_9__LocalField = value;
				this.RaisePropertyChanged("Address_Line_9__Local");
			}
		}

		[XmlElement("City_-_Local", Order = 26)]
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

		[XmlElement("City_Subdivision_1_-_Local", Order = 27)]
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

		[XmlElement("City_Subdivision_2_-_Local", Order = 28)]
		public string City_Subdivision_2__Local
		{
			get
			{
				return this.city_Subdivision_2__LocalField;
			}
			set
			{
				this.city_Subdivision_2__LocalField = value;
				this.RaisePropertyChanged("City_Subdivision_2__Local");
			}
		}

		[XmlElement("Region_Subdivision_1_-_Local", Order = 29)]
		public string Region_Subdivision_1__Local
		{
			get
			{
				return this.region_Subdivision_1__LocalField;
			}
			set
			{
				this.region_Subdivision_1__LocalField = value;
				this.RaisePropertyChanged("Region_Subdivision_1__Local");
			}
		}

		[XmlElement("Region_Subdivision_2_-_Local", Order = 30)]
		public string Region_Subdivision_2__Local
		{
			get
			{
				return this.region_Subdivision_2__LocalField;
			}
			set
			{
				this.region_Subdivision_2__LocalField = value;
				this.RaisePropertyChanged("Region_Subdivision_2__Local");
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
