using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Related_PersonType : INotifyPropertyChanged
	{
		private Related_Person_RelationshipObjectType[] related_Person_Relationship_ReferenceField;

		private Unique_IdentifierObjectType person_ReferenceField;

		private Personal_Information_DataType personal_DataField;

		private DependentType dependentField;

		private BeneficiaryType beneficiaryField;

		private Old_Emergency_ContactType emergency_ContactField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Related_Person_Relationship_Reference", Order = 0)]
		public Related_Person_RelationshipObjectType[] Related_Person_Relationship_Reference
		{
			get
			{
				return this.related_Person_Relationship_ReferenceField;
			}
			set
			{
				this.related_Person_Relationship_ReferenceField = value;
				this.RaisePropertyChanged("Related_Person_Relationship_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Unique_IdentifierObjectType Person_Reference
		{
			get
			{
				return this.person_ReferenceField;
			}
			set
			{
				this.person_ReferenceField = value;
				this.RaisePropertyChanged("Person_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Personal_Information_DataType Personal_Data
		{
			get
			{
				return this.personal_DataField;
			}
			set
			{
				this.personal_DataField = value;
				this.RaisePropertyChanged("Personal_Data");
			}
		}

		[XmlElement(Order = 3)]
		public DependentType Dependent
		{
			get
			{
				return this.dependentField;
			}
			set
			{
				this.dependentField = value;
				this.RaisePropertyChanged("Dependent");
			}
		}

		[XmlElement(Order = 4)]
		public BeneficiaryType Beneficiary
		{
			get
			{
				return this.beneficiaryField;
			}
			set
			{
				this.beneficiaryField = value;
				this.RaisePropertyChanged("Beneficiary");
			}
		}

		[XmlElement(Order = 5)]
		public Old_Emergency_ContactType Emergency_Contact
		{
			get
			{
				return this.emergency_ContactField;
			}
			set
			{
				this.emergency_ContactField = value;
				this.RaisePropertyChanged("Emergency_Contact");
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
