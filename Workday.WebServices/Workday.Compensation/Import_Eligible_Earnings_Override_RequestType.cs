using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Import_Eligible_Earnings_Override_RequestType : INotifyPropertyChanged
	{
		private Eligible_Earnings_Override_PeriodObjectType eligible_Earnings_Override_Period_ReferenceField;

		private Import_Eligible_Earnings_Override__HV__RequestType[] eligible_EarningsField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Eligible_Earnings_Override_PeriodObjectType Eligible_Earnings_Override_Period_Reference
		{
			get
			{
				return this.eligible_Earnings_Override_Period_ReferenceField;
			}
			set
			{
				this.eligible_Earnings_Override_Period_ReferenceField = value;
				this.RaisePropertyChanged("Eligible_Earnings_Override_Period_Reference");
			}
		}

		[XmlElement("Eligible_Earnings", Order = 1)]
		public Import_Eligible_Earnings_Override__HV__RequestType[] Eligible_Earnings
		{
			get
			{
				return this.eligible_EarningsField;
			}
			set
			{
				this.eligible_EarningsField = value;
				this.RaisePropertyChanged("Eligible_Earnings");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
