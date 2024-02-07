using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Application_Personal_Information_DataType : INotifyPropertyChanged
	{
		private GenderObjectType gender_ReferenceField;

		private EthnicityObjectType[] ethnicity_ReferenceField;

		private Armed_Forces_StatusObjectType[] veterans_Status_ReferenceField;

		private bool hispanic_or_LatinoField;

		private bool hispanic_or_LatinoFieldSpecified;

		private SelfIdentification_of_Disability_StatusObjectType disability_Status_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement("Ethnicity_Reference", Order = 1)]
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

		[XmlElement("Veterans_Status_Reference", Order = 2)]
		public Armed_Forces_StatusObjectType[] Veterans_Status_Reference
		{
			get
			{
				return this.veterans_Status_ReferenceField;
			}
			set
			{
				this.veterans_Status_ReferenceField = value;
				this.RaisePropertyChanged("Veterans_Status_Reference");
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
		public SelfIdentification_of_Disability_StatusObjectType Disability_Status_Reference
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
