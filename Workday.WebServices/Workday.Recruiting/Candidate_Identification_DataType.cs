using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Candidate_Identification_DataType : INotifyPropertyChanged
	{
		private National_IDType[] national_IDField;

		private Government_IDType[] government_IDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("National_ID", Order = 0)]
		public National_IDType[] National_ID
		{
			get
			{
				return this.national_IDField;
			}
			set
			{
				this.national_IDField = value;
				this.RaisePropertyChanged("National_ID");
			}
		}

		[XmlElement("Government_ID", Order = 1)]
		public Government_IDType[] Government_ID
		{
			get
			{
				return this.government_IDField;
			}
			set
			{
				this.government_IDField = value;
				this.RaisePropertyChanged("Government_ID");
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
