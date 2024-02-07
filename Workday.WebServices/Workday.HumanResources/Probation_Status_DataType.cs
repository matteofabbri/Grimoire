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
	public class Probation_Status_DataType : INotifyPropertyChanged
	{
		private DateTime probation_Start_DateField;

		private bool probation_Start_DateFieldSpecified;

		private DateTime probation_End_DateField;

		private bool probation_End_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Probation_Start_Date
		{
			get
			{
				return this.probation_Start_DateField;
			}
			set
			{
				this.probation_Start_DateField = value;
				this.RaisePropertyChanged("Probation_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Probation_Start_DateSpecified
		{
			get
			{
				return this.probation_Start_DateFieldSpecified;
			}
			set
			{
				this.probation_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Probation_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Probation_End_Date
		{
			get
			{
				return this.probation_End_DateField;
			}
			set
			{
				this.probation_End_DateField = value;
				this.RaisePropertyChanged("Probation_End_Date");
			}
		}

		[XmlIgnore]
		public bool Probation_End_DateSpecified
		{
			get
			{
				return this.probation_End_DateFieldSpecified;
			}
			set
			{
				this.probation_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Probation_End_DateSpecified");
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
