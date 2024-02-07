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
	public class Web_Service_Operation_Reference_DataType : INotifyPropertyChanged
	{
		private string web_Service_NameField;

		private string web_Service_Operation_NameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Web_Service_Name
		{
			get
			{
				return this.web_Service_NameField;
			}
			set
			{
				this.web_Service_NameField = value;
				this.RaisePropertyChanged("Web_Service_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Web_Service_Operation_Name
		{
			get
			{
				return this.web_Service_Operation_NameField;
			}
			set
			{
				this.web_Service_Operation_NameField = value;
				this.RaisePropertyChanged("Web_Service_Operation_Name");
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
