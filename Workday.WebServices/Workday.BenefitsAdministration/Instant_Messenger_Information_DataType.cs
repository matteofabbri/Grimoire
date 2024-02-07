using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Instant_Messenger_Information_DataType : INotifyPropertyChanged
	{
		private string instant_Messenger_AddressField;

		private Instant_Messenger_TypeObjectType instant_Messenger_Type_ReferenceField;

		private string instant_Messenger_CommentField;

		private Communication_Method_Usage_Information_DataType[] usage_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Instant_Messenger_Address
		{
			get
			{
				return this.instant_Messenger_AddressField;
			}
			set
			{
				this.instant_Messenger_AddressField = value;
				this.RaisePropertyChanged("Instant_Messenger_Address");
			}
		}

		[XmlElement(Order = 1)]
		public Instant_Messenger_TypeObjectType Instant_Messenger_Type_Reference
		{
			get
			{
				return this.instant_Messenger_Type_ReferenceField;
			}
			set
			{
				this.instant_Messenger_Type_ReferenceField = value;
				this.RaisePropertyChanged("Instant_Messenger_Type_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Instant_Messenger_Comment
		{
			get
			{
				return this.instant_Messenger_CommentField;
			}
			set
			{
				this.instant_Messenger_CommentField = value;
				this.RaisePropertyChanged("Instant_Messenger_Comment");
			}
		}

		[XmlElement("Usage_Data", Order = 3)]
		public Communication_Method_Usage_Information_DataType[] Usage_Data
		{
			get
			{
				return this.usage_DataField;
			}
			set
			{
				this.usage_DataField = value;
				this.RaisePropertyChanged("Usage_Data");
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
