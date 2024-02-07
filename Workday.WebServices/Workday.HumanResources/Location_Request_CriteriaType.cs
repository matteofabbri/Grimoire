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
	public class Location_Request_CriteriaType : INotifyPropertyChanged
	{
		private string location_NameField;

		private Location_UsageObjectType[] location_Usage_ReferenceField;

		private Location_TypeObjectType[] location_Type_ReferenceField;

		private bool itemField;

		private ItemChoiceType1 itemElementNameField;

		private External_Field_and_Parameter_Initialization_ProviderObjectType[] field_And_Parameter_Criteria_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Location_Name
		{
			get
			{
				return this.location_NameField;
			}
			set
			{
				this.location_NameField = value;
				this.RaisePropertyChanged("Location_Name");
			}
		}

		[XmlElement("Location_Usage_Reference", Order = 1)]
		public Location_UsageObjectType[] Location_Usage_Reference
		{
			get
			{
				return this.location_Usage_ReferenceField;
			}
			set
			{
				this.location_Usage_ReferenceField = value;
				this.RaisePropertyChanged("Location_Usage_Reference");
			}
		}

		[XmlElement("Location_Type_Reference", Order = 2)]
		public Location_TypeObjectType[] Location_Type_Reference
		{
			get
			{
				return this.location_Type_ReferenceField;
			}
			set
			{
				this.location_Type_ReferenceField = value;
				this.RaisePropertyChanged("Location_Type_Reference");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Exclude_Active_Locations", typeof(bool), Order = 3), XmlElement("Exclude_Inactive_Locations", typeof(bool), Order = 3)]
		public bool Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 4), XmlIgnore]
		public ItemChoiceType1 ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
			}
		}

		[XmlArray(Order = 5), XmlArrayItem("Provider_Reference", typeof(External_Field_and_Parameter_Initialization_ProviderObjectType), IsNullable = false)]
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
