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
	public class Employer_Contribution_Percentage_DataType : INotifyPropertyChanged
	{
		private decimal election_PercentageField;

		private bool election_PercentageFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Election_Percentage
		{
			get
			{
				return this.election_PercentageField;
			}
			set
			{
				this.election_PercentageField = value;
				this.RaisePropertyChanged("Election_Percentage");
			}
		}

		[XmlIgnore]
		public bool Election_PercentageSpecified
		{
			get
			{
				return this.election_PercentageFieldSpecified;
			}
			set
			{
				this.election_PercentageFieldSpecified = value;
				this.RaisePropertyChanged("Election_PercentageSpecified");
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
