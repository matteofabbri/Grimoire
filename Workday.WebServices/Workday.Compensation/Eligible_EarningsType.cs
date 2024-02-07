using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Eligible_EarningsType : INotifyPropertyChanged
	{
		private Eligible_Earnings_OverrideObjectType eligible_Earnings_ReferenceField;

		private Eligible_Earnings_DataType eligible_Earnings_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Eligible_Earnings_OverrideObjectType Eligible_Earnings_Reference
		{
			get
			{
				return this.eligible_Earnings_ReferenceField;
			}
			set
			{
				this.eligible_Earnings_ReferenceField = value;
				this.RaisePropertyChanged("Eligible_Earnings_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Eligible_Earnings_DataType Eligible_Earnings_Data
		{
			get
			{
				return this.eligible_Earnings_DataField;
			}
			set
			{
				this.eligible_Earnings_DataField = value;
				this.RaisePropertyChanged("Eligible_Earnings_Data");
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
