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
	public class Funding_Source_Rule_Request_CriteriaType : INotifyPropertyChanged
	{
		private Project_and_Project_Hierarchy_AbstractObjectType[] project_ReferenceField;

		private OrganizationObjectType[] company_ReferenceField;

		private Evaluation_DateObjectType[] evaluation_Date_Option_ReferenceField;

		private Default_Funding_SourceObjectType[] default_Funding_Source_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Abstract_Funding_SourceObjectType[] funding_Source_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Project_Reference", Order = 0)]
		public Project_and_Project_Hierarchy_AbstractObjectType[] Project_Reference
		{
			get
			{
				return this.project_ReferenceField;
			}
			set
			{
				this.project_ReferenceField = value;
				this.RaisePropertyChanged("Project_Reference");
			}
		}

		[XmlElement("Company_Reference", Order = 1)]
		public OrganizationObjectType[] Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement("Evaluation_Date_Option_Reference", Order = 2)]
		public Evaluation_DateObjectType[] Evaluation_Date_Option_Reference
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

		[XmlElement("Default_Funding_Source_Reference", Order = 3)]
		public Default_Funding_SourceObjectType[] Default_Funding_Source_Reference
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

		[XmlElement(Order = 4)]
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

		[XmlElement("Funding_Source_Reference", Order = 5)]
		public Abstract_Funding_SourceObjectType[] Funding_Source_Reference
		{
			get
			{
				return this.funding_Source_ReferenceField;
			}
			set
			{
				this.funding_Source_ReferenceField = value;
				this.RaisePropertyChanged("Funding_Source_Reference");
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
