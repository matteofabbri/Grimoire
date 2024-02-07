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
	public class Person_Disability_Status_DataType : INotifyPropertyChanged
	{
		private DisabilityObjectType disability_ReferenceField;

		private DateTime disability_Status_DateField;

		private bool disability_Status_DateFieldSpecified;

		private DateTime disability_Date_KnownField;

		private bool disability_Date_KnownFieldSpecified;

		private DateTime disability_End_DateField;

		private bool disability_End_DateFieldSpecified;

		private Disability_GradeObjectType disability_Grade_ReferenceField;

		private decimal disability_DegreeField;

		private bool disability_DegreeFieldSpecified;

		private decimal disability_Remaining_CapacityField;

		private bool disability_Remaining_CapacityFieldSpecified;

		private object itemField;

		private string disability_Certified_AtField;

		private string disability_Certification_IDField;

		private Disability_Certification_BasisObjectType disability_Certification_Basis_ReferenceField;

		private DateTime disability_Severity_Recognition_DateField;

		private bool disability_Severity_Recognition_DateFieldSpecified;

		private decimal disability_FTE_Toward_QuotaField;

		private bool disability_FTE_Toward_QuotaFieldSpecified;

		private string disability_Work_RestrictionsField;

		private string disability_Accommodations_RequestedField;

		private string disability_Accommodations_ProvidedField;

		private string disability_Rehabilitation_RequestedField;

		private string disability_Rehabilitation_ProvidedField;

		private string noteField;

		private Worker_DocumentObjectType[] worker_Document_ReferenceField;

		private Disability_Status_ReferenceObjectType disability_Status_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DisabilityObjectType Disability_Reference
		{
			get
			{
				return this.disability_ReferenceField;
			}
			set
			{
				this.disability_ReferenceField = value;
				this.RaisePropertyChanged("Disability_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Disability_Status_Date
		{
			get
			{
				return this.disability_Status_DateField;
			}
			set
			{
				this.disability_Status_DateField = value;
				this.RaisePropertyChanged("Disability_Status_Date");
			}
		}

		[XmlIgnore]
		public bool Disability_Status_DateSpecified
		{
			get
			{
				return this.disability_Status_DateFieldSpecified;
			}
			set
			{
				this.disability_Status_DateFieldSpecified = value;
				this.RaisePropertyChanged("Disability_Status_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Disability_Date_Known
		{
			get
			{
				return this.disability_Date_KnownField;
			}
			set
			{
				this.disability_Date_KnownField = value;
				this.RaisePropertyChanged("Disability_Date_Known");
			}
		}

		[XmlIgnore]
		public bool Disability_Date_KnownSpecified
		{
			get
			{
				return this.disability_Date_KnownFieldSpecified;
			}
			set
			{
				this.disability_Date_KnownFieldSpecified = value;
				this.RaisePropertyChanged("Disability_Date_KnownSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Disability_End_Date
		{
			get
			{
				return this.disability_End_DateField;
			}
			set
			{
				this.disability_End_DateField = value;
				this.RaisePropertyChanged("Disability_End_Date");
			}
		}

		[XmlIgnore]
		public bool Disability_End_DateSpecified
		{
			get
			{
				return this.disability_End_DateFieldSpecified;
			}
			set
			{
				this.disability_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Disability_End_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Disability_GradeObjectType Disability_Grade_Reference
		{
			get
			{
				return this.disability_Grade_ReferenceField;
			}
			set
			{
				this.disability_Grade_ReferenceField = value;
				this.RaisePropertyChanged("Disability_Grade_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Disability_Degree
		{
			get
			{
				return this.disability_DegreeField;
			}
			set
			{
				this.disability_DegreeField = value;
				this.RaisePropertyChanged("Disability_Degree");
			}
		}

		[XmlIgnore]
		public bool Disability_DegreeSpecified
		{
			get
			{
				return this.disability_DegreeFieldSpecified;
			}
			set
			{
				this.disability_DegreeFieldSpecified = value;
				this.RaisePropertyChanged("Disability_DegreeSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Disability_Remaining_Capacity
		{
			get
			{
				return this.disability_Remaining_CapacityField;
			}
			set
			{
				this.disability_Remaining_CapacityField = value;
				this.RaisePropertyChanged("Disability_Remaining_Capacity");
			}
		}

		[XmlIgnore]
		public bool Disability_Remaining_CapacitySpecified
		{
			get
			{
				return this.disability_Remaining_CapacityFieldSpecified;
			}
			set
			{
				this.disability_Remaining_CapacityFieldSpecified = value;
				this.RaisePropertyChanged("Disability_Remaining_CapacitySpecified");
			}
		}

		[XmlElement("Disability_Certification_Authority", typeof(string), Order = 7), XmlElement("Disability_Certification_Authority_Reference", typeof(Disability_Certification_AuthorityObjectType), Order = 7)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 8)]
		public string Disability_Certified_At
		{
			get
			{
				return this.disability_Certified_AtField;
			}
			set
			{
				this.disability_Certified_AtField = value;
				this.RaisePropertyChanged("Disability_Certified_At");
			}
		}

		[XmlElement(Order = 9)]
		public string Disability_Certification_ID
		{
			get
			{
				return this.disability_Certification_IDField;
			}
			set
			{
				this.disability_Certification_IDField = value;
				this.RaisePropertyChanged("Disability_Certification_ID");
			}
		}

		[XmlElement(Order = 10)]
		public Disability_Certification_BasisObjectType Disability_Certification_Basis_Reference
		{
			get
			{
				return this.disability_Certification_Basis_ReferenceField;
			}
			set
			{
				this.disability_Certification_Basis_ReferenceField = value;
				this.RaisePropertyChanged("Disability_Certification_Basis_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 11)]
		public DateTime Disability_Severity_Recognition_Date
		{
			get
			{
				return this.disability_Severity_Recognition_DateField;
			}
			set
			{
				this.disability_Severity_Recognition_DateField = value;
				this.RaisePropertyChanged("Disability_Severity_Recognition_Date");
			}
		}

		[XmlIgnore]
		public bool Disability_Severity_Recognition_DateSpecified
		{
			get
			{
				return this.disability_Severity_Recognition_DateFieldSpecified;
			}
			set
			{
				this.disability_Severity_Recognition_DateFieldSpecified = value;
				this.RaisePropertyChanged("Disability_Severity_Recognition_DateSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public decimal Disability_FTE_Toward_Quota
		{
			get
			{
				return this.disability_FTE_Toward_QuotaField;
			}
			set
			{
				this.disability_FTE_Toward_QuotaField = value;
				this.RaisePropertyChanged("Disability_FTE_Toward_Quota");
			}
		}

		[XmlIgnore]
		public bool Disability_FTE_Toward_QuotaSpecified
		{
			get
			{
				return this.disability_FTE_Toward_QuotaFieldSpecified;
			}
			set
			{
				this.disability_FTE_Toward_QuotaFieldSpecified = value;
				this.RaisePropertyChanged("Disability_FTE_Toward_QuotaSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public string Disability_Work_Restrictions
		{
			get
			{
				return this.disability_Work_RestrictionsField;
			}
			set
			{
				this.disability_Work_RestrictionsField = value;
				this.RaisePropertyChanged("Disability_Work_Restrictions");
			}
		}

		[XmlElement(Order = 14)]
		public string Disability_Accommodations_Requested
		{
			get
			{
				return this.disability_Accommodations_RequestedField;
			}
			set
			{
				this.disability_Accommodations_RequestedField = value;
				this.RaisePropertyChanged("Disability_Accommodations_Requested");
			}
		}

		[XmlElement(Order = 15)]
		public string Disability_Accommodations_Provided
		{
			get
			{
				return this.disability_Accommodations_ProvidedField;
			}
			set
			{
				this.disability_Accommodations_ProvidedField = value;
				this.RaisePropertyChanged("Disability_Accommodations_Provided");
			}
		}

		[XmlElement(Order = 16)]
		public string Disability_Rehabilitation_Requested
		{
			get
			{
				return this.disability_Rehabilitation_RequestedField;
			}
			set
			{
				this.disability_Rehabilitation_RequestedField = value;
				this.RaisePropertyChanged("Disability_Rehabilitation_Requested");
			}
		}

		[XmlElement(Order = 17)]
		public string Disability_Rehabilitation_Provided
		{
			get
			{
				return this.disability_Rehabilitation_ProvidedField;
			}
			set
			{
				this.disability_Rehabilitation_ProvidedField = value;
				this.RaisePropertyChanged("Disability_Rehabilitation_Provided");
			}
		}

		[XmlElement(Order = 18)]
		public string Note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
				this.RaisePropertyChanged("Note");
			}
		}

		[XmlElement("Worker_Document_Reference", Order = 19)]
		public Worker_DocumentObjectType[] Worker_Document_Reference
		{
			get
			{
				return this.worker_Document_ReferenceField;
			}
			set
			{
				this.worker_Document_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Document_Reference");
			}
		}

		[XmlElement(Order = 20)]
		public Disability_Status_ReferenceObjectType Disability_Status_Reference
		{
			get
			{
				return this.disability_Status_ReferenceField;
			}
			set
			{
				this.disability_Status_ReferenceField = value;
				this.RaisePropertyChanged("Disability_Status_Reference");
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
