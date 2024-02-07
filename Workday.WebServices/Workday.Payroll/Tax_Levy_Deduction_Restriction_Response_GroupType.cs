using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Tax_Levy_Deduction_Restriction_Response_GroupType : INotifyPropertyChanged
	{
		private bool exclude_Baseline_RestrictionsField;

		private bool exclude_Baseline_RestrictionsFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Exclude_Baseline_Restrictions
		{
			get
			{
				return this.exclude_Baseline_RestrictionsField;
			}
			set
			{
				this.exclude_Baseline_RestrictionsField = value;
				this.RaisePropertyChanged("Exclude_Baseline_Restrictions");
			}
		}

		[XmlIgnore]
		public bool Exclude_Baseline_RestrictionsSpecified
		{
			get
			{
				return this.exclude_Baseline_RestrictionsFieldSpecified;
			}
			set
			{
				this.exclude_Baseline_RestrictionsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Baseline_RestrictionsSpecified");
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
