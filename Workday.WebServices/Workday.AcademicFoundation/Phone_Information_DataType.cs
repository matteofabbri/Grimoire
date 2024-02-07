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
	public class Phone_Information_DataType : INotifyPropertyChanged
	{
		private string country_ISO_CodeField;

		private string international_Phone_CodeField;

		private string area_CodeField;

		private string phone_NumberField;

		private string phone_ExtensionField;

		private Phone_Device_TypeObjectType phone_Device_Type_ReferenceField;

		private Communication_Method_Usage_Information_DataType[] usage_DataField;

		private string formatted_PhoneField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Country_ISO_Code
		{
			get
			{
				return this.country_ISO_CodeField;
			}
			set
			{
				this.country_ISO_CodeField = value;
				this.RaisePropertyChanged("Country_ISO_Code");
			}
		}

		[XmlElement(Order = 1)]
		public string International_Phone_Code
		{
			get
			{
				return this.international_Phone_CodeField;
			}
			set
			{
				this.international_Phone_CodeField = value;
				this.RaisePropertyChanged("International_Phone_Code");
			}
		}

		[XmlElement(Order = 2)]
		public string Area_Code
		{
			get
			{
				return this.area_CodeField;
			}
			set
			{
				this.area_CodeField = value;
				this.RaisePropertyChanged("Area_Code");
			}
		}

		[XmlElement(Order = 3)]
		public string Phone_Number
		{
			get
			{
				return this.phone_NumberField;
			}
			set
			{
				this.phone_NumberField = value;
				this.RaisePropertyChanged("Phone_Number");
			}
		}

		[XmlElement(Order = 4)]
		public string Phone_Extension
		{
			get
			{
				return this.phone_ExtensionField;
			}
			set
			{
				this.phone_ExtensionField = value;
				this.RaisePropertyChanged("Phone_Extension");
			}
		}

		[XmlElement(Order = 5)]
		public Phone_Device_TypeObjectType Phone_Device_Type_Reference
		{
			get
			{
				return this.phone_Device_Type_ReferenceField;
			}
			set
			{
				this.phone_Device_Type_ReferenceField = value;
				this.RaisePropertyChanged("Phone_Device_Type_Reference");
			}
		}

		[XmlElement("Usage_Data", Order = 6)]
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

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Formatted_Phone
		{
			get
			{
				return this.formatted_PhoneField;
			}
			set
			{
				this.formatted_PhoneField = value;
				this.RaisePropertyChanged("Formatted_Phone");
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
