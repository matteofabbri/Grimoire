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
	public class HTTP_Transport_Protocol_DataType : INotifyPropertyChanged
	{
		private string hTTP_AddressField;

		private Unique_IdentifierObjectType hTTP_Delivery_Method_ReferenceField;

		private Web_Service_Invocation_TypeObjectType web_Service_Invocation_Type_ReferenceField;

		private HTTP_HeaderType[] hTTP_Header_DataField;

		private string user_IDField;

		private string passwordField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string HTTP_Address
		{
			get
			{
				return this.hTTP_AddressField;
			}
			set
			{
				this.hTTP_AddressField = value;
				this.RaisePropertyChanged("HTTP_Address");
			}
		}

		[XmlElement(Order = 1)]
		public Unique_IdentifierObjectType HTTP_Delivery_Method_Reference
		{
			get
			{
				return this.hTTP_Delivery_Method_ReferenceField;
			}
			set
			{
				this.hTTP_Delivery_Method_ReferenceField = value;
				this.RaisePropertyChanged("HTTP_Delivery_Method_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Web_Service_Invocation_TypeObjectType Web_Service_Invocation_Type_Reference
		{
			get
			{
				return this.web_Service_Invocation_Type_ReferenceField;
			}
			set
			{
				this.web_Service_Invocation_Type_ReferenceField = value;
				this.RaisePropertyChanged("Web_Service_Invocation_Type_Reference");
			}
		}

		[XmlArray(Order = 3), XmlArrayItem("HTTP_Header", IsNullable = false)]
		public HTTP_HeaderType[] HTTP_Header_Data
		{
			get
			{
				return this.hTTP_Header_DataField;
			}
			set
			{
				this.hTTP_Header_DataField = value;
				this.RaisePropertyChanged("HTTP_Header_Data");
			}
		}

		[XmlElement(Order = 4)]
		public string User_ID
		{
			get
			{
				return this.user_IDField;
			}
			set
			{
				this.user_IDField = value;
				this.RaisePropertyChanged("User_ID");
			}
		}

		[XmlElement(Order = 5)]
		public string Password
		{
			get
			{
				return this.passwordField;
			}
			set
			{
				this.passwordField = value;
				this.RaisePropertyChanged("Password");
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
