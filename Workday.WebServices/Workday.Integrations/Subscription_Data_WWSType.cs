using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Subscription_Data_WWSType : INotifyPropertyChanged
	{
		private External_Endpoint_DataType[] endpoint_Info_DataField;

		private System_UserObjectType system_User_to_Fire_Integration_ReferenceField;

		private Integration_Background_Process_Definition_DataType[] integration_Background_Future_Process_DataField;

		private object[] itemsField;

		private ItemsChoiceType2[] itemsElementNameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Endpoint_Info_Data", Order = 0)]
		public External_Endpoint_DataType[] Endpoint_Info_Data
		{
			get
			{
				return this.endpoint_Info_DataField;
			}
			set
			{
				this.endpoint_Info_DataField = value;
				this.RaisePropertyChanged("Endpoint_Info_Data");
			}
		}

		[XmlElement(Order = 1)]
		public System_UserObjectType System_User_to_Fire_Integration_Reference
		{
			get
			{
				return this.system_User_to_Fire_Integration_ReferenceField;
			}
			set
			{
				this.system_User_to_Fire_Integration_ReferenceField = value;
				this.RaisePropertyChanged("System_User_to_Fire_Integration_Reference");
			}
		}

		[XmlElement("Integration_Background_Future_Process_Data", Order = 2)]
		public Integration_Background_Process_Definition_DataType[] Integration_Background_Future_Process_Data
		{
			get
			{
				return this.integration_Background_Future_Process_DataField;
			}
			set
			{
				this.integration_Background_Future_Process_DataField = value;
				this.RaisePropertyChanged("Integration_Background_Future_Process_Data");
			}
		}

		[XmlChoiceIdentifier("ItemsElementName"), XmlElement("Business_Process_Type_Excluded_From_Subscription_Reference", typeof(Business_Process_TypeObjectType), Order = 3), XmlElement("Specific_Transaction_Type_for_Suscription_Reference", typeof(Transaction_Log_TypeObjectType), Order = 3), XmlElement("Subscribe_to_all_Business_Processes", typeof(bool), Order = 3), XmlElement("Subscribe_to_all_Transaction_Types", typeof(bool), Order = 3), XmlElement("Transaction_Log_Type_Excluded_from_Subscription_Reference", typeof(Transaction_Log_TypeObjectType), Order = 3)]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		[XmlElement("ItemsElementName", Order = 4), XmlIgnore]
		public ItemsChoiceType2[] ItemsElementName
		{
			get
			{
				return this.itemsElementNameField;
			}
			set
			{
				this.itemsElementNameField = value;
				this.RaisePropertyChanged("ItemsElementName");
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
