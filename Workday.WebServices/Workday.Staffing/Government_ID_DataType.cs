using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Government_ID_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Government_ID_Type__All_ObjectType iD_Type_ReferenceField;

		private CountryObjectType country_ReferenceField;

		private DateTime issued_DateField;

		private bool issued_DateFieldSpecified;

		private DateTime expiration_DateField;

		private bool expiration_DateFieldSpecified;

		private DateTime verification_DateField;

		private bool verification_DateFieldSpecified;

		private WorkerObjectType verified_by_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public Government_ID_Type__All_ObjectType ID_Type_Reference
		{
			get
			{
				return this.iD_Type_ReferenceField;
			}
			set
			{
				this.iD_Type_ReferenceField = value;
				this.RaisePropertyChanged("ID_Type_Reference");
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

		[XmlElement(Order = 6)]
		public WorkerObjectType Verified_by_Reference
		{
			get
			{
				return this.verified_by_ReferenceField;
			}
			set
			{
				this.verified_by_ReferenceField = value;
				this.RaisePropertyChanged("Verified_by_Reference");
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
