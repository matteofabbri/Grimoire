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
	public class Student_Employment_Eligibility_Reason_DataType : INotifyPropertyChanged
	{
		private string reason_for_IneligibilityField;

		private bool criticalField;

		private bool criticalFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Reason_for_Ineligibility
		{
			get
			{
				return this.reason_for_IneligibilityField;
			}
			set
			{
				this.reason_for_IneligibilityField = value;
				this.RaisePropertyChanged("Reason_for_Ineligibility");
			}
		}

		[XmlElement(Order = 1)]
		public bool Critical
		{
			get
			{
				return this.criticalField;
			}
			set
			{
				this.criticalField = value;
				this.RaisePropertyChanged("Critical");
			}
		}

		[XmlIgnore]
		public bool CriticalSpecified
		{
			get
			{
				return this.criticalFieldSpecified;
			}
			set
			{
				this.criticalFieldSpecified = value;
				this.RaisePropertyChanged("CriticalSpecified");
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
