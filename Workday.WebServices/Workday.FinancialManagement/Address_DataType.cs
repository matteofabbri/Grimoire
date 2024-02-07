using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Address_DataType : INotifyPropertyChanged
	{
		private Country_ReferenceType country_ReferenceField;

		private Address_Line_DataType[] address_LineField;

		private string municipalityField;

		private string[] submunicipalityField;

		private string regionField;

		private Subregion_DataType[] subregionField;

		private string postal_CodeField;

		private Communication_Method_Usage_DataType usage_DataField;

		private DateTime last_ModifiedField;

		private bool last_ModifiedFieldSpecified;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Country_ReferenceType Country_Reference
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

		[XmlElement("Address_Line", Order = 1)]
		public Address_Line_DataType[] Address_Line
		{
			get
			{
				return this.address_LineField;
			}
			set
			{
				this.address_LineField = value;
				this.RaisePropertyChanged("Address_Line");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement("Submunicipality", Order = 3)]
		public string[] Submunicipality
		{
			get
			{
				return this.submunicipalityField;
			}
			set
			{
				this.submunicipalityField = value;
				this.RaisePropertyChanged("Submunicipality");
			}
		}

		[XmlElement(Order = 4)]
		public string Region
		{
			get
			{
				return this.regionField;
			}
			set
			{
				this.regionField = value;
				this.RaisePropertyChanged("Region");
			}
		}

		[XmlElement("Subregion", Order = 5)]
		public Subregion_DataType[] Subregion
		{
			get
			{
				return this.subregionField;
			}
			set
			{
				this.subregionField = value;
				this.RaisePropertyChanged("Subregion");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public Communication_Method_Usage_DataType Usage_Data
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

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
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
