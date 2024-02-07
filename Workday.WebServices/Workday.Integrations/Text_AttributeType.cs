using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Text_AttributeType : INotifyPropertyChanged
	{
		private bool sensitiveField;

		private bool sensitiveFieldSpecified;

		private string valueField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Sensitive
		{
			get
			{
				return this.sensitiveField;
			}
			set
			{
				this.sensitiveField = value;
				this.RaisePropertyChanged("Sensitive");
			}
		}

		[XmlIgnore]
		public bool SensitiveSpecified
		{
			get
			{
				return this.sensitiveFieldSpecified;
			}
			set
			{
				this.sensitiveFieldSpecified = value;
				this.RaisePropertyChanged("SensitiveSpecified");
			}
		}

		[XmlText]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
				this.RaisePropertyChanged("Value");
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
