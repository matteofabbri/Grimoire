using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class External_IDType : INotifyPropertyChanged
	{
		private string external_IDField;

		private string system_IDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string External_ID
		{
			get
			{
				return this.external_IDField;
			}
			set
			{
				this.external_IDField = value;
				this.RaisePropertyChanged("External_ID");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string System_ID
		{
			get
			{
				return this.system_IDField;
			}
			set
			{
				this.system_IDField = value;
				this.RaisePropertyChanged("System_ID");
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
