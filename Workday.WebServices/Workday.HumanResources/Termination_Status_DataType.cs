using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Termination_Status_DataType : INotifyPropertyChanged
	{
		private bool terminatedField;

		private bool terminatedFieldSpecified;

		private DateTime termination_DateField;

		private bool termination_DateFieldSpecified;

		private string termination_CategoryField;

		private string termination_ReasonField;

		private bool involuntary_TerminationField;

		private bool involuntary_TerminationFieldSpecified;

		private bool not_Eligible_For_HireField;

		private bool not_Eligible_For_HireFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Terminated
		{
			get
			{
				return this.terminatedField;
			}
			set
			{
				this.terminatedField = value;
				this.RaisePropertyChanged("Terminated");
			}
		}

		[XmlIgnore]
		public bool TerminatedSpecified
		{
			get
			{
				return this.terminatedFieldSpecified;
			}
			set
			{
				this.terminatedFieldSpecified = value;
				this.RaisePropertyChanged("TerminatedSpecified");
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

		[XmlElement(Order = 2)]
		public string Termination_Category
		{
			get
			{
				return this.termination_CategoryField;
			}
			set
			{
				this.termination_CategoryField = value;
				this.RaisePropertyChanged("Termination_Category");
			}
		}

		[XmlElement(Order = 3)]
		public string Termination_Reason
		{
			get
			{
				return this.termination_ReasonField;
			}
			set
			{
				this.termination_ReasonField = value;
				this.RaisePropertyChanged("Termination_Reason");
			}
		}

		[XmlElement(Order = 4)]
		public bool Involuntary_Termination
		{
			get
			{
				return this.involuntary_TerminationField;
			}
			set
			{
				this.involuntary_TerminationField = value;
				this.RaisePropertyChanged("Involuntary_Termination");
			}
		}

		[XmlIgnore]
		public bool Involuntary_TerminationSpecified
		{
			get
			{
				return this.involuntary_TerminationFieldSpecified;
			}
			set
			{
				this.involuntary_TerminationFieldSpecified = value;
				this.RaisePropertyChanged("Involuntary_TerminationSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Not_Eligible_For_Hire
		{
			get
			{
				return this.not_Eligible_For_HireField;
			}
			set
			{
				this.not_Eligible_For_HireField = value;
				this.RaisePropertyChanged("Not_Eligible_For_Hire");
			}
		}

		[XmlIgnore]
		public bool Not_Eligible_For_HireSpecified
		{
			get
			{
				return this.not_Eligible_For_HireFieldSpecified;
			}
			set
			{
				this.not_Eligible_For_HireFieldSpecified = value;
				this.RaisePropertyChanged("Not_Eligible_For_HireSpecified");
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
