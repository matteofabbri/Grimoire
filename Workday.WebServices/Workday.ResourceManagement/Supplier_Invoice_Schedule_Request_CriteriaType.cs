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
	public class Supplier_Invoice_Schedule_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] company_ReferenceField;

		private Resource_ProviderObjectType[] supplier_ReferenceField;

		private Supplier_ContractObjectType[] supplier_Contract_ReferenceField;

		private Document_StatusObjectType[] schedule_Status_ReferenceField;

		private Frequency_BehaviorObjectType[] frequency_Behavior_ReferenceField;

		private Schedule_Distribution_MethodObjectType[] schedule_Distribution_Method_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Company_Reference", Order = 0)]
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

		[XmlElement("Supplier_Reference", Order = 1)]
		public Resource_ProviderObjectType[] Supplier_Reference
		{
			get
			{
				return this.supplier_ReferenceField;
			}
			set
			{
				this.supplier_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Reference");
			}
		}

		[XmlElement("Supplier_Contract_Reference", Order = 2)]
		public Supplier_ContractObjectType[] Supplier_Contract_Reference
		{
			get
			{
				return this.supplier_Contract_ReferenceField;
			}
			set
			{
				this.supplier_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Contract_Reference");
			}
		}

		[XmlElement("Schedule_Status_Reference", Order = 3)]
		public Document_StatusObjectType[] Schedule_Status_Reference
		{
			get
			{
				return this.schedule_Status_ReferenceField;
			}
			set
			{
				this.schedule_Status_ReferenceField = value;
				this.RaisePropertyChanged("Schedule_Status_Reference");
			}
		}

		[XmlElement("Frequency_Behavior_Reference", Order = 4)]
		public Frequency_BehaviorObjectType[] Frequency_Behavior_Reference
		{
			get
			{
				return this.frequency_Behavior_ReferenceField;
			}
			set
			{
				this.frequency_Behavior_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Behavior_Reference");
			}
		}

		[XmlElement("Schedule_Distribution_Method_Reference", Order = 5)]
		public Schedule_Distribution_MethodObjectType[] Schedule_Distribution_Method_Reference
		{
			get
			{
				return this.schedule_Distribution_Method_ReferenceField;
			}
			set
			{
				this.schedule_Distribution_Method_ReferenceField = value;
				this.RaisePropertyChanged("Schedule_Distribution_Method_Reference");
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
