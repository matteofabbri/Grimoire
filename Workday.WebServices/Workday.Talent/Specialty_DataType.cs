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
	public class Specialty_DataType : INotifyPropertyChanged
	{
		private string specialty_NameField;

		private string specialty_DescriptionField;

		private string specialty_CodeField;

		private string specialty_IDField;

		private Unique_IdentifierObjectType[] specialty_Type_ReferenceField;

		private bool restrict_Specialty_UsageField;

		private bool restrict_Specialty_UsageFieldSpecified;

		private bool specialty_InactiveField;

		private bool specialty_InactiveFieldSpecified;

		private string specialty_URLField;

		private Specialty_ChildObjectType[] subspecialty_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Specialty_Name
		{
			get
			{
				return this.specialty_NameField;
			}
			set
			{
				this.specialty_NameField = value;
				this.RaisePropertyChanged("Specialty_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Specialty_Description
		{
			get
			{
				return this.specialty_DescriptionField;
			}
			set
			{
				this.specialty_DescriptionField = value;
				this.RaisePropertyChanged("Specialty_Description");
			}
		}

		[XmlElement(Order = 2)]
		public string Specialty_Code
		{
			get
			{
				return this.specialty_CodeField;
			}
			set
			{
				this.specialty_CodeField = value;
				this.RaisePropertyChanged("Specialty_Code");
			}
		}

		[XmlElement(Order = 3)]
		public string Specialty_ID
		{
			get
			{
				return this.specialty_IDField;
			}
			set
			{
				this.specialty_IDField = value;
				this.RaisePropertyChanged("Specialty_ID");
			}
		}

		[XmlElement("Specialty_Type_Reference", Order = 4)]
		public Unique_IdentifierObjectType[] Specialty_Type_Reference
		{
			get
			{
				return this.specialty_Type_ReferenceField;
			}
			set
			{
				this.specialty_Type_ReferenceField = value;
				this.RaisePropertyChanged("Specialty_Type_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public bool Restrict_Specialty_Usage
		{
			get
			{
				return this.restrict_Specialty_UsageField;
			}
			set
			{
				this.restrict_Specialty_UsageField = value;
				this.RaisePropertyChanged("Restrict_Specialty_Usage");
			}
		}

		[XmlIgnore]
		public bool Restrict_Specialty_UsageSpecified
		{
			get
			{
				return this.restrict_Specialty_UsageFieldSpecified;
			}
			set
			{
				this.restrict_Specialty_UsageFieldSpecified = value;
				this.RaisePropertyChanged("Restrict_Specialty_UsageSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Specialty_Inactive
		{
			get
			{
				return this.specialty_InactiveField;
			}
			set
			{
				this.specialty_InactiveField = value;
				this.RaisePropertyChanged("Specialty_Inactive");
			}
		}

		[XmlIgnore]
		public bool Specialty_InactiveSpecified
		{
			get
			{
				return this.specialty_InactiveFieldSpecified;
			}
			set
			{
				this.specialty_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Specialty_InactiveSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public string Specialty_URL
		{
			get
			{
				return this.specialty_URLField;
			}
			set
			{
				this.specialty_URLField = value;
				this.RaisePropertyChanged("Specialty_URL");
			}
		}

		[XmlElement("Subspecialty_Reference", Order = 8)]
		public Specialty_ChildObjectType[] Subspecialty_Reference
		{
			get
			{
				return this.subspecialty_ReferenceField;
			}
			set
			{
				this.subspecialty_ReferenceField = value;
				this.RaisePropertyChanged("Subspecialty_Reference");
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
