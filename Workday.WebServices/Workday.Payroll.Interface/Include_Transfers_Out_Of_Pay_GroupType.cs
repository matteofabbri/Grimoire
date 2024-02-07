using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Include_Transfers_Out_Of_Pay_GroupType : INotifyPropertyChanged
	{
		private PeriodObjectType prior_Pay_Period_ReferenceField;

		private DateTime prior_As_Of_Entry_DateTimeField;

		private bool prior_As_Of_Entry_DateTimeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public PeriodObjectType Prior_Pay_Period_Reference
		{
			get
			{
				return this.prior_Pay_Period_ReferenceField;
			}
			set
			{
				this.prior_Pay_Period_ReferenceField = value;
				this.RaisePropertyChanged("Prior_Pay_Period_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public DateTime Prior_As_Of_Entry_DateTime
		{
			get
			{
				return this.prior_As_Of_Entry_DateTimeField;
			}
			set
			{
				this.prior_As_Of_Entry_DateTimeField = value;
				this.RaisePropertyChanged("Prior_As_Of_Entry_DateTime");
			}
		}

		[XmlIgnore]
		public bool Prior_As_Of_Entry_DateTimeSpecified
		{
			get
			{
				return this.prior_As_Of_Entry_DateTimeFieldSpecified;
			}
			set
			{
				this.prior_As_Of_Entry_DateTimeFieldSpecified = value;
				this.RaisePropertyChanged("Prior_As_Of_Entry_DateTimeSpecified");
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
