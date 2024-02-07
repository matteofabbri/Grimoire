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
	public class Visa_Identifier_DataType : INotifyPropertyChanged
	{
		private string visa_IDField;

		private Visa_Type_ReferenceType visa_Type_ReferenceField;

		private Country_ReferenceType country_ReferenceField;

		private DateTime issued_DateField;

		private bool issued_DateFieldSpecified;

		private DateTime expiration_DateField;

		private bool expiration_DateFieldSpecified;

		private DateTime verification_DateField;

		private bool verification_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Visa_ID
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

		[XmlElement(Order = 1)]
		public Visa_Type_ReferenceType Visa_Type_Reference
		{
			get
			{
				return this.visa_Type_ReferenceField;
			}
			set
			{
				this.visa_Type_ReferenceField = value;
				this.RaisePropertyChanged("Visa_Type_Reference");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Issued_Date
		{
			get
			{
				return this.issued_DateField;
			}
			set
			{
				this.issued_DateField = value;
				this.RaisePropertyChanged("Issued_Date");
			}
		}

		[XmlIgnore]
		public bool Issued_DateSpecified
		{
			get
			{
				return this.issued_DateFieldSpecified;
			}
			set
			{
				this.issued_DateFieldSpecified = value;
				this.RaisePropertyChanged("Issued_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Expiration_Date
		{
			get
			{
				return this.expiration_DateField;
			}
			set
			{
				this.expiration_DateField = value;
				this.RaisePropertyChanged("Expiration_Date");
			}
		}

		[XmlIgnore]
		public bool Expiration_DateSpecified
		{
			get
			{
				return this.expiration_DateFieldSpecified;
			}
			set
			{
				this.expiration_DateFieldSpecified = value;
				this.RaisePropertyChanged("Expiration_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Verification_Date
		{
			get
			{
				return this.verification_DateField;
			}
			set
			{
				this.verification_DateField = value;
				this.RaisePropertyChanged("Verification_Date");
			}
		}

		[XmlIgnore]
		public bool Verification_DateSpecified
		{
			get
			{
				return this.verification_DateFieldSpecified;
			}
			set
			{
				this.verification_DateFieldSpecified = value;
				this.RaisePropertyChanged("Verification_DateSpecified");
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
