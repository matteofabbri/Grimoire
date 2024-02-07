using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Communication_Usage_Type_ReferenceType : INotifyPropertyChanged
	{
		private bool primaryField;

		private bool primaryFieldSpecified;

		private string valueField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Primary
		{
			get
			{
				return this.primaryField;
			}
			set
			{
				this.primaryField = value;
				this.RaisePropertyChanged("Primary");
			}
		}

		[XmlIgnore]
		public bool PrimarySpecified
		{
			get
			{
				return this.primaryFieldSpecified;
			}
			set
			{
				this.primaryFieldSpecified = value;
				this.RaisePropertyChanged("PrimarySpecified");
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
