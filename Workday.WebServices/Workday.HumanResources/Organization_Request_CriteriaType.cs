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
	public class Organization_Request_CriteriaType : INotifyPropertyChanged
	{
		private Organization_TypeObjectType[] organization_Type_ReferenceField;

		private bool include_InactiveField;

		private bool include_InactiveFieldSpecified;

		private Transaction_Log_CriteriaType[] transaction_Log_CriteriaField;

		private External_Field_and_Parameter_Initialization_ProviderObjectType[] field_And_Parameter_Criteria_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Organization_Type_Reference", Order = 0)]
		public Organization_TypeObjectType[] Organization_Type_Reference
		{
			get
			{
				return this.organization_Type_ReferenceField;
			}
			set
			{
				this.organization_Type_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_Inactive
		{
			get
			{
				return this.include_InactiveField;
			}
			set
			{
				this.include_InactiveField = value;
				this.RaisePropertyChanged("Include_Inactive");
			}
		}

		[XmlIgnore]
		public bool Include_InactiveSpecified
		{
			get
			{
				return this.include_InactiveFieldSpecified;
			}
			set
			{
				this.include_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Include_InactiveSpecified");
			}
		}

		[XmlElement("Transaction_Log_Criteria", Order = 2)]
		public Transaction_Log_CriteriaType[] Transaction_Log_Criteria
		{
			get
			{
				return this.transaction_Log_CriteriaField;
			}
			set
			{
				this.transaction_Log_CriteriaField = value;
				this.RaisePropertyChanged("Transaction_Log_Criteria");
			}
		}

		[XmlArray(Order = 3), XmlArrayItem("Provider_Reference", IsNullable = false)]
		public External_Field_and_Parameter_Initialization_ProviderObjectType[] Field_And_Parameter_Criteria_Data
		{
			get
			{
				return this.field_And_Parameter_Criteria_DataField;
			}
			set
			{
				this.field_And_Parameter_Criteria_DataField = value;
				this.RaisePropertyChanged("Field_And_Parameter_Criteria_Data");
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
