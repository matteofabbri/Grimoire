using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Beneficiary_Personal_Information_DataType : INotifyPropertyChanged
	{
		private Person_Name_DataType person_Name_DataField;

		private Contact_Information_DataType contact_Information_DataField;

		private Person_Identification_DataType person_Identification_DataField;

		private DateTime date_of_BirthField;

		private bool date_of_BirthFieldSpecified;

		private DateTime date_of_DeathField;

		private bool date_of_DeathFieldSpecified;

		private GenderObjectType gender_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Person_Name_DataType Person_Name_Data
		{
			get
			{
				return this.person_Name_DataField;
			}
			set
			{
				this.person_Name_DataField = value;
				this.RaisePropertyChanged("Person_Name_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Contact_Information_DataType Contact_Information_Data
		{
			get
			{
				return this.contact_Information_DataField;
			}
			set
			{
				this.contact_Information_DataField = value;
				this.RaisePropertyChanged("Contact_Information_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Person_Identification_DataType Person_Identification_Data
		{
			get
			{
				return this.person_Identification_DataField;
			}
			set
			{
				this.person_Identification_DataField = value;
				this.RaisePropertyChanged("Person_Identification_Data");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Date_of_Birth
		{
			get
			{
				return this.date_of_BirthField;
			}
			set
			{
				this.date_of_BirthField = value;
				this.RaisePropertyChanged("Date_of_Birth");
			}
		}

		[XmlIgnore]
		public bool Date_of_BirthSpecified
		{
			get
			{
				return this.date_of_BirthFieldSpecified;
			}
			set
			{
				this.date_of_BirthFieldSpecified = value;
				this.RaisePropertyChanged("Date_of_BirthSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Date_of_Death
		{
			get
			{
				return this.date_of_DeathField;
			}
			set
			{
				this.date_of_DeathField = value;
				this.RaisePropertyChanged("Date_of_Death");
			}
		}

		[XmlIgnore]
		public bool Date_of_DeathSpecified
		{
			get
			{
				return this.date_of_DeathFieldSpecified;
			}
			set
			{
				this.date_of_DeathFieldSpecified = value;
				this.RaisePropertyChanged("Date_of_DeathSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public GenderObjectType Gender_Reference
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
