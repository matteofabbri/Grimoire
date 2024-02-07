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
	public class Integration_System_Data_WWSType : INotifyPropertyChanged
	{
		private string integration_System_IDField;

		private string integration_System_NameField;

		private Integration_TemplateObjectType integration_Template_ReferenceField;

		private Integration_TagObjectType[] integration_Tag_DataField;

		private Integration_System_Contact_Data_WWSType[] integration_System_ContactField;

		private Integration_Service_Data_WWSType[] integration_Service_DataField;

		private Integration_Tool_Provider_Integration_Attribute_Values_Data_WWSType[] integration_Attributes_DataField;

		private Integration_Tool_Provider_Integration_Map_Values_Data_WWSType[] integration_Maps_DataField;

		private Integration_Attribute_DataType[] custom_Attribute_DataField;

		private Integration_Map_DataType[] custom_Map_DataField;

		private Launch_Parameter_DataType[] custom_Launch_Parameter_DataField;

		private Integration_Notification_DataType[] integration_Notification_DataField;

		private Subscription_Data_WWSType[] subscription_DataField;

		private Web_Service_Operation_Data_WWSType[] web_Service_Operation_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Integration_System_ID
		{
			get
			{
				return this.integration_System_IDField;
			}
			set
			{
				this.integration_System_IDField = value;
				this.RaisePropertyChanged("Integration_System_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Integration_System_Name
		{
			get
			{
				return this.integration_System_NameField;
			}
			set
			{
				this.integration_System_NameField = value;
				this.RaisePropertyChanged("Integration_System_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Integration_TemplateObjectType Integration_Template_Reference
		{
			get
			{
				return this.integration_Template_ReferenceField;
			}
			set
			{
				this.integration_Template_ReferenceField = value;
				this.RaisePropertyChanged("Integration_Template_Reference");
			}
		}

		[XmlArray(Order = 3), XmlArrayItem("Integration_Tag_Reference", typeof(Integration_TagObjectType), IsNullable = false)]
		public Integration_TagObjectType[] Integration_Tag_Data
		{
			get
			{
				return this.integration_Tag_DataField;
			}
			set
			{
				this.integration_Tag_DataField = value;
				this.RaisePropertyChanged("Integration_Tag_Data");
			}
		}

		[XmlElement("Integration_System_Contact", Order = 4)]
		public Integration_System_Contact_Data_WWSType[] Integration_System_Contact
		{
			get
			{
				return this.integration_System_ContactField;
			}
			set
			{
				this.integration_System_ContactField = value;
				this.RaisePropertyChanged("Integration_System_Contact");
			}
		}

		[XmlElement("Integration_Service_Data", Order = 5)]
		public Integration_Service_Data_WWSType[] Integration_Service_Data
		{
			get
			{
				return this.integration_Service_DataField;
			}
			set
			{
				this.integration_Service_DataField = value;
				this.RaisePropertyChanged("Integration_Service_Data");
			}
		}

		[XmlElement("Integration_Attributes_Data", Order = 6)]
		public Integration_Tool_Provider_Integration_Attribute_Values_Data_WWSType[] Integration_Attributes_Data
		{
			get
			{
				return this.integration_Attributes_DataField;
			}
			set
			{
				this.integration_Attributes_DataField = value;
				this.RaisePropertyChanged("Integration_Attributes_Data");
			}
		}

		[XmlElement("Integration_Maps_Data", Order = 7)]
		public Integration_Tool_Provider_Integration_Map_Values_Data_WWSType[] Integration_Maps_Data
		{
			get
			{
				return this.integration_Maps_DataField;
			}
			set
			{
				this.integration_Maps_DataField = value;
				this.RaisePropertyChanged("Integration_Maps_Data");
			}
		}

		[XmlElement("Custom_Attribute_Data", Order = 8)]
		public Integration_Attribute_DataType[] Custom_Attribute_Data
		{
			get
			{
				return this.custom_Attribute_DataField;
			}
			set
			{
				this.custom_Attribute_DataField = value;
				this.RaisePropertyChanged("Custom_Attribute_Data");
			}
		}

		[XmlElement("Custom_Map_Data", Order = 9)]
		public Integration_Map_DataType[] Custom_Map_Data
		{
			get
			{
				return this.custom_Map_DataField;
			}
			set
			{
				this.custom_Map_DataField = value;
				this.RaisePropertyChanged("Custom_Map_Data");
			}
		}

		[XmlElement("Custom_Launch_Parameter_Data", Order = 10)]
		public Launch_Parameter_DataType[] Custom_Launch_Parameter_Data
		{
			get
			{
				return this.custom_Launch_Parameter_DataField;
			}
			set
			{
				this.custom_Launch_Parameter_DataField = value;
				this.RaisePropertyChanged("Custom_Launch_Parameter_Data");
			}
		}

		[XmlElement("Integration_Notification_Data", Order = 11)]
		public Integration_Notification_DataType[] Integration_Notification_Data
		{
			get
			{
				return this.integration_Notification_DataField;
			}
			set
			{
				this.integration_Notification_DataField = value;
				this.RaisePropertyChanged("Integration_Notification_Data");
			}
		}

		[XmlElement("Subscription_Data", Order = 12)]
		public Subscription_Data_WWSType[] Subscription_Data
		{
			get
			{
				return this.subscription_DataField;
			}
			set
			{
				this.subscription_DataField = value;
				this.RaisePropertyChanged("Subscription_Data");
			}
		}

		[XmlElement("Web_Service_Operation_Data", Order = 13)]
		public Web_Service_Operation_Data_WWSType[] Web_Service_Operation_Data
		{
			get
			{
				return this.web_Service_Operation_DataField;
			}
			set
			{
				this.web_Service_Operation_DataField = value;
				this.RaisePropertyChanged("Web_Service_Operation_Data");
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
