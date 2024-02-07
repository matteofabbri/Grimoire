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
	public class Bill_To_Address_for_Issue_Purchase_Order_Outbound_Sub_ViewType : INotifyPropertyChanged
	{
		private string address_IDField;

		private Address_ReferenceType[] address_ReferenceField;

		private string streetField;

		private string cityField;

		private string stateField;

		private string zip_CodeField;

		private string countryField;

		private string country_CodeField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement("Address_Reference", Order = 1)]
		public Address_ReferenceType[] Address_Reference
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

		[XmlElement(Order = 2)]
		public string Street
		{
			get
			{
				return this.streetField;
			}
			set
			{
				this.streetField = value;
				this.RaisePropertyChanged("Street");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public string State
		{
			get
			{
				return this.stateField;
			}
			set
			{
				this.stateField = value;
				this.RaisePropertyChanged("State");
			}
		}

		[XmlElement(Order = 5)]
		public string Zip_Code
		{
			get
			{
				return this.zip_CodeField;
			}
			set
			{
				this.zip_CodeField = value;
				this.RaisePropertyChanged("Zip_Code");
			}
		}

		[XmlElement(Order = 6)]
		public string Country
		{
			get
			{
				return this.countryField;
			}
			set
			{
				this.countryField = value;
				this.RaisePropertyChanged("Country");
			}
		}

		[XmlElement(Order = 7)]
		public string Country_Code
		{
			get
			{
				return this.country_CodeField;
			}
			set
			{
				this.country_CodeField = value;
				this.RaisePropertyChanged("Country_Code");
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
