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
	public class Exception_DataType : INotifyPropertyChanged
	{
		private string classificationField;

		private string messageField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Classification
		{
			get
			{
				return this.classificationField;
			}
			set
			{
				this.classificationField = value;
				this.RaisePropertyChanged("Classification");
			}
		}

		[XmlElement(Order = 1)]
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
