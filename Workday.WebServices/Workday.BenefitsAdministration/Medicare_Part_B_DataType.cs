using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Medicare_Part_B_DataType : INotifyPropertyChanged
	{
		private DateTime effective_DateField;

		private DateTime termination_DateField;

		private bool termination_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Termination_Date
		{
			get
			{
				return this.termination_DateField;
			}
			set
			{
				this.termination_DateField = value;
				this.RaisePropertyChanged("Termination_Date");
			}
		}

		[XmlIgnore]
		public bool Termination_DateSpecified
		{
			get
			{
				return this.termination_DateFieldSpecified;
			}
			set
			{
				this.termination_DateFieldSpecified = value;
				this.RaisePropertyChanged("Termination_DateSpecified");
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
