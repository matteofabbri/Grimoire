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
	public class External_Endpoint_DataType : INotifyPropertyChanged
	{
		private Web_Service_API_VersionObjectType web_Service_API_Version_ReferenceField;

		private object itemField;

		private string subscription_User_NameField;

		private string subscription_PasswordField;

		private bool disable_EndpointField;

		private bool disable_EndpointFieldSpecified;

		private OMS_EnvironmentObjectType[] oMS_Environment_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Web_Service_API_VersionObjectType Web_Service_API_Version_Reference
		{
			get
			{
				return this.web_Service_API_Version_ReferenceField;
			}
			set
			{
				this.web_Service_API_Version_ReferenceField = value;
				this.RaisePropertyChanged("Web_Service_API_Version_Reference");
			}
		}

		[XmlElement("Subscriber_URL", typeof(string), Order = 1), XmlElement("Use_Deployed_Service_Endpoint", typeof(bool), Order = 1)]
		public object Item
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

		[XmlElement(Order = 2)]
		public string Subscription_User_Name
		{
			get
			{
				return this.subscription_User_NameField;
			}
			set
			{
				this.subscription_User_NameField = value;
				this.RaisePropertyChanged("Subscription_User_Name");
			}
		}

		[XmlElement(Order = 3)]
		public string Subscription_Password
		{
			get
			{
				return this.subscription_PasswordField;
			}
			set
			{
				this.subscription_PasswordField = value;
				this.RaisePropertyChanged("Subscription_Password");
			}
		}

		[XmlElement(Order = 4)]
		public bool Disable_Endpoint
		{
			get
			{
				return this.disable_EndpointField;
			}
			set
			{
				this.disable_EndpointField = value;
				this.RaisePropertyChanged("Disable_Endpoint");
			}
		}

		[XmlIgnore]
		public bool Disable_EndpointSpecified
		{
			get
			{
				return this.disable_EndpointFieldSpecified;
			}
			set
			{
				this.disable_EndpointFieldSpecified = value;
				this.RaisePropertyChanged("Disable_EndpointSpecified");
			}
		}

		[XmlElement("OMS_Environment_Reference", Order = 5)]
		public OMS_EnvironmentObjectType[] OMS_Environment_Reference
		{
			get
			{
				return this.oMS_Environment_ReferenceField;
			}
			set
			{
				this.oMS_Environment_ReferenceField = value;
				this.RaisePropertyChanged("OMS_Environment_Reference");
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
