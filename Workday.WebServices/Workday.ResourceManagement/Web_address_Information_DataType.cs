using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Web_address_Information_DataType : INotifyPropertyChanged
	{
		private string web_AddressField;

		private string web_Address_CommentField;

		private Communication_Method_Usage_Information_DataType[] usage_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Web_Address
		{
			get
			{
				return this.web_AddressField;
			}
			set
			{
				this.web_AddressField = value;
				this.RaisePropertyChanged("Web_Address");
			}
		}

		[XmlElement(Order = 1)]
		public string Web_Address_Comment
		{
			get
			{
				return this.web_Address_CommentField;
			}
			set
			{
				this.web_Address_CommentField = value;
				this.RaisePropertyChanged("Web_Address_Comment");
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
