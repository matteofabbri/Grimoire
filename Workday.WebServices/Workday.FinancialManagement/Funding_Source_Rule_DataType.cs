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
	public class Funding_Source_Rule_DataType : INotifyPropertyChanged
	{
		private string funding_Source_Rule_IDField;

		private Project_and_Project_Hierarchy_AbstractObjectType xMLNAME__Projects__or__Project__Hierarchy_ReferenceField;

		private OrganizationObjectType company_or_Company_Hierarchy_ReferenceField;

		private string descriptionField;

		private Evaluation_DateObjectType evaluation_Date_Option_ReferenceField;

		private Default_Funding_SourceObjectType default_Funding_Source_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Funding_Source_Priority_DataType[] funding_Source_Priority_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Funding_Source_Rule_ID
		{
			get
			{
				return this.funding_Source_Rule_IDField;
			}
			set
			{
				this.funding_Source_Rule_IDField = value;
				this.RaisePropertyChanged("Funding_Source_Rule_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Project_and_Project_Hierarchy_AbstractObjectType XMLNAME__Projects__or__Project__Hierarchy_Reference
		{
			get
			{
				return this.xMLNAME__Projects__or__Project__Hierarchy_ReferenceField;
			}
			set
			{
				this.xMLNAME__Projects__or__Project__Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("XMLNAME__Projects__or__Project__Hierarchy_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public OrganizationObjectType Company_or_Company_Hierarchy_Reference
		{
			get
			{
				return this.company_or_Company_Hierarchy_ReferenceField;
			}
			set
			{
				this.company_or_Company_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Company_or_Company_Hierarchy_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 4)]
		public Evaluation_DateObjectType Evaluation_Date_Option_Reference
		{
			get
			{
				return this.evaluation_Date_Option_ReferenceField;
			}
			set
			{
				this.evaluation_Date_Option_ReferenceField = value;
				this.RaisePropertyChanged("Evaluation_Date_Option_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Default_Funding_SourceObjectType Default_Funding_Source_Reference
		{
			get
			{
				return this.default_Funding_Source_ReferenceField;
			}
			set
			{
				this.default_Funding_Source_ReferenceField = value;
				this.RaisePropertyChanged("Default_Funding_Source_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement("Funding_Source_Priority_Data", Order = 7)]
		public Funding_Source_Priority_DataType[] Funding_Source_Priority_Data
		{
			get
			{
				return this.funding_Source_Priority_DataField;
			}
			set
			{
				this.funding_Source_Priority_DataField = value;
				this.RaisePropertyChanged("Funding_Source_Priority_Data");
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
