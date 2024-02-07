using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Maintain_Notice_Periods_for_Country_DataType : INotifyPropertyChanged
	{
		private CountryObjectType country_ReferenceField;

		private Notice_Period_Line_for_CountryType[] notice_Period_Line_for_CountryField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CountryObjectType Country_Reference
		{
			get
			{
				return this.country_ReferenceField;
			}
			set
			{
				this.country_ReferenceField = value;
				this.RaisePropertyChanged("Country_Reference");
			}
		}

		[XmlElement("Notice_Period_Line_for_Country", Order = 1)]
		public Notice_Period_Line_for_CountryType[] Notice_Period_Line_for_Country
		{
			get
			{
				return this.notice_Period_Line_for_CountryField;
			}
			set
			{
				this.notice_Period_Line_for_CountryField = value;
				this.RaisePropertyChanged("Notice_Period_Line_for_Country");
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
