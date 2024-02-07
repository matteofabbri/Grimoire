using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Synonym_Webservice_DataType : INotifyPropertyChanged
	{
		private string workday_TermField;

		private string custom_TermsField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Workday_Term
		{
			get
			{
				return this.workday_TermField;
			}
			set
			{
				this.workday_TermField = value;
				this.RaisePropertyChanged("Workday_Term");
			}
		}

		[XmlElement(Order = 1)]
		public string Custom_Terms
		{
			get
			{
				return this.custom_TermsField;
			}
			set
			{
				this.custom_TermsField = value;
				this.RaisePropertyChanged("Custom_Terms");
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
