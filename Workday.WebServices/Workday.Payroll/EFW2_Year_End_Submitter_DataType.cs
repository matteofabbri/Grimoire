using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class EFW2_Year_End_Submitter_DataType : INotifyPropertyChanged
	{
		private string eINField;

		private string company_NameField;

		private string address_Line_1Field;

		private string address_Line_2Field;

		private string cityField;

		private string stateField;

		private string postal_CodeField;

		private string contact_NameField;

		private string contact_Phone_NumberField;

		private string contact_Email_AddressField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string EIN
		{
			get
			{
				return this.eINField;
			}
			set
			{
				this.eINField = value;
				this.RaisePropertyChanged("EIN");
			}
		}

		[XmlElement(Order = 1)]
		public string Company_Name
		{
			get
			{
				return this.company_NameField;
			}
			set
			{
				this.company_NameField = value;
				this.RaisePropertyChanged("Company_Name");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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
		public string Contact_Name
		{
			get
			{
				return this.contact_NameField;
			}
			set
			{
				this.contact_NameField = value;
				this.RaisePropertyChanged("Contact_Name");
			}
		}

		[XmlElement(Order = 8)]
		public string Contact_Phone_Number
		{
			get
			{
				return this.contact_Phone_NumberField;
			}
			set
			{
				this.contact_Phone_NumberField = value;
				this.RaisePropertyChanged("Contact_Phone_Number");
			}
		}

		[XmlElement(Order = 9)]
		public string Contact_Email_Address
		{
			get
			{
				return this.contact_Email_AddressField;
			}
			set
			{
				this.contact_Email_AddressField = value;
				this.RaisePropertyChanged("Contact_Email_Address");
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
