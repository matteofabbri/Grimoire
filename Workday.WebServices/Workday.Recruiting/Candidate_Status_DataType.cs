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
	public class Candidate_Status_DataType : INotifyPropertyChanged
	{
		private bool do_Not_HireField;

		private bool do_Not_HireFieldSpecified;

		private bool withdrawnField;

		private bool withdrawnFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Do_Not_Hire
		{
			get
			{
				return this.do_Not_HireField;
			}
			set
			{
				this.do_Not_HireField = value;
				this.RaisePropertyChanged("Do_Not_Hire");
			}
		}

		[XmlIgnore]
		public bool Do_Not_HireSpecified
		{
			get
			{
				return this.do_Not_HireFieldSpecified;
			}
			set
			{
				this.do_Not_HireFieldSpecified = value;
				this.RaisePropertyChanged("Do_Not_HireSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Withdrawn
		{
			get
			{
				return this.withdrawnField;
			}
			set
			{
				this.withdrawnField = value;
				this.RaisePropertyChanged("Withdrawn");
			}
		}

		[XmlIgnore]
		public bool WithdrawnSpecified
		{
			get
			{
				return this.withdrawnFieldSpecified;
			}
			set
			{
				this.withdrawnFieldSpecified = value;
				this.RaisePropertyChanged("WithdrawnSpecified");
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
