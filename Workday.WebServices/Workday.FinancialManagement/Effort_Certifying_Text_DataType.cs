using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Effort_Certifying_Text_DataType : INotifyPropertyChanged
	{
		private string effort_Certifying_Text_IDField;

		private string effort_Certifying_Text_NameField;

		private string effort_Certifying_TextField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Effort_Certifying_Text_ID
		{
			get
			{
				return this.effort_Certifying_Text_IDField;
			}
			set
			{
				this.effort_Certifying_Text_IDField = value;
				this.RaisePropertyChanged("Effort_Certifying_Text_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Effort_Certifying_Text_Name
		{
			get
			{
				return this.effort_Certifying_Text_NameField;
			}
			set
			{
				this.effort_Certifying_Text_NameField = value;
				this.RaisePropertyChanged("Effort_Certifying_Text_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Effort_Certifying_Text
		{
			get
			{
				return this.effort_Certifying_TextField;
			}
			set
			{
				this.effort_Certifying_TextField = value;
				this.RaisePropertyChanged("Effort_Certifying_Text");
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
