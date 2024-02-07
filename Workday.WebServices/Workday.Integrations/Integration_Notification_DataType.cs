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
	public class Integration_Notification_DataType : INotifyPropertyChanged
	{
		private object[] itemsField;

		private Integration_Notification_Integration_Condition_DataType[] notification_Condition_DataField;

		private External_FieldObjectType loops_On_External_Field_ReferenceField;

		private External_FieldObjectType[] notification_Notifies_DataField;

		private Security_GroupObjectType[] security_Group_ReferenceField;

		private Internet_Email_Address_Data_for_NotificationsType[] email_Address_DataField;

		private Notification_Message_Component_DataType[] notification_Subject_DataField;

		private Notification_Message_Component_DataType[] notification_Body_DataField;

		private External_FieldObjectType[] notification_Attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Trigger_on_Launch", typeof(bool), Order = 0), XmlElement("Trigger_on_Status_Reference", typeof(Background_Process_Runtime_StatusObjectType), Order = 0)]
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

		[XmlElement("Notification_Condition_Data", Order = 1)]
		public Integration_Notification_Integration_Condition_DataType[] Notification_Condition_Data
		{
			get
			{
				return this.notification_Condition_DataField;
			}
			set
			{
				this.notification_Condition_DataField = value;
				this.RaisePropertyChanged("Notification_Condition_Data");
			}
		}

		[XmlElement(Order = 2)]
		public External_FieldObjectType Loops_On_External_Field_Reference
		{
			get
			{
				return this.loops_On_External_Field_ReferenceField;
			}
			set
			{
				this.loops_On_External_Field_ReferenceField = value;
				this.RaisePropertyChanged("Loops_On_External_Field_Reference");
			}
		}

		[XmlArray(Order = 3), XmlArrayItem("Notifies_Recipient_External_Field_Reference", IsNullable = false)]
		public External_FieldObjectType[] Notification_Notifies_Data
		{
			get
			{
				return this.notification_Notifies_DataField;
			}
			set
			{
				this.notification_Notifies_DataField = value;
				this.RaisePropertyChanged("Notification_Notifies_Data");
			}
		}

		[XmlElement("Security_Group_Reference", Order = 4)]
		public Security_GroupObjectType[] Security_Group_Reference
		{
			get
			{
				return this.security_Group_ReferenceField;
			}
			set
			{
				this.security_Group_ReferenceField = value;
				this.RaisePropertyChanged("Security_Group_Reference");
			}
		}

		[XmlElement("Email_Address_Data", Order = 5)]
		public Internet_Email_Address_Data_for_NotificationsType[] Email_Address_Data
		{
			get
			{
				return this.email_Address_DataField;
			}
			set
			{
				this.email_Address_DataField = value;
				this.RaisePropertyChanged("Email_Address_Data");
			}
		}

		[XmlArray(Order = 6), XmlArrayItem("Notification_Message_Component_Data", IsNullable = false)]
		public Notification_Message_Component_DataType[] Notification_Subject_Data
		{
			get
			{
				return this.notification_Subject_DataField;
			}
			set
			{
				this.notification_Subject_DataField = value;
				this.RaisePropertyChanged("Notification_Subject_Data");
			}
		}

		[XmlArray(Order = 7), XmlArrayItem("Notification_Body_Data", IsNullable = false)]
		public Notification_Message_Component_DataType[] Notification_Body_Data
		{
			get
			{
				return this.notification_Body_DataField;
			}
			set
			{
				this.notification_Body_DataField = value;
				this.RaisePropertyChanged("Notification_Body_Data");
			}
		}

		[XmlArray(Order = 8), XmlArrayItem("Attachment_External_Field_Reference", IsNullable = false)]
		public External_FieldObjectType[] Notification_Attachment_Data
		{
			get
			{
				return this.notification_Attachment_DataField;
			}
			set
			{
				this.notification_Attachment_DataField = value;
				this.RaisePropertyChanged("Notification_Attachment_Data");
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
