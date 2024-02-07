using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Biographic_DataType : INotifyPropertyChanged
	{
		private Country_Of_Birth_ReferenceType country_Of_Birth_ReferenceField;

		private string place_Of_BirthField;

		private DateTime date_Of_BirthField;

		private bool date_Of_BirthFieldSpecified;

		private Gender_ReferenceType gender_ReferenceField;

		private Disability_ReferenceType[] disability_ReferenceField;

		private bool uses_TobaccoField;

		private bool uses_TobaccoFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Country_Of_Birth_ReferenceType Country_Of_Birth_Reference
		{
			get
			{
				return this.country_Of_Birth_ReferenceField;
			}
			set
			{
				this.country_Of_Birth_ReferenceField = value;
				this.RaisePropertyChanged("Country_Of_Birth_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Place_Of_Birth
		{
			get
			{
				return this.place_Of_BirthField;
			}
			set
			{
				this.place_Of_BirthField = value;
				this.RaisePropertyChanged("Place_Of_Birth");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Date_Of_Birth
		{
			get
			{
				return this.date_Of_BirthField;
			}
			set
			{
				this.date_Of_BirthField = value;
				this.RaisePropertyChanged("Date_Of_Birth");
			}
		}

		[XmlIgnore]
		public bool Date_Of_BirthSpecified
		{
			get
			{
				return this.date_Of_BirthFieldSpecified;
			}
			set
			{
				this.date_Of_BirthFieldSpecified = value;
				this.RaisePropertyChanged("Date_Of_BirthSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Gender_ReferenceType Gender_Reference
		{
			get
			{
				return this.gender_ReferenceField;
			}
			set
			{
				this.gender_ReferenceField = value;
				this.RaisePropertyChanged("Gender_Reference");
			}
		}

		[XmlElement("Disability_Reference", Order = 4)]
		public Disability_ReferenceType[] Disability_Reference
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

		[XmlElement(Order = 5)]
		public bool Uses_Tobacco
		{
			get
			{
				return this.uses_TobaccoField;
			}
			set
			{
				this.uses_TobaccoField = value;
				this.RaisePropertyChanged("Uses_Tobacco");
			}
		}

		[XmlIgnore]
		public bool Uses_TobaccoSpecified
		{
			get
			{
				return this.uses_TobaccoFieldSpecified;
			}
			set
			{
				this.uses_TobaccoFieldSpecified = value;
				this.RaisePropertyChanged("Uses_TobaccoSpecified");
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
