using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Carryover_Override_Balance_Units_DataType : INotifyPropertyChanged
	{
		private DateTime carryover_Expiration_DateField;

		private bool carryover_Expiration_DateFieldSpecified;

		private decimal carryover_Override_Balance_UnitsField;

		private bool carryover_Override_Balance_UnitsFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Carryover_Expiration_Date
		{
			get
			{
				return this.carryover_Expiration_DateField;
			}
			set
			{
				this.carryover_Expiration_DateField = value;
				this.RaisePropertyChanged("Carryover_Expiration_Date");
			}
		}

		[XmlIgnore]
		public bool Carryover_Expiration_DateSpecified
		{
			get
			{
				return this.carryover_Expiration_DateFieldSpecified;
			}
			set
			{
				this.carryover_Expiration_DateFieldSpecified = value;
				this.RaisePropertyChanged("Carryover_Expiration_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Carryover_Override_Balance_Units
		{
			get
			{
				return this.carryover_Override_Balance_UnitsField;
			}
			set
			{
				this.carryover_Override_Balance_UnitsField = value;
				this.RaisePropertyChanged("Carryover_Override_Balance_Units");
			}
		}

		[XmlIgnore]
		public bool Carryover_Override_Balance_UnitsSpecified
		{
			get
			{
				return this.carryover_Override_Balance_UnitsFieldSpecified;
			}
			set
			{
				this.carryover_Override_Balance_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Carryover_Override_Balance_UnitsSpecified");
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
