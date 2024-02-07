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
	public class Person_Identification_DataType : INotifyPropertyChanged
	{
		private National_IDType[] national_IDField;

		private Government_IDType[] government_IDField;

		private Visa_IDType[] visa_IDField;

		private Passport_IDType[] passport_IDField;

		private License_IDType[] license_IDField;

		private Custom_IDType[] custom_IDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("National_ID", Order = 0)]
		public National_IDType[] National_ID
		{
			get
			{
				return this.national_IDField;
			}
			set
			{
				this.national_IDField = value;
				this.RaisePropertyChanged("National_ID");
			}
		}

		[XmlElement("Government_ID", Order = 1)]
		public Government_IDType[] Government_ID
		{
			get
			{
				return this.government_IDField;
			}
			set
			{
				this.government_IDField = value;
				this.RaisePropertyChanged("Government_ID");
			}
		}

		[XmlElement("Visa_ID", Order = 2)]
		public Visa_IDType[] Visa_ID
		{
			get
			{
				return this.visa_IDField;
			}
			set
			{
				this.visa_IDField = value;
				this.RaisePropertyChanged("Visa_ID");
			}
		}

		[XmlElement("Passport_ID", Order = 3)]
		public Passport_IDType[] Passport_ID
		{
			get
			{
				return this.passport_IDField;
			}
			set
			{
				this.passport_IDField = value;
				this.RaisePropertyChanged("Passport_ID");
			}
		}

		[XmlElement("License_ID", Order = 4)]
		public License_IDType[] License_ID
		{
			get
			{
				return this.license_IDField;
			}
			set
			{
				this.license_IDField = value;
				this.RaisePropertyChanged("License_ID");
			}
		}

		[XmlElement("Custom_ID", Order = 5)]
		public Custom_IDType[] Custom_ID
		{
			get
			{
				return this.custom_IDField;
			}
			set
			{
				this.custom_IDField = value;
				this.RaisePropertyChanged("Custom_ID");
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
