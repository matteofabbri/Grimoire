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
	public class HTTP_HeaderType : INotifyPropertyChanged
	{
		private string header_ValueField;

		private string header_NameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Header_Value
		{
			get
			{
				return this.header_ValueField;
			}
			set
			{
				this.header_ValueField = value;
				this.RaisePropertyChanged("Header_Value");
			}
		}

		[XmlElement(Order = 1)]
		public string Header_Name
		{
			get
			{
				return this.header_NameField;
			}
			set
			{
				this.header_NameField = value;
				this.RaisePropertyChanged("Header_Name");
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
