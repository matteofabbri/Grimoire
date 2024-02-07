using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Prospect_Request_CriteriaType : INotifyPropertyChanged
	{
		private string prospect_NameField;

		private string prospect_IDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Prospect_Name
		{
			get
			{
				return this.prospect_NameField;
			}
			set
			{
				this.prospect_NameField = value;
				this.RaisePropertyChanged("Prospect_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Prospect_ID
		{
			get
			{
				return this.prospect_IDField;
			}
			set
			{
				this.prospect_IDField = value;
				this.RaisePropertyChanged("Prospect_ID");
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
