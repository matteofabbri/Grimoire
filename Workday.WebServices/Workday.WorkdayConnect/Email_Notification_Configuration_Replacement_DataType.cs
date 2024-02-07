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
	public class Email_Notification_Configuration_Replacement_DataType : INotifyPropertyChanged
	{
		private string email_From_Display_Name_ReferenceField;

		private string email_Reply_To_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Email_From_Display_Name_Reference
		{
			get
			{
				return this.email_From_Display_Name_ReferenceField;
			}
			set
			{
				this.email_From_Display_Name_ReferenceField = value;
				this.RaisePropertyChanged("Email_From_Display_Name_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Email_Reply_To_Reference
		{
			get
			{
				return this.email_Reply_To_ReferenceField;
			}
			set
			{
				this.email_Reply_To_ReferenceField = value;
				this.RaisePropertyChanged("Email_Reply_To_Reference");
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
