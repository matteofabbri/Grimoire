using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Certification_Achievement_DataType : INotifyPropertyChanged
	{
		private string certification_IDField;

		private bool remove_CertificationField;

		private bool remove_CertificationFieldSpecified;

		private CertificationObjectType certification_ReferenceField;

		private CountryObjectType country_ReferenceField;

		private string certification_NameField;

		private string issuerField;

		private string certification_NumberField;

		private DateTime issued_DateField;

		private bool issued_DateFieldSpecified;

		private DateTime expiration_DateField;

		private bool expiration_DateFieldSpecified;

		private string examination_ScoreField;

		private DateTime examination_DateField;

		private bool examination_DateFieldSpecified;

		private Specialty_Achievement_DataType[] specialty_Achievement_DataField;

		private Certification_Attachment_DataType[] worker_Document_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Certification_ID
		{
			get
			{
				return this.certification_IDField;
			}
			set
			{
				this.certification_IDField = value;
				this.RaisePropertyChanged("Certification_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Remove_Certification
		{
			get
			{
				return this.remove_CertificationField;
			}
			set
			{
				this.remove_CertificationField = value;
				this.RaisePropertyChanged("Remove_Certification");
			}
		}

		[XmlIgnore]
		public bool Remove_CertificationSpecified
		{
			get
			{
				return this.remove_CertificationFieldSpecified;
			}
			set
			{
				this.remove_CertificationFieldSpecified = value;
				this.RaisePropertyChanged("Remove_CertificationSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public CertificationObjectType Certification_Reference
		{
			get
			{
				return this.certification_ReferenceField;
			}
			set
			{
				this.certification_ReferenceField = value;
				this.RaisePropertyChanged("Certification_Reference");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public string Certification_Name
		{
			get
			{
				return this.certification_NameField;
			}
			set
			{
				this.certification_NameField = value;
				this.RaisePropertyChanged("Certification_Name");
			}
		}

		[XmlElement(Order = 5)]
		public string Issuer
		{
			get
			{
				return this.issuerField;
			}
			set
			{
				this.issuerField = value;
				this.RaisePropertyChanged("Issuer");
			}
		}

		[XmlElement(Order = 6)]
		public string Certification_Number
		{
			get
			{
				return this.certification_NumberField;
			}
			set
			{
				this.certification_NumberField = value;
				this.RaisePropertyChanged("Certification_Number");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
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

		[XmlElement(DataType = "date", Order = 8)]
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

		[XmlElement(Order = 9)]
		public string Examination_Score
		{
			get
			{
				return this.examination_ScoreField;
			}
			set
			{
				this.examination_ScoreField = value;
				this.RaisePropertyChanged("Examination_Score");
			}
		}

		[XmlElement(DataType = "date", Order = 10)]
		public DateTime Examination_Date
		{
			get
			{
				return this.examination_DateField;
			}
			set
			{
				this.examination_DateField = value;
				this.RaisePropertyChanged("Examination_Date");
			}
		}

		[XmlIgnore]
		public bool Examination_DateSpecified
		{
			get
			{
				return this.examination_DateFieldSpecified;
			}
			set
			{
				this.examination_DateFieldSpecified = value;
				this.RaisePropertyChanged("Examination_DateSpecified");
			}
		}

		[XmlElement("Specialty_Achievement_Data", Order = 11)]
		public Specialty_Achievement_DataType[] Specialty_Achievement_Data
		{
			get
			{
				return this.specialty_Achievement_DataField;
			}
			set
			{
				this.specialty_Achievement_DataField = value;
				this.RaisePropertyChanged("Specialty_Achievement_Data");
			}
		}

		[XmlElement("Worker_Document_Data", Order = 12)]
		public Certification_Attachment_DataType[] Worker_Document_Data
		{
			get
			{
				return this.worker_Document_DataField;
			}
			set
			{
				this.worker_Document_DataField = value;
				this.RaisePropertyChanged("Worker_Document_Data");
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
