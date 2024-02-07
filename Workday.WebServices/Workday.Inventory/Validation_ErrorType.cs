using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Validation_ErrorType : INotifyPropertyChanged
	{
		private string messageField;

		private string detail_MessageField;

		private string xpathField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Message
		{
			get
			{
				return this.messageField;
			}
			set
			{
				this.messageField = value;
				this.RaisePropertyChanged("Message");
			}
		}

		[XmlElement(Order = 1)]
		public string Detail_Message
		{
			get
			{
				return this.detail_MessageField;
			}
			set
			{
				this.detail_MessageField = value;
				this.RaisePropertyChanged("Detail_Message");
			}
		}

		[XmlElement(Order = 2)]
		public string Xpath
		{
			get
			{
				return this.xpathField;
			}
			set
			{
				this.xpathField = value;
				this.RaisePropertyChanged("Xpath");
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
