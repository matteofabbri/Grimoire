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
	public class Compensation_Step_Reference_DataType : INotifyPropertyChanged
	{
		private string compensation_Step_NameField;

		private DateTime progression_Start_DateField;

		private bool progression_Start_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Compensation_Step_Name
		{
			get
			{
				return this.compensation_Step_NameField;
			}
			set
			{
				this.compensation_Step_NameField = value;
				this.RaisePropertyChanged("Compensation_Step_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Progression_Start_Date
		{
			get
			{
				return this.progression_Start_DateField;
			}
			set
			{
				this.progression_Start_DateField = value;
				this.RaisePropertyChanged("Progression_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Progression_Start_DateSpecified
		{
			get
			{
				return this.progression_Start_DateFieldSpecified;
			}
			set
			{
				this.progression_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Progression_Start_DateSpecified");
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
