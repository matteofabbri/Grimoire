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
	public class Specialty_Request_CriteriaType : INotifyPropertyChanged
	{
		private string specialty_NameField;

		private string specialty_CodeField;

		private Unique_IdentifierObjectType specialty_Type_ReferenceField;

		private bool specialty_InactiveField;

		private bool specialty_InactiveFieldSpecified;

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

		[XmlElement(Order = 2)]
		public Unique_IdentifierObjectType Specialty_Type_Reference
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

		[XmlElement(Order = 3)]
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
