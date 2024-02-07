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
	public class Compensation_Eligibility_Rule_Response_GroupType : INotifyPropertyChanged
	{
		private bool hide_Configuration_DependenciesField;

		private bool hide_Configuration_DependenciesFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Hide_Configuration_Dependencies
		{
			get
			{
				return this.hide_Configuration_DependenciesField;
			}
			set
			{
				this.hide_Configuration_DependenciesField = value;
				this.RaisePropertyChanged("Hide_Configuration_Dependencies");
			}
		}

		[XmlIgnore]
		public bool Hide_Configuration_DependenciesSpecified
		{
			get
			{
				return this.hide_Configuration_DependenciesFieldSpecified;
			}
			set
			{
				this.hide_Configuration_DependenciesFieldSpecified = value;
				this.RaisePropertyChanged("Hide_Configuration_DependenciesSpecified");
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
