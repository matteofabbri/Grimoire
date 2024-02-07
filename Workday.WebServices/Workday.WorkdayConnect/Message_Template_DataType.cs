using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.WorkdayConnect
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Message_Template_DataType : INotifyPropertyChanged
	{
		private string message_Template_IDField;

		private string message_Template_NameField;

		private Notification_CategoryObjectType notification_Type_ReferenceField;

		private Email_Notification_Configuration_Replacement_DataType[] email_Notification_Configuration_Replacement_DataField;

		private Push_Notification_Configuration_Replacement_DataType[] push_Notification_Configuration_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Message_Template_ID
		{
			get
			{
				return this.message_Template_IDField;
			}
			set
			{
				this.message_Template_IDField = value;
				this.RaisePropertyChanged("Message_Template_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Message_Template_Name
		{
			get
			{
				return this.message_Template_NameField;
			}
			set
			{
				this.message_Template_NameField = value;
				this.RaisePropertyChanged("Message_Template_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Notification_CategoryObjectType Notification_Type_Reference
		{
			get
			{
				return this.notification_Type_ReferenceField;
			}
			set
			{
				this.notification_Type_ReferenceField = value;
				this.RaisePropertyChanged("Notification_Type_Reference");
			}
		}

		[XmlElement("Email_Notification_Configuration_Replacement_Data", Order = 3)]
		public Email_Notification_Configuration_Replacement_DataType[] Email_Notification_Configuration_Replacement_Data
		{
			get
			{
				return this.email_Notification_Configuration_Replacement_DataField;
			}
			set
			{
				this.email_Notification_Configuration_Replacement_DataField = value;
				this.RaisePropertyChanged("Email_Notification_Configuration_Replacement_Data");
			}
		}

		[XmlElement("Push_Notification_Configuration_Replacement_Data", Order = 4)]
		public Push_Notification_Configuration_Replacement_DataType[] Push_Notification_Configuration_Replacement_Data
		{
			get
			{
				return this.push_Notification_Configuration_Replacement_DataField;
			}
			set
			{
				this.push_Notification_Configuration_Replacement_DataField = value;
				this.RaisePropertyChanged("Push_Notification_Configuration_Replacement_Data");
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
