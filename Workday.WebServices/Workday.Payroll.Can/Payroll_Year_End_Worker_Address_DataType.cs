using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Can
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Year_End_Worker_Address_DataType : INotifyPropertyChanged
	{
		private string address_Line_1Field;

		private string address_Line_2Field;

		private string cityField;

		private string province_CodeField;

		private string country_CodeField;

		private string postal_CodeField;

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

		[XmlElement(Order = 3)]
		public string Province_Code
		{
			get
			{
				return this.province_CodeField;
			}
			set
			{
				this.province_CodeField = value;
				this.RaisePropertyChanged("Province_Code");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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
