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
	public class Benefit_Election_Covered_Person_DataType : INotifyPropertyChanged
	{
		private DateTime birth_DateField;

		private bool birth_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Birth_Date
		{
			get
			{
				return this.birth_DateField;
			}
			set
			{
				this.birth_DateField = value;
				this.RaisePropertyChanged("Birth_Date");
			}
		}

		[XmlIgnore]
		public bool Birth_DateSpecified
		{
			get
			{
				return this.birth_DateFieldSpecified;
			}
			set
			{
				this.birth_DateFieldSpecified = value;
				this.RaisePropertyChanged("Birth_DateSpecified");
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
