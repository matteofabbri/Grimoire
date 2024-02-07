using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Admissions
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Email_Address_Information_DataType : INotifyPropertyChanged
	{
		private string email_AddressField;

		private string email_CommentField;

		private Communication_Method_Usage_Information_DataType[] usage_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Email_Address
		{
			get
			{
				return this.email_AddressField;
			}
			set
			{
				this.email_AddressField = value;
				this.RaisePropertyChanged("Email_Address");
			}
		}

		[XmlElement(Order = 1)]
		public string Email_Comment
		{
			get
			{
				return this.email_CommentField;
			}
			set
			{
				this.email_CommentField = value;
				this.RaisePropertyChanged("Email_Comment");
			}
		}

		[XmlElement("Usage_Data", Order = 2)]
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
