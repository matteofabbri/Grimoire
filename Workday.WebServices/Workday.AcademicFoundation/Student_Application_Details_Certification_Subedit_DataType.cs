using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Application_Details_Certification_Subedit_DataType : INotifyPropertyChanged
	{
		private Recruitable_CertificationObjectType recruitable_Certification_ReferenceField;

		private CertificationObjectType certification_ReferenceField;

		private string certification_NumberField;

		private DateTime issued_DateField;

		private bool issued_DateFieldSpecified;

		private DateTime expiration_DateField;

		private bool expiration_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Recruitable_CertificationObjectType Recruitable_Certification_Reference
		{
			get
			{
				return this.recruitable_Certification_ReferenceField;
			}
			set
			{
				this.recruitable_Certification_ReferenceField = value;
				this.RaisePropertyChanged("Recruitable_Certification_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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
