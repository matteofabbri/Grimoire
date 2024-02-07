using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Internal_Service_Provider_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] company_or_Company_Hierarchy_ReferenceField;

		private string internal_Service_Provider_NameField;

		private string internal_Service_Provider_IDField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private CurrencyObjectType[] currency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Company_or_Company_Hierarchy_Reference", Order = 0)]
		public OrganizationObjectType[] Company_or_Company_Hierarchy_Reference
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

		[XmlElement(Order = 1)]
		public string Internal_Service_Provider_Name
		{
			get
			{
				return this.internal_Service_Provider_NameField;
			}
			set
			{
				this.internal_Service_Provider_NameField = value;
				this.RaisePropertyChanged("Internal_Service_Provider_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Internal_Service_Provider_ID
		{
			get
			{
				return this.internal_Service_Provider_IDField;
			}
			set
			{
				this.internal_Service_Provider_IDField = value;
				this.RaisePropertyChanged("Internal_Service_Provider_ID");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement("Currency_Reference", Order = 4)]
		public CurrencyObjectType[] Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
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
