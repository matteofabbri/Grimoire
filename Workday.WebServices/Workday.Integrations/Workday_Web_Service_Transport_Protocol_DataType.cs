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
	public class Workday_Web_Service_Transport_Protocol_DataType : INotifyPropertyChanged
	{
		private Web_Service_Operation_Reference_DataType web_Service_Operation_Reference_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Web_Service_Operation_Reference_DataType Web_Service_Operation_Reference_Data
		{
			get
			{
				return this.web_Service_Operation_Reference_DataField;
			}
			set
			{
				this.web_Service_Operation_Reference_DataField = value;
				this.RaisePropertyChanged("Web_Service_Operation_Reference_Data");
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
