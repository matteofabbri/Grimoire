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
	public class ESRD_DataType : INotifyPropertyChanged
	{
		private DateTime coordination_Period_Start_DateField;

		private DateTime coordination_Period_End_DateField;

		private bool coordination_Period_End_DateFieldSpecified;

		private DateTime eSRD_Self_Training_DateField;

		private bool eSRD_Self_Training_DateFieldSpecified;

		private DateTime first_Dialysis_DateField;

		private bool first_Dialysis_DateFieldSpecified;

		private DateTime transplant_DateField;

		private bool transplant_DateFieldSpecified;

		private DateTime transplant_Failure_DateField;

		private bool transplant_Failure_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Coordination_Period_Start_Date
		{
			get
			{
				return this.coordination_Period_Start_DateField;
			}
			set
			{
				this.coordination_Period_Start_DateField = value;
				this.RaisePropertyChanged("Coordination_Period_Start_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Coordination_Period_End_Date
		{
			get
			{
				return this.coordination_Period_End_DateField;
			}
			set
			{
				this.coordination_Period_End_DateField = value;
				this.RaisePropertyChanged("Coordination_Period_End_Date");
			}
		}

		[XmlIgnore]
		public bool Coordination_Period_End_DateSpecified
		{
			get
			{
				return this.coordination_Period_End_DateFieldSpecified;
			}
			set
			{
				this.coordination_Period_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Coordination_Period_End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime ESRD_Self_Training_Date
		{
			get
			{
				return this.eSRD_Self_Training_DateField;
			}
			set
			{
				this.eSRD_Self_Training_DateField = value;
				this.RaisePropertyChanged("ESRD_Self_Training_Date");
			}
		}

		[XmlIgnore]
		public bool ESRD_Self_Training_DateSpecified
		{
			get
			{
				return this.eSRD_Self_Training_DateFieldSpecified;
			}
			set
			{
				this.eSRD_Self_Training_DateFieldSpecified = value;
				this.RaisePropertyChanged("ESRD_Self_Training_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime First_Dialysis_Date
		{
			get
			{
				return this.first_Dialysis_DateField;
			}
			set
			{
				this.first_Dialysis_DateField = value;
				this.RaisePropertyChanged("First_Dialysis_Date");
			}
		}

		[XmlIgnore]
		public bool First_Dialysis_DateSpecified
		{
			get
			{
				return this.first_Dialysis_DateFieldSpecified;
			}
			set
			{
				this.first_Dialysis_DateFieldSpecified = value;
				this.RaisePropertyChanged("First_Dialysis_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Transplant_Date
		{
			get
			{
				return this.transplant_DateField;
			}
			set
			{
				this.transplant_DateField = value;
				this.RaisePropertyChanged("Transplant_Date");
			}
		}

		[XmlIgnore]
		public bool Transplant_DateSpecified
		{
			get
			{
				return this.transplant_DateFieldSpecified;
			}
			set
			{
				this.transplant_DateFieldSpecified = value;
				this.RaisePropertyChanged("Transplant_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Transplant_Failure_Date
		{
			get
			{
				return this.transplant_Failure_DateField;
			}
			set
			{
				this.transplant_Failure_DateField = value;
				this.RaisePropertyChanged("Transplant_Failure_Date");
			}
		}

		[XmlIgnore]
		public bool Transplant_Failure_DateSpecified
		{
			get
			{
				return this.transplant_Failure_DateFieldSpecified;
			}
			set
			{
				this.transplant_Failure_DateFieldSpecified = value;
				this.RaisePropertyChanged("Transplant_Failure_DateSpecified");
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
