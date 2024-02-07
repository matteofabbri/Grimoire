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
	public class Former_Worker_Personal_Information_DataType : INotifyPropertyChanged
	{
		private Person_Name_DataType name_DataField;

		private DateTime birth_DateField;

		private bool birth_DateFieldSpecified;

		private EthnicityObjectType[] ethnicity_ReferenceField;

		private bool hispanic_or_LatinoField;

		private bool hispanic_or_LatinoFieldSpecified;

		private Contact_Information_DataType contact_Information_DataField;

		private National_IDType[] national_Identifier_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Person_Name_DataType Name_Data
		{
			get
			{
				return this.name_DataField;
			}
			set
			{
				this.name_DataField = value;
				this.RaisePropertyChanged("Name_Data");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Birth_Date
		{
			get
			{
				return this.birth_DateField;
			}
			set
			{
				this.birth_DateField = value;
				this.RaisePropertyChanged("Birth_Date");
			}
		}

		[XmlIgnore]
		public bool Birth_DateSpecified
		{
			get
			{
				return this.birth_DateFieldSpecified;
			}
			set
			{
				this.birth_DateFieldSpecified = value;
				this.RaisePropertyChanged("Birth_DateSpecified");
			}
		}

		[XmlElement("Ethnicity_Reference", Order = 2)]
		public EthnicityObjectType[] Ethnicity_Reference
		{
			get
			{
				return this.ethnicity_ReferenceField;
			}
			set
			{
				this.ethnicity_ReferenceField = value;
				this.RaisePropertyChanged("Ethnicity_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool Hispanic_or_Latino
		{
			get
			{
				return this.hispanic_or_LatinoField;
			}
			set
			{
				this.hispanic_or_LatinoField = value;
				this.RaisePropertyChanged("Hispanic_or_Latino");
			}
		}

		[XmlIgnore]
		public bool Hispanic_or_LatinoSpecified
		{
			get
			{
				return this.hispanic_or_LatinoFieldSpecified;
			}
			set
			{
				this.hispanic_or_LatinoFieldSpecified = value;
				this.RaisePropertyChanged("Hispanic_or_LatinoSpecified");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement("National_Identifier_Data", Order = 5)]
		public National_IDType[] National_Identifier_Data
		{
			get
			{
				return this.national_Identifier_DataField;
			}
			set
			{
				this.national_Identifier_DataField = value;
				this.RaisePropertyChanged("National_Identifier_Data");
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
