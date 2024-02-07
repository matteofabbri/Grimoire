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
	public class Person_Name_Suffix_DataType : INotifyPropertyChanged
	{
		private Country_Predefined_Person_Name_Component_ValueObjectType social_Suffix_ReferenceField;

		private string social_Suffix_DescriptorField;

		private Country_Predefined_Person_Name_Component_ValueObjectType academic_Suffix_ReferenceField;

		private Country_Predefined_Person_Name_Component_ValueObjectType hereditary_Suffix_ReferenceField;

		private Country_Predefined_Person_Name_Component_ValueObjectType honorary_Suffix_ReferenceField;

		private Country_Predefined_Person_Name_Component_ValueObjectType professional_Suffix_ReferenceField;

		private Country_Predefined_Person_Name_Component_ValueObjectType religious_Suffix_ReferenceField;

		private Country_Predefined_Person_Name_Component_ValueObjectType royal_Suffix_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Country_Predefined_Person_Name_Component_ValueObjectType Social_Suffix_Reference
		{
			get
			{
				return this.social_Suffix_ReferenceField;
			}
			set
			{
				this.social_Suffix_ReferenceField = value;
				this.RaisePropertyChanged("Social_Suffix_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Social_Suffix_Descriptor
		{
			get
			{
				return this.social_Suffix_DescriptorField;
			}
			set
			{
				this.social_Suffix_DescriptorField = value;
				this.RaisePropertyChanged("Social_Suffix_Descriptor");
			}
		}

		[XmlElement(Order = 2)]
		public Country_Predefined_Person_Name_Component_ValueObjectType Academic_Suffix_Reference
		{
			get
			{
				return this.academic_Suffix_ReferenceField;
			}
			set
			{
				this.academic_Suffix_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Suffix_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Country_Predefined_Person_Name_Component_ValueObjectType Hereditary_Suffix_Reference
		{
			get
			{
				return this.hereditary_Suffix_ReferenceField;
			}
			set
			{
				this.hereditary_Suffix_ReferenceField = value;
				this.RaisePropertyChanged("Hereditary_Suffix_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Country_Predefined_Person_Name_Component_ValueObjectType Honorary_Suffix_Reference
		{
			get
			{
				return this.honorary_Suffix_ReferenceField;
			}
			set
			{
				this.honorary_Suffix_ReferenceField = value;
				this.RaisePropertyChanged("Honorary_Suffix_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Country_Predefined_Person_Name_Component_ValueObjectType Professional_Suffix_Reference
		{
			get
			{
				return this.professional_Suffix_ReferenceField;
			}
			set
			{
				this.professional_Suffix_ReferenceField = value;
				this.RaisePropertyChanged("Professional_Suffix_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Country_Predefined_Person_Name_Component_ValueObjectType Religious_Suffix_Reference
		{
			get
			{
				return this.religious_Suffix_ReferenceField;
			}
			set
			{
				this.religious_Suffix_ReferenceField = value;
				this.RaisePropertyChanged("Religious_Suffix_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Country_Predefined_Person_Name_Component_ValueObjectType Royal_Suffix_Reference
		{
			get
			{
				return this.royal_Suffix_ReferenceField;
			}
			set
			{
				this.royal_Suffix_ReferenceField = value;
				this.RaisePropertyChanged("Royal_Suffix_Reference");
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
