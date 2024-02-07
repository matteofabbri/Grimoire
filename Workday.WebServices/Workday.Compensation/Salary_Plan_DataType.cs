using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Salary_Plan_DataType : INotifyPropertyChanged
	{
		private bool apply_Full_Time_EquivalentField;

		private bool apply_Full_Time_EquivalentFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Apply_Full_Time_Equivalent
		{
			get
			{
				return this.apply_Full_Time_EquivalentField;
			}
			set
			{
				this.apply_Full_Time_EquivalentField = value;
				this.RaisePropertyChanged("Apply_Full_Time_Equivalent");
			}
		}

		[XmlIgnore]
		public bool Apply_Full_Time_EquivalentSpecified
		{
			get
			{
				return this.apply_Full_Time_EquivalentFieldSpecified;
			}
			set
			{
				this.apply_Full_Time_EquivalentFieldSpecified = value;
				this.RaisePropertyChanged("Apply_Full_Time_EquivalentSpecified");
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
