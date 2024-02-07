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
	public class Subscription_DataType : INotifyPropertyChanged
	{
		private SubscriberObjectType subscriber_ReferenceField;

		private External_Endpoint_DataType[] endpoint_Info_DataField;

		private System_UserObjectType run_As_User_ReferenceField;

		private Integration_Background_Process_Definition_DataType integration_Background_Future_Process_DataField;

		private object[] itemsField;

		private ItemsChoiceType4[] itemsElementNameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public SubscriberObjectType Subscriber_Reference
		{
			get
			{
				return this.subscriber_ReferenceField;
			}
			set
			{
				this.subscriber_ReferenceField = value;
				this.RaisePropertyChanged("Subscriber_Reference");
			}
		}

		[XmlElement("Endpoint_Info_Data", Order = 1)]
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

		[XmlElement(Order = 2)]
		public System_UserObjectType Run_As_User_Reference
		{
			get
			{
				return this.run_As_User_ReferenceField;
			}
			set
			{
				this.run_As_User_ReferenceField = value;
				this.RaisePropertyChanged("Run_As_User_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Integration_Background_Process_Definition_DataType Integration_Background_Future_Process_Data
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

		[XmlChoiceIdentifier("ItemsElementName"), XmlElement("Excluded_Business_Process_Type_Reference", typeof(Business_Process_TypeObjectType), Order = 4), XmlElement("Excluded_Transaction_Log_Type_Reference", typeof(Transaction_Log_TypeObjectType), Order = 4), XmlElement("Included_Transaction_Log_Type_Reference", typeof(Transaction_Log_TypeObjectType), Order = 4), XmlElement("Subscribe_to_all_Business_Processes", typeof(bool), Order = 4), XmlElement("Subscribe_to_all_Transaction_Types", typeof(bool), Order = 4)]
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

		[XmlElement("ItemsElementName", Order = 5), XmlIgnore]
		public ItemsChoiceType4[] ItemsElementName
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
